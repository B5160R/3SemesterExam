﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace UnikOpstart.Services.Booking.Crosscut.TransactionHandling.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly DbContext _db;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DbContext db)
        {
            _db = db;
        }
        void IUnitOfWork.BeginTransaction(IsolationLevel isolationLevel)
        {
            _transaction = _db.Database.CurrentTransaction ?? _db.Database.BeginTransaction(isolationLevel);

        }

        void IUnitOfWork.Commit()
        {
            _transaction.Commit();
            _transaction.Dispose();
        }

        void IUnitOfWork.Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}

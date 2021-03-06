﻿using BusinessLogic.Constants;
using BusinessLogic.Repositories;
using NUnit.Framework;

namespace SchoolAccountantTest
{
    [TestFixture]
    class AuditTrailRepositoryTest
    {
        private readonly AuditTrailRepository _auditTrailRepository = new AuditTrailRepository();

        [Test]
        public void LogDoesNotReturnNullAndDeleteLogReturnsTrue()
        {
            var auditTrail = _auditTrailRepository.Log("Test", AuditActionEnum.Created);

            Assert.AreNotEqual(null, auditTrail);

            var success =  _auditTrailRepository.DeleteLog(auditTrail.Id);

            Assert.AreEqual(true, success);

        }

    }
}

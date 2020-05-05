namespace WebApi.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Domain.Accounts;
    using Domain.Accounts.Credits;
    using Domain.Accounts.Debits;

    /// <summary>
    ///     Account Details.
    /// </summary>
    public sealed class AccountModel
    {
        public AccountModel(IAccount account)
        {
            var accountEntity = (Account)account;
            this.AccountId = accountEntity.Id.ToGuid();
            this.CurrentBalance = accountEntity.GetCurrentBalance().ToDecimal();
        }

        /// <summary>
        ///     Gets account ID.
        /// </summary>
        [Required]
        public Guid AccountId { get; }

        /// <summary>
        ///     Gets current Balance.
        /// </summary>
        [Required]
        public decimal CurrentBalance { get; }
    }
}
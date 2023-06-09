﻿using SpaceWar.Api.Common;
using SpaceWar.Api.Entities;

namespace SpaceWar.Api.Repositories.Abstract;

public interface IAccountRepository
{
    Task<AccountOperationsResult> CreateAccountAsync(AccountEntity account);
    Task<AccountEntity?> GetAccountByEmailAndPasswordAsync(string email, string passwordHash);
    Task<AccountOperationsResult> ChangeUsernameAsync(string email, string passwordHash, string newUsername);
    Task<AccountOperationsResult> ChangePasswordAsync(Guid accountId, string oldPasswordHash, string newPasswordHash);
}
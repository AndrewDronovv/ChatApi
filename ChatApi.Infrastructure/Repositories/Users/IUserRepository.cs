﻿using ChatApi.Domain.Entities;

namespace ChatApi.Application.Repositories.Users;

public interface IUserRepository
{
    Task<User> GetByLoginAsync(string login);
    Task AddAsync(User user);
    Task SaveRefreshTokenAsync(RefreshToken refreshToken);
    Task<RefreshToken> GetRefreshTokenAsync(string token);
    Task UpdateRefreshTokenAsync(RefreshToken refreshToken);
    Task<IEnumerable<RefreshToken>> GetActiveRefreshTokensByUserIdAsync(int userId);
    Task RevokeAllActiveRefreshTokensAsync(int userId);
    Task DeleteRefreshTokensAsync(IEnumerable<RefreshToken> refreshTokens);
    Task<List<string>> GetUserRefreshTokenStringsAsync(int userId);
}

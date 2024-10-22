﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace App.ServiceInstallers.Authentication;

/// <summary>
/// Represents the <see cref="AuthenticationOptions"/> setup.
/// </summary>
internal sealed class AuthenticationOptionsSetup : IConfigureOptions<AuthenticationOptions>
{
    /// <inheritdoc />
    public void Configure(AuthenticationOptions options) => options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}

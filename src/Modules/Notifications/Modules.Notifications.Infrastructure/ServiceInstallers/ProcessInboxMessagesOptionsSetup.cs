﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Modules.Notifications.Infrastructure.BackgroundJobs.ProcessInboxMessages;

namespace Modules.Notifications.Infrastructure.ServiceInstallers;

/// <summary>
/// Represents the <see cref="ProcessInboxMessagesOptions"/> setup.
/// </summary>
internal sealed class ProcessInboxMessagesOptionsSetup : IConfigureOptions<ProcessInboxMessagesOptions>
{
    private const string ConfigurationSectionName = "Modules:Notifications:BackgroundJobs:ProcessInboxMessages";
    private readonly IConfiguration _configuration;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProcessInboxMessagesOptionsSetup"/> class.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    public ProcessInboxMessagesOptionsSetup(IConfiguration configuration) => _configuration = configuration;

    /// <inheritdoc />
    public void Configure(ProcessInboxMessagesOptions options) => _configuration.GetSection(ConfigurationSectionName).Bind(options);
}

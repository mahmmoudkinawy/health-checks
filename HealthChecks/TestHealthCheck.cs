using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TestingKnowlodgeForHealtchChecks.Api.HealthChecks;

public class TestHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default)
    {
        var randomNumber = Random.Shared.Next(500);

        if (randomNumber < 100)
        {
            return Task.FromResult(
                HealthCheckResult.Healthy($"The application is Healthy."));
        }
        else if (randomNumber < 200)
        {
            return Task.FromResult(
                HealthCheckResult.Degraded($"The application is Degraded."));
        }

        return Task.FromResult(
            HealthCheckResult.Unhealthy($"The application is Unhealthy."));
    }

}

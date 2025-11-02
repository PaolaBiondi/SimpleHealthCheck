using Microsoft.Extensions.Diagnostics.HealthChecks;

internal class ExampleHealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        if (DateTime.UtcNow.Second % 2 == 0)
        {
            return Task.FromResult(HealthCheckResult.Unhealthy("The check indicates an unhealthy result."));
        }

        return Task.FromResult(HealthCheckResult.Healthy("The check indicates a healthy result."));
    }
}
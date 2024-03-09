using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Clarivate.com.Model
{
    public class SampleHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = true;
            if (isHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Healthy Status"));
            }
            return Task.FromResult(new HealthCheckResult(context.Registration.FailureStatus, "Unhealthy status"));
        }
    }
}

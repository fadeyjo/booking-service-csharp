using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace BookingService.Extensions;

public static class DbUpdateExceptionExtensions
{
    public static bool IsUniqueConstraintViolation(this DbUpdateException exception)
        => exception.InnerException is PostgresException { SqlState: PostgresErrorCodes.UniqueViolation };
}
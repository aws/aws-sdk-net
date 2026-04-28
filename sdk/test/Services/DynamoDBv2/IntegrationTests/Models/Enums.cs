using System;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public enum Status : long
    {
        Active = 256,
        Inactive = 1024,
        Upcoming = 9999,
        Obsolete = -10,
        Removed = 42
    }

    [Flags]
    public enum Support
    {
        Windows = 1 << 0,
        iOS = 1 << 1,
        Unix = 1 << 2,
        Abacus = 1 << 3,
    }
}

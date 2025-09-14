using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Paginations.Tests;

[Collection("Collection")]
public sealed class PaginationTests : FixturedUnitTest
{
    public PaginationTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

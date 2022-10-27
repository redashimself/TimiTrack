using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TimiTrack.Pages;

[Collection(TimiTrackTestConsts.CollectionDefinitionName)]
public class Index_Tests : TimiTrackWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

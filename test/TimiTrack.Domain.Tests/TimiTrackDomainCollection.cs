using TimiTrack.MongoDB;
using Xunit;

namespace TimiTrack;

[CollectionDefinition(TimiTrackTestConsts.CollectionDefinitionName)]
public class TimiTrackDomainCollection : TimiTrackMongoDbCollectionFixtureBase
{

}

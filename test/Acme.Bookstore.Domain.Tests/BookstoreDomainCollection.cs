using Acme.Bookstore.MongoDB;
using Xunit;

namespace Acme.Bookstore;

[CollectionDefinition(BookstoreTestConsts.CollectionDefinitionName)]
public class BookstoreDomainCollection : BookstoreMongoDbCollectionFixtureBase
{

}

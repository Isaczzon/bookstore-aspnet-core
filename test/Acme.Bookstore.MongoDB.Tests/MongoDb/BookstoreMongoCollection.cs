using Xunit;

namespace Acme.Bookstore.MongoDB;

[CollectionDefinition(BookstoreTestConsts.CollectionDefinitionName)]
public class BookstoreMongoCollection : BookstoreMongoDbCollectionFixtureBase
{

}

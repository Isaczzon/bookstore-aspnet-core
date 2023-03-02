using Acme.Bookstore.MongoDB;
using Xunit;

namespace Acme.Bookstore;

[CollectionDefinition(BookstoreTestConsts.CollectionDefinitionName)]
public class BookstoreApplicationCollection : BookstoreMongoDbCollectionFixtureBase
{

}

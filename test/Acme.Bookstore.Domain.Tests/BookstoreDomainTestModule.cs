using Acme.Bookstore.MongoDB;
using Volo.Abp.Modularity;

namespace Acme.Bookstore;

[DependsOn(
    typeof(BookstoreMongoDbTestModule)
    )]
public class BookstoreDomainTestModule : AbpModule
{

}

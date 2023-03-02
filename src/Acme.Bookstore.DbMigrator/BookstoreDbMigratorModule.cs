using Acme.Bookstore.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Bookstore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookstoreMongoDbModule),
    typeof(BookstoreApplicationContractsModule)
)]
public class BookstoreDbMigratorModule : AbpModule
{

}


Db first

预备Code
 public class BloggingContext : DbContext
 public DbSet<Blog> Blogs { get; set; }

1.第一次初始化：
Add-Migration InitialCreate

2.同步到db
Update-Database


3.结构更改：
实际变动后修改

Add-Migration UpdateBlogerTable


4.再次同步到db
Update-Database


5.如果其中修改后出错了，或者想放弃这次修改
Remove-Migration


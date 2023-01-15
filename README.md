An application with:<br />
.Net Core  7 (Entity Framework)<br />
React (Typescript)<br />
Dependency Injection (MediatR)<br />
Clean Architecture<br />
CQRS (Command Query Responsibility Segregation)<br />
Semantic-ui<br /><br />

Clean Architecture: Clean Architecture mimarisi, Business Logic ve Application modelini uygulamanın merkezine (Application Core) koyar. Business Logic veri erişimine veya diğer infrastructure sorunlarına bağlı olması yerine, bu bağımlılık tersine çevrilir: infrastructure ve application ayrıntıları Application Core bağlıdır. Bu işlevselliği sağlamak için Application Core tarafında interface veya abstraction tanımlamaları yapılıp, bu soyut tiplerin implementasyonları da Infrastructure tarafında yapılarak sağlanır. Bu mimariyi görselleştirirken, soğana benzer bir dizi eş merkezli daire kullanmaktır.
<br /><br />
Dependency Injection (MediatR): Mediator, tek bir aracı(mediator) nesnesi içerisinde çeşitli nesneler arasındaki karmaşık ilişkiler ağını yönetmenize olanak tanıyan bir tasarım desenidir.
<br /><br />
CQRS: Özünde Command Query Responsibility Segregation‘ın kısaltılmış halidir. Açılımından da anlaşılacağı üzere ‘Command’ ve ‘Query’ sorumluluklarının ayrılması prensibini esas alan bir yaklaşımı savunmaktadır. (Commad= Update, Create, Delete) , (Query: List, Getbyid).
<br /><br />
Semantic-ui: ReactJs uyumlu bir hazır Css kütüphanesidir.

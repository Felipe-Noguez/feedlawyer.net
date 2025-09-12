using FeedLawyer.Domain.Contracts.Abstractions;
using FeedLawyer.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Infrastructure.Persistence
{
    /// <summary>
    /// Esta classe representa a implementação concreta do padrão Unit of Work.
    /// Sua principal função é agrupar as operações de banco de dados em uma única transação atômica,
    /// garantindo que todas as alterações (adições, atualizações, remoções) sejam salvas
    /// ou revertidas em conjunto. Ela encapsula o 'DbContext' para centralizar a lógica de persistência.
    ///
    /// O método 'CommitAsync()' é a ação que efetivamente salva as alterações.
    /// Ele delega a responsabilidade para o '_context.SaveChangesAsync()',
    /// que rastreia todas as entidades modificadas e as persiste no banco de dados.
    /// Se qualquer uma das operações falhar, toda a transação é desfeita,
    /// garantindo a integridade dos dados.
    ///
    /// Motivo de estar na camada de Infraestrutura:
    /// A camada de Infraestrutura é responsável por lidar com os detalhes técnicos
    /// de persistência de dados. O UnitOfWork é a implementação da interface de domínio
    /// (IUnitOfWork) e lida diretamente com o 'DbContext', que é a tecnologia de acesso a dados.
    /// Portanto, ela pertence a esta camada para manter o desacoplamento das outras partes da aplicação.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public Task CommitAsync() => _context.SaveChangesAsync();
    }
}

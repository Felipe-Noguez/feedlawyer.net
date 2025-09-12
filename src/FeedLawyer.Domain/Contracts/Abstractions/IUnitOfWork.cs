using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Domain.Contracts.Abstractions
{
    /// <summary>
    /// Esta interface define o contrato do padrão Unit of Work.
    /// Sua função é ser uma abstração que representa uma transação de negócio.
    /// Ela expõe o método 'CommitAsync()', que é responsável por persistir todas as alterações
    /// de uma vez, garantindo a atomicidade (todas as operações são salvas ou nenhuma é).
    ///
    /// Motivo de estar na camada de Domínio:
    /// A camada de Domínio define as regras de negócio e os contratos da aplicação.
    /// Ao definir a interface aqui, a lógica de negócio nas camadas superiores
    /// (como a Application) pode interagir com o Unit of Work sem ter que
    /// conhecer a tecnologia de persistência que o implementa. Isso mantém a
    /// arquitetura desacoplada e flexível.
    /// </summary>
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}

using Senai.Peoples.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Interfaces
{
    public interface IFuncionariosRepository
    {
        List<FuncionariosDomain> ListarTodos();
        void Cadastrar(FuncionariosDomain Funcionario);
        FuncionariosDomain BuscarPorId(int id);
        void Deletar(int id);
        void AtualizarIdUrl(int id, FuncionariosDomain Funcionario);
        void AtualizarIdCorpo(FuncionariosDomain Funcionario);
        
    }
}

using System.Collections;
using System.Collections.Generic;

namespace ProjetoLoja.DAOs
{
    public interface DAO<T>
        where T : class
    {
        void CarregarLista();
        void Salvar(T objeto);
        

    }
}

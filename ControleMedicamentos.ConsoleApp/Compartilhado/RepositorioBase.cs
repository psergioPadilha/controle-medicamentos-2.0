namespace ControleMedicamentos.ConsoleApp.Compartilhado
{
    internal abstract class RepositorioBase
    {
        protected EntidadeBase[] registros = new EntidadeBase[100];

        protected int contadorId = 1;

        public void Cadastrar(EntidadeBase novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            RegistrarItem(novoRegistro);
        }

        public bool Editar(int id, EntidadeBase novaEntidade)
        {
            novaEntidade.Id = id;

            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null)
                    continue;

                else if (registros[i].Id == id)
                {
                    registros[i] = novaEntidade;

                    return true;
                }
            }

            return false;
        }

        public bool Excluir(int id)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] == null)
                    continue;

                else if (registros[i].Id == id)
                {
                    registros[i] = null;
                    return true;
                }
            }

            return false;
        }

        public EntidadeBase[] SelecionarTodos()
        {
            return registros;
        }

        public EntidadeBase SelecionarPorId(int id)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                EntidadeBase e = registros[i];

                if (e == null)
                    continue;

                else if (e.Id == id)
                    return e;
            }

            return null;
        }

        public bool Existe(int id)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                EntidadeBase e = registros[i];

                if (e == null)
                    continue;

                else if (e.Id == id)
                    return true;
            }

            return false;
        }

        protected void RegistrarItem(EntidadeBase novoRegistro)
        {
            for (int i = 0; i < registros.Length; i++)
            {
                if (registros[i] != null)
                    continue;

                else
                {
                    registros[i] = novoRegistro;
                    break;
                }
            }
        }
    }

}

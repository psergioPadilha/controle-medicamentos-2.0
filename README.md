# Controle de Medicamentos

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Funcionalidades

### 1. Controle de Medicamentos

- **Registrar Medicamento:** O registro de um medicamento irá ser formado por: nome, descrição e quantidade do estoque. Caso
o mesmo já esteja cadastrado, é atualizado a quantidade.
- **Visualizar Medicamentos:** Exibe uma lista exibindo detalhes de todos os medicamentos registrados, **também deverá exibir quais medicamentos estão em falta** (<20 unidades).
- **Editar Medicamentos:** Oferece a possibilidade de modificar informações de um medicamento existente.
- **Excluir Medicamentos:** Permite remover um medicamento do sistema, atualizando a lista de medicamentos registrados.

### 2. Controle de Paciente

- **Registrar Paciente:** O paciente deverá ser registrado com as seguintes informações: nome, telefone e cartão do SUS.
- **Visualizar Pacientes:** Exibe uma lista exibindo detalhes de todos os medicamentos registrados.
- **Editar Pacientes:** Oferece a possibilidade de modificar informações de um paciente cadastrado.
- **Excluir Pacientes:** Permite remover um registro de paciente do sistema.

### 3. Controle de Requisições de Saída

- **Registrar Requisição:** O paciente poderá registrar uma nova requisição que incluirá: data da requisição, dados do paciente, dados do medicamento e a quantidade do medicamento requisitada.
- **Visualizar Requisições:** Exibe uma lista exibindo detalhes de todas as requisições registradas.
- **Visualizar Requisições de um Paciente:** Permite visualizar uma lista de requisições realizadas por um paciente específico.

**Ao fazer uma requisição de medicamento, será necessário verificar se a quantidade do mesmo está disponível no estoque. Também será necessário subtrair esta quantidade do registro do estoque.**

### 4. Controle de Funcionário

- **Registrar Funcionário:** O funcionário deverá ser registrado com as seguintes informações: nome, telefone e CPF.
- **Visualizar Funcionários:** Exibe uma lista exibindo detalhes de todos os funcionários registrados.
- **Editar Funcionário:** Oferece a possibilidade de modificar informações de um funcionário cadastrado.
- **Excluir Funcionário:** Permite remover um registro de funcionário do sistema.

### 5. Controle de Fornecedor

- **Registrar Fornecedor:** O fornecedor deverá ser registrado com as seguintes informações: nome, telefone e CNPJ.
- **Visualizar Fornecedores:** Exibe uma lista exibindo detalhes de todos os fornecedores registrados.
- **Editar Fornecedor:** Oferece a possibilidade de modificar informações de um fornecedor cadastrado.
- **Excluir Fornecedor:** Permite remover um registro de fornecedor do sistema.

### 6. Controle de Requisições de Entrada

- **Registrar Requisição de Entrada:** O usuário poderá fazer uma requisição de entrada de medicamento que incluirá: data da requisição, dados do medicamento, dados do fornecedor, dados do funcionário e a quantidade requisitada do medicamento. *A quantidade do medicamento deve ser atualizada*.
- **Visualizar Requisições de Entrada:** Exibe uma lista exibindo detalhes de todas as requisições de Entrada registradas.
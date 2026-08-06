# OpenView

> Plataforma web modular para gerenciamento de mídias digitais com arquitetura flexível e preparada para futuras integrações.

**Status:** Em Planejamento / MVP

---

## Sobre

O OpenView é uma plataforma para organização, gerenciamento e apresentação de conteúdos digitais, com foco inicial em **filmes e séries**. A arquitetura é modular desde o início, permitindo no futuro expandir para outros tipos de mídia (animes, livros, quadrinhos, podcasts, etc.) sem reescrever a base do projeto.

Este é também um projeto de aprendizado prático, cobrindo desenvolvimento full stack, banco de dados, APIs, integrações e boas práticas de mercado.

## Funcionalidades do MVP

- Página inicial com destaques, populares, novidades e categorias
- Pesquisa de filmes e séries
- Página de conteúdo (capa, banner, sinopse, categorias, avaliação, elenco)
- Integração configurável com fontes externas (ex: TMDB)
- Painel administrativo básico (logo após o MVP)

## Tecnologias

**Frontend:** Next.js, React, JavaScript, Tailwind CSS
**Backend:** ASP.NET Core, C#
**Banco de Dados:** PostgreSQL
**Cache (opcional/futuro):** Redis
**Integrações:** TMDB (inicialmente)

## Arquitetura

```
Usuário
  ↓
Next.js (frontend)
  ↓
ASP.NET Core API (backend)
  ↓
PostgreSQL
  ↓
Integrações externas (TMDB, etc.)
```

Cada camada tem responsabilidade própria e pode evoluir isoladamente, sem exigir reescrita do restante do sistema.

## Como rodar localmente

Pré-requisitos: Docker e Docker Compose instalados.

```bash
# Clone o repositório
git clone https://github.com/<seu-usuario>/openview.git
cd openview

# Copie o arquivo de variáveis de ambiente
cp .env.example .env

# Suba os containers (frontend, backend e banco)
docker-compose up
```

- Frontend: `http://localhost:3000`
- Backend: `http://localhost:5000` (ou porta configurada em `.env`)

## Estrutura do Projeto

```
openview/
├── frontend/       # Aplicação Next.js
├── backend/        # API em ASP.NET Core
├── docs/           # Documentação do projeto
├── docker/         # Configurações Docker
├── scripts/        # Scripts auxiliares
├── .github/        # Workflows e templates
├── README.md
├── docker-compose.yml
└── .env.example
```

## Roadmap

1. Planejamento e documentação
2. Estrutura do repositório e ambiente
3. Frontend inicial
4. Backend inicial
5. Integração com TMDB
6. Modelagem do banco de dados
7. Funcionalidades principais (pesquisa, página de conteúdo, usuários)
8. Deploy
9. Evolução contínua

## Contribuindo

Contribuições são bem-vindas. O fluxo de trabalho segue:

```
Issue → Branch → Desenvolvimento → Commit → Pull Request → Code Review → Merge
```

Padrão de commits: `feat:`, `fix:`, `docs:`, `refactor:`, `style:`, `test:`, `build:`, `ci:`

## Direitos Autorais e Uso Responsável

O OpenView é desenvolvido como uma **plataforma tecnológica** de gerenciamento e integração de conteúdos digitais. O projeto **não armazena nem distribui** conteúdo protegido por direitos autorais.

É responsabilidade de cada usuário ou administrador utilizar fontes, APIs e integrações de acordo com suas respectivas licenças e permissões. O OpenView não deve ser associado diretamente a nenhuma fonte específica de conteúdo.

## Licença

© 2026 OpenView. Este projeto é distribuído sob a licença MIT — veja o arquivo `LICENSE` para mais detalhes.

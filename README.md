<b>Calculadora WinForms</b> 
</br>
Desenvolvida do Zero em WinForms e Dotnet 6.0 para aprendizado e ensino de estagiário na nosssa empresa, quem quiser contribuir fica a vontade
foi utlizado o padrão de Projeto MVP.

<b>Descrição do padrão</b>
</br>
MVP é um padrão de desenho de interface de usuário projetado para facilitar os testes unitários automatizados e melhorar a separação de interesses em lógica de apresentação:

Model é uma interface que define o modelo de dados que será exibido ou alterado na interface do usuário.
View é uma interface que exibe de fato os dados (o modelo) e guia os comandos do usuário (eventos) à camada Presenter para atuar sobre os dados.
A interface Presenter atua sobre a Model e a View. Ela recupera os dados dos repositórios (modelo), e os formata para exibi-los na View.
Normalmente, a implementação da View instancia o objeto Presenter concretamente, provendo uma referência a si mesmo. O código em C# a seguir demonstra um construtor View simples, onde ConcreteDomainPresenter implementa a interface IDomainPresenter:
</br>


        Public Class DomainView: IDomainView
        {
            private IDomainPresenter domainPresenter;
            public DomainView()   // Construtor
            {
                this.domainPresenter = new ConcreteDomainPresenter(this);
            }
        }

</br>
fonte: <b> <a href="https://pt.wikipedia.org/wiki/Model-view-presenter#:~:text=6%20Referências-,Descrição%20do%20padrão,alterado%20na%20interface%20do%20usuário.">Wikipédia-MVP</a></b>
</br>
<b>Views</b>
</br>
<figure>
  <img src="https://user-images.githubusercontent.com/31899397/160330277-931d1212-7f25-4310-b618-c9c7368305a9.png" alt="Tela da Calculadora">
  <figcaption>Tela da Calculadora</figcaption>
</figure>


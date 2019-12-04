namespace RoleTopMVC_.ViewsModels {
    public class RespostaViewModel : BaseViewModel {
        public string Mensagem { get; set; }

        public RespostaViewModel () { }
        public RespostaViewModel (string mensagem) {
            NomeView = "Nao Informado";
            this.Mensagem = mensagem;
        }
    }
}
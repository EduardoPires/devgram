﻿namespace Devgram.Infra.Entities
{
    public class Publicacao : EntityBase
    {
        protected Publicacao()
        {

        }

        public Publicacao(string? descricao, Guid usuarioId)
        {
            Descricao = descricao;
            UsuarioId = usuarioId;
        }

        public string? Descricao { get; private set; }
        public virtual ICollection<PublicacaoAnexo>? Anexos { get; private set; }
        public virtual ICollection<PublicacaoComentario>? Comentarios { get; private set; }

        public Guid UsuarioId { get; private set; }
        public virtual Usuario Usuario { get; private set; }

        public void Atualizar(Publicacao publicacao)
        {
            Descricao = publicacao.Descricao;
            Anexos = publicacao.Anexos;
            Comentarios = publicacao.Comentarios;
            DataAtualizacao = DateTime.Now;
        }

        public void NovaPublicacao()
        {
            DataCriacao = DateTime.Now;
        }
    }
}

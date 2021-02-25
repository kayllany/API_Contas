using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;


namespace contasAPagar.Validation
{
    public class ContaValidator : AbstractValidator<Model.ContaModel>
    {
        public ContaValidator()
        {
            RuleFor(vencimento => vencimento.DataVencimento).NotNull().WithMessage("A data de vencimento deve ser preenchida");
            RuleFor(credor => credor.NomeCredor).NotEmpty().WithMessage("O nome do credor deve ser preenchido");
            RuleFor(credor => credor.NomeCredor).MaximumLength(100).WithMessage("O nome do credor dever ter no máximo 100 caracteres");
            RuleFor(credor => credor.NomeCredor).MinimumLength(3).WithMessage("O nome do credor deve ter no mínimo 3 caracteres");
            RuleFor(valor => valor.Valor).GreaterThan(0).WithMessage("O valor a pagar deve ser maior do que 0");
        }
    }
}

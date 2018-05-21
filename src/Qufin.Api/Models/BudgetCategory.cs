using System;
using System.Diagnostics.CodeAnalysis;

namespace Qufin.Api.Models
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public sealed class BudgetCategory
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public BudgetRootCategory Parent { get; set; }
    }
}

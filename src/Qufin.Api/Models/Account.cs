using System;
using System.Diagnostics.CodeAnalysis;

namespace Qufin.Api.Models
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public sealed class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsOffBudget { get; set; }
    }
}

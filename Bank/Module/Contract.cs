//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank.Module
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int IDContract { get; set; }
        public string NumberAccount { get; set; }
        public int UserID { get; set; }
        public double Amount { get; set; }
        public int Period { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public double Percet { get; set; }
    
        public virtual BankAccount BankAccount { get; set; }
        public virtual User User { get; set; }
    }
}

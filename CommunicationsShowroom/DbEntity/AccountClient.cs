//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationsShowroom.DbEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountClient
    {
        public int Id { get; set; }
        public string LoginClient { get; set; }
        public string PasswordClient { get; set; }
        public Nullable<int> Id_Client { get; set; }
        public Nullable<int> Id_Status { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual StatusAccount StatusAccount { get; set; }
    }
}

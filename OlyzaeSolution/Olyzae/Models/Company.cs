//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NihonUnisys.Olyzae.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public Company()
        {
            this.AccountUsers = new HashSet<AccountUser>();
            this.Projects = new HashSet<Project>();
        }
    
        public int ID { get; set; }
        public string CompanyName { get; set; }
    
        public virtual ICollection<AccountUser> AccountUsers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}

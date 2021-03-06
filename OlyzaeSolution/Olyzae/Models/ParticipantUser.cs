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
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public partial class ParticipantUser : User
    {
        public ParticipantUser()
        {
            this.Projects = new HashSet<ParticipantUserProject>();
            this.Groups = new HashSet<ParticipantUserGroup>();
            this.Threads = new HashSet<ParticipantUserThread>();
            this.PersonalThreads = new HashSet<PersonalThread>();
        }

        [Required]
        [Display(Name = "ハンドルネーム")]
        public string OnlineName { get; set; }

        [Required]
        [Display(Name = "名前（フリガナ）")]
        public string Kana { get; set; }

        [Display(Name = "性別")]
        public int? Gender { get; set; }

        [Display(Name = "生年月日")]
        [DisplayFormat(DataFormatString = "{0:yyyy年M月d日}")]
        public System.DateTime BirthDay { get; set; }

        [Required]
        [Display(Name = "大学名または最終学歴")]
        public string AcademicRecord { get; set; }

        [Required]
        [Display(Name = "所属先")]
        public string Departments { get; set; }

        [Required]
        [Display(Name = "学年")]
        public int AcademicYear { get; set; }

        [Required]
        [Display(Name = "メールアドレス")]
        public string EMailAddress { get; set; }

        [Required]
        [Display(Name = "電話番号")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "郵便番号")]
        public string Zip { get; set; }

        [Required]
        [Display(Name = "都道府県")]
        public int State { get; set; }

        [Required]
        [Display(Name = "市町村区")]
        public string City { get; set; }

        [Required]
        [Display(Name = "町名・番地")]
        public string StreetAddress1 { get; set; }

        [Display(Name = "ビル・マンション等")]
        public string StreetAddress2 { get; set; }

        [Display(Name = "郵便番号（帰省先）")]
        public string ReturningHomeZip { get; set; }

        [Display(Name = "都道府県（帰省先）")]
        public int? ReturningHomeState { get; set; }

        [Display(Name = "市町村区（帰省先）")]
        public string ReturningHomeCity { get; set; }

        [Display(Name = "町名・番地（帰省先）")]
        public string ReturningHomeStreetAddress1 { get; set; }

        [Display(Name = "ビル・マンション等（帰省先）")]
        public string ReturningHomeStreetAddress2 { get; set; }

        [Required]
        [Display(Name = "専門性")]
        public int Academic { get; set; }

        [Required]
        [Display(Name = "幸福")]
        public string Happpiness { get; set; }

        [Required]
        [Display(Name = "キャリア・アンカー")]
        public int CareerAnchors { get; set; }

        [Required]
        [Display(Name = "メンター")]
        public string Mentor { get; set; }

        [Required]
        [Display(Name = "このサイトをどこで知りましたか？")]
        public string Answer { get; set; }

        public Nullable<System.Guid> ProfileImageDocumentID { get; set; }

        public virtual ICollection<ParticipantUserProject> Projects { get; set; }
        public virtual ICollection<ParticipantUserGroup> Groups { get; set; }

        public virtual ICollection<ParticipantUserThread> Threads { get; set; }

        public virtual ICollection<PersonalThread> PersonalThreads { get; set; }

        /// <summary>
        /// 指定したグループに所属しているかどうかを返します。
        /// </summary>
        /// <param name="groupId">グループID。</param>
        /// <returns>指定したグループに所属している場合はtrue。</returns>
        /// <remarks>
        /// このメソッドを呼び出す前に、関連オブジェクト(ParticipantUserGroup)をDBから取得しておく必要があります。
        /// </remarks>
        public bool BelongsToGroup(int groupId)
        {
            return this.Groups.Any(pug => pug.Group.ID == groupId);
        }

        public override string Role
        {
            get { return "ParticipantUser"; }
        }
    }
}

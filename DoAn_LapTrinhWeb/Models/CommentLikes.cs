using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAn_LapTrinhWeb.Models
{
    [Table("CommentLikes")]
    public class CommentLikes
    {
        //comment like id
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int comment_like_id { get; set; }
        //comment id
        public int comment_id { get; set; }
        //account id
        public int account_id { get; set; }
        //comment like
        [StringLength(1)]
        public string comment_like { get; set; }
        //create at
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime create_at { get; set; }
        //status
        public virtual NewsComments NewsComments { get; set; }
        public virtual Account Accounts { get; set; }
    }
}
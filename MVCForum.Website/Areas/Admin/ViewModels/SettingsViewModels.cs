using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using MVCForum.Domain.Constants;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Website.Areas.Admin.ViewModels
{

    public class CustomCodeViewModels
    {
        [AllowHtml]
        [DisplayName("Custom Header Code")]
        public string CustomHeaderCode { get; set; }

        [AllowHtml]
        [DisplayName("Custom Footer Code")]
        public string CustomFooterCode { get; set; }
    }

    public class EditSettingsViewModel
    {
        [HiddenInput]
        public Guid Id { get; set; }

        [DisplayName("论坛名")]
        [Required]
        [StringLength(200)]
        public string ForumName { get; set; }

        [DisplayName("论坛网址")]
        [Required]
        [StringLength(200)]
        public string ForumUrl { get; set; }

        [DisplayName("关闭论坛")]
        [Description("关闭论坛并维护")]
        public bool IsClosed { get; set; }

        [DisplayName("Allow Rss Feeds")]
        [Description("Show the RSS feed icons for the Topics and Categories")]        
        public bool EnableRSSFeeds { get; set; }

        [DisplayName("显示在帖子上的详细信息编辑")]
        public bool DisplayEditedBy { get; set; }

        //[DisplayName("Allow File Attachments On Posts")]
        //public bool EnablePostFileAttachments { get; set; }

        [DisplayName("允许帖子被标记为解决")]
        public bool EnableMarkAsSolution { get; set; }

        [DisplayName("所有未被标记为解决方案的主题电子邮件提醒，等待的时间范围， - 设置为0以禁用")]
        public int MarkAsSolutionReminderTimeFrame { get; set; }

        [DisplayName("Enable Spam Reporting")]
        public bool EnableSpamReporting { get; set; }

        [DisplayName("启用表情")]
        public bool EnableEmoticons { get; set; }

        [DisplayName("Allow Members To Report Other Members")]
        public bool EnableMemberReporting { get; set; }

        [DisplayName("允许电子邮件订阅")]
        public bool EnableEmailSubscriptions { get; set; }

        [DisplayName("New Members Must Confirm Their Account Via A Link Sent In An Email - Will not work with Twitter accounts!")]
        public bool NewMemberEmailConfirmation { get; set; }

        [DisplayName("手动授权新会员")]
        public bool ManuallyAuthoriseNewMembers { get; set; }

        [DisplayName("新用户注册通知管理员")]
        public bool EmailAdminOnNewMemberSignUp { get; set; }

        [DisplayName("每页话题数量")]
        public int TopicsPerPage { get; set; }

        [DisplayName("每页帖子数量")]
        public int PostsPerPage { get; set; }

        [DisplayName("每页活动数量")]
        public int ActivitiesPerPage { get; set; }

        [DisplayName("允许私信")]
        public bool EnablePrivateMessages { get; set; }

        [DisplayName("私信最大数量")]
        public int MaxPrivateMessagesPerMember { get; set; }

        [DisplayName("私信保护 - 每多少秒允许发送私信")]
        public int PrivateMessageFloodControl { get; set; }

        [DisplayName("允许用户使用签名")]
        public bool EnableSignatures { get; set; }

        [DisplayName("Enable Members To Create Polls")]
        public bool EnablePolls { get; set; }

        [DisplayName("允许积分系统")]
        public bool EnablePoints { get; set; }

        [DisplayName("投票所需积分")]
        public int PointsAllowedToVoteAmount { get; set; }

        [DisplayName("修改用户信息所需积分")]
        public int PointsAllowedForExtendedProfile { get; set; }

        [DisplayName("发帖获得积分")]
        public int PointsAddedPerPost { get; set; }

        [DisplayName("积极投票获得积分")]
        public int PointsAddedPostiveVote { get; set; }

        [DisplayName("消极投票扣除积分")]
        public int PointsDeductedNagativeVote { get; set; }

        [DisplayName("解决问题的积分")]
        public int PointsAddedForSolution { get; set; }

        [EmailAddress]
        [DisplayName("管理员邮箱")]
        public string AdminEmailAddress { get; set; }

        [DisplayName("通知回复的邮箱")]
        [AllowHtml] // We have to put this to allow this type of reply address MVCForum <noreply@mvcforum.com>
        public string NotificationReplyEmail { get; set; }

        [DisplayName("SMTP 服务器")]
        public string SMTP { get; set; }

        [DisplayName("SMTP 服务器用户名")]
        public string SMTPUsername { get; set; }

        [DisplayName("SMTP 服务器密码")]
        public string SMTPPassword { get; set; }

        [DisplayName("SMTP端口")]
        public int? SMTPPort { get; set; }

        [DisplayName("SMTP SSL - 通过SSL发送邮件")]
        public bool SMTPEnableSSL { get; set; }

        [DisplayName("Current Theme")]
        [Required]
        public string Theme { get; set; }

        public List<string> Themes { get; set; }

        [DisplayName("New Member Starting Role")]
        public Guid? NewMemberStartingRole { get; set; }

        public List<MembershipRole> Roles { get; set; }

        [DisplayName("Default Language")]
        public Guid? DefaultLanguage { get; set; }

        public List<Language> Languages { get; set; }

        [DisplayName("Enable Akismet Spam Control")]
        public bool EnableAkisment { get; set; }

        [DisplayName("Enter Your Akismet Key Here")]
        public string AkismentKey { get; set; }

        [DisplayName("Enter a Spam registration prevention question")]
        public string SpamQuestion { get; set; }

        [DisplayName("Enter the answer to your Spam question")]
        public string SpamAnswer { get; set; }

        [DisplayName("Enable social logins (Facebook etc...)")]
        public bool EnableSocialLogins { get; set; }

        [DisplayName("Disable Standard Registration")]
        public bool DisableStandardRegistration { get; set; }

        [DisplayName("Suspend the registration (Don't allow any new members to register)")]
        public bool SuspendRegistration { get; set; }

        [DisplayName("Page Title")]
        [MaxLength(80)]
        public string PageTitle { get; set; }

        [DisplayName("Meta Desc")]
        [MaxLength(200)]
        public string MetaDesc { get; set; }

        [DisplayName("禁用不喜欢按钮 - 用户只能喜欢帖子")]
        public bool DisableDislikeButton { get; set; }

        [DisplayName("New Members must agree to the Terms & Conditions below before using the forum")]        
        public bool AgreeToTermsAndConditions { get; set; }

        [DisplayName("Terms & Conditions of the forum")]
        [UIHint(AppConstants.EditorType), AllowHtml]
        [StringLength(6000)]
        public string TermsAndConditions { get; set; }
    }
}
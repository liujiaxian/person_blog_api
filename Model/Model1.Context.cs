﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bds252114683_dbEntities : DbContext
    {
        public bds252114683_dbEntities()
            : base("name=bds252114683_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<person_aboutus> person_aboutus { get; set; }
        public DbSet<person_aboutus_content> person_aboutus_content { get; set; }
        public DbSet<person_accesstoken> person_accesstoken { get; set; }
        public DbSet<person_account_notice> person_account_notice { get; set; }
        public DbSet<person_achievements> person_achievements { get; set; }
        public DbSet<person_action> person_action { get; set; }
        public DbSet<person_active> person_active { get; set; }
        public DbSet<person_banner> person_banner { get; set; }
        public DbSet<person_blog> person_blog { get; set; }
        public DbSet<person_blog_type> person_blog_type { get; set; }
        public DbSet<person_case> person_case { get; set; }
        public DbSet<person_case_type> person_case_type { get; set; }
        public DbSet<person_client> person_client { get; set; }
        public DbSet<person_collection> person_collection { get; set; }
        public DbSet<person_contact> person_contact { get; set; }
        public DbSet<person_contact_info> person_contact_info { get; set; }
        public DbSet<person_download_reader> person_download_reader { get; set; }
        public DbSet<person_email> person_email { get; set; }
        public DbSet<person_faq> person_faq { get; set; }
        public DbSet<person_faq_content> person_faq_content { get; set; }
        public DbSet<person_hot> person_hot { get; set; }
        public DbSet<person_icon> person_icon { get; set; }
        public DbSet<person_links> person_links { get; set; }
        public DbSet<person_log> person_log { get; set; }
        public DbSet<person_music> person_music { get; set; }
        public DbSet<person_navigation> person_navigation { get; set; }
        public DbSet<person_navigation_type> person_navigation_type { get; set; }
        public DbSet<person_partner> person_partner { get; set; }
        public DbSet<person_picture> person_picture { get; set; }
        public DbSet<person_picture_type> person_picture_type { get; set; }
        public DbSet<person_plan> person_plan { get; set; }
        public DbSet<person_plan_content> person_plan_content { get; set; }
        public DbSet<person_price> person_price { get; set; }
        public DbSet<person_price_content> person_price_content { get; set; }
        public DbSet<person_product_description> person_product_description { get; set; }
        public DbSet<person_qq_login> person_qq_login { get; set; }
        public DbSet<person_reader> person_reader { get; set; }
        public DbSet<person_reader_type> person_reader_type { get; set; }
        public DbSet<person_resume> person_resume { get; set; }
        public DbSet<person_role> person_role { get; set; }
        public DbSet<person_service> person_service { get; set; }
        public DbSet<person_site_config> person_site_config { get; set; }
        public DbSet<person_skill> person_skill { get; set; }
        public DbSet<person_social> person_social { get; set; }
        public DbSet<person_user> person_user { get; set; }
        public DbSet<person_visitor> person_visitor { get; set; }
        public DbSet<person_vyw_aboutus_picture> person_vyw_aboutus_picture { get; set; }
        public DbSet<person_vyw_account_notice_icon> person_vyw_account_notice_icon { get; set; }
        public DbSet<person_vyw_achievements_icon> person_vyw_achievements_icon { get; set; }
        public DbSet<person_vyw_active_user> person_vyw_active_user { get; set; }
        public DbSet<person_vyw_banner_user> person_vyw_banner_user { get; set; }
        public DbSet<person_vyw_blog_type> person_vyw_blog_type { get; set; }
        public DbSet<person_vyw_blog_type_picture> person_vyw_blog_type_picture { get; set; }
        public DbSet<person_vyw_case_type_user_picture> person_vyw_case_type_user_picture { get; set; }
        public DbSet<person_vyw_collection_blog_type> person_vyw_collection_blog_type { get; set; }
        public DbSet<person_vyw_collection_music> person_vyw_collection_music { get; set; }
        public DbSet<person_vyw_collection_plan> person_vyw_collection_plan { get; set; }
        public DbSet<person_vyw_collection_reader_type> person_vyw_collection_reader_type { get; set; }
        public DbSet<person_vyw_music_user> person_vyw_music_user { get; set; }
        public DbSet<person_vyw_navigation_type> person_vyw_navigation_type { get; set; }
        public DbSet<person_vyw_partner_picture> person_vyw_partner_picture { get; set; }
        public DbSet<person_vyw_plan_content> person_vyw_plan_content { get; set; }
        public DbSet<person_vyw_plan_user> person_vyw_plan_user { get; set; }
        public DbSet<person_vyw_price_icon> person_vyw_price_icon { get; set; }
        public DbSet<person_vyw_product_description_icon> person_vyw_product_description_icon { get; set; }
        public DbSet<person_vyw_reader_user> person_vyw_reader_user { get; set; }
        public DbSet<person_vyw_resume_picture> person_vyw_resume_picture { get; set; }
        public DbSet<person_vyw_resume_user> person_vyw_resume_user { get; set; }
        public DbSet<person_vyw_service_icon> person_vyw_service_icon { get; set; }
        public DbSet<person_vyw_social_icon> person_vyw_social_icon { get; set; }
        public DbSet<person_vyw_user_picture> person_vyw_user_picture { get; set; }
        public DbSet<person_vyw_visitor_user> person_vyw_visitor_user { get; set; }
    }
}
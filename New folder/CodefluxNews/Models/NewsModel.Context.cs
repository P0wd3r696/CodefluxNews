﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodefluxNews.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NewsDBEntities : DbContext
    {
        public NewsDBEntities()
            : base("name=NewsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<NewsArticle> NewsArticles { get; set; }
        public virtual DbSet<NewsCategory> NewsCategories { get; set; }
        public virtual DbSet<NewsFeed> NewsFeeds { get; set; }
        public virtual DbSet<NewsProvider> NewsProviders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ParentCategory> ParentCategories { get; set; }
    
        public virtual int deleteCountry(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteCountry", idParameter);
        }
    
        public virtual int deleteNewsArticle(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNewsArticle", idParameter);
        }
    
        public virtual int deleteNewsCategory(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNewsCategory", idParameter);
        }
    
        public virtual int deleteNewsFeed(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNewsFeed", idParameter);
        }
    
        public virtual int deleteNewsProvider(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteNewsProvider", idParameter);
        }
    
        public virtual int insertAdmin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertAdmin", usernameParameter, passwordParameter);
        }
    
        public virtual int insertCountry(string name, string logo)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("logo", logo) :
                new ObjectParameter("logo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertCountry", nameParameter, logoParameter);
        }
    
        public virtual int insertNewsArticle(string title, string summary, Nullable<int> providerId, string picture, string url, Nullable<int> categoryid)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var summaryParameter = summary != null ?
                new ObjectParameter("summary", summary) :
                new ObjectParameter("summary", typeof(string));
    
            var providerIdParameter = providerId.HasValue ?
                new ObjectParameter("providerId", providerId) :
                new ObjectParameter("providerId", typeof(int));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("picture", picture) :
                new ObjectParameter("picture", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var categoryidParameter = categoryid.HasValue ?
                new ObjectParameter("categoryid", categoryid) :
                new ObjectParameter("categoryid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNewsArticle", titleParameter, summaryParameter, providerIdParameter, pictureParameter, urlParameter, categoryidParameter);
        }
    
        public virtual int insertNewsCategory(string name, Nullable<int> parentId)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var parentIdParameter = parentId.HasValue ?
                new ObjectParameter("parentId", parentId) :
                new ObjectParameter("parentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNewsCategory", nameParameter, parentIdParameter);
        }
    
        public virtual int insertNewsFeed(Nullable<int> providerId, string rssUrl, Nullable<int> categoryId, string image)
        {
            var providerIdParameter = providerId.HasValue ?
                new ObjectParameter("providerId", providerId) :
                new ObjectParameter("providerId", typeof(int));
    
            var rssUrlParameter = rssUrl != null ?
                new ObjectParameter("rssUrl", rssUrl) :
                new ObjectParameter("rssUrl", typeof(string));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNewsFeed", providerIdParameter, rssUrlParameter, categoryIdParameter, imageParameter);
        }
    
        public virtual int insertNewsProvider(string name, string url, Nullable<int> countryId)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var countryIdParameter = countryId.HasValue ?
                new ObjectParameter("countryId", countryId) :
                new ObjectParameter("countryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertNewsProvider", nameParameter, urlParameter, countryIdParameter);
        }
    
        public virtual ObjectResult<selectActiveNewsFeed_Result> selectActiveNewsFeed()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectActiveNewsFeed_Result>("selectActiveNewsFeed");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int updateCountry(Nullable<int> id, string name, string logo)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var logoParameter = logo != null ?
                new ObjectParameter("logo", logo) :
                new ObjectParameter("logo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateCountry", idParameter, nameParameter, logoParameter);
        }
    
        public virtual int updateNewsArticle(Nullable<int> id, string title, string summary, Nullable<int> providerId, string picture, string url, Nullable<int> categoryid)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var summaryParameter = summary != null ?
                new ObjectParameter("summary", summary) :
                new ObjectParameter("summary", typeof(string));
    
            var providerIdParameter = providerId.HasValue ?
                new ObjectParameter("providerId", providerId) :
                new ObjectParameter("providerId", typeof(int));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("picture", picture) :
                new ObjectParameter("picture", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var categoryidParameter = categoryid.HasValue ?
                new ObjectParameter("categoryid", categoryid) :
                new ObjectParameter("categoryid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateNewsArticle", idParameter, titleParameter, summaryParameter, providerIdParameter, pictureParameter, urlParameter, categoryidParameter);
        }
    
        public virtual int updateNewsCategory(Nullable<int> id, string name, Nullable<int> parentId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var parentIdParameter = parentId.HasValue ?
                new ObjectParameter("parentId", parentId) :
                new ObjectParameter("parentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateNewsCategory", idParameter, nameParameter, parentIdParameter);
        }
    
        public virtual int updateNewsFeed(Nullable<int> id, Nullable<int> providerId, string rssUrl, Nullable<int> categoryId, string image)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var providerIdParameter = providerId.HasValue ?
                new ObjectParameter("providerId", providerId) :
                new ObjectParameter("providerId", typeof(int));
    
            var rssUrlParameter = rssUrl != null ?
                new ObjectParameter("rssUrl", rssUrl) :
                new ObjectParameter("rssUrl", typeof(string));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("categoryId", categoryId) :
                new ObjectParameter("categoryId", typeof(int));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateNewsFeed", idParameter, providerIdParameter, rssUrlParameter, categoryIdParameter, imageParameter);
        }
    
        public virtual int updateNewsProvider(Nullable<int> id, string name, string url, Nullable<int> countryId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("url", url) :
                new ObjectParameter("url", typeof(string));
    
            var countryIdParameter = countryId.HasValue ?
                new ObjectParameter("countryId", countryId) :
                new ObjectParameter("countryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updateNewsProvider", idParameter, nameParameter, urlParameter, countryIdParameter);
        }
    
        public virtual int insertParentCategory(string parentname)
        {
            var parentnameParameter = parentname != null ?
                new ObjectParameter("parentname", parentname) :
                new ObjectParameter("parentname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertParentCategory", parentnameParameter);
        }
    
        public virtual int deleteParentCategory(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteParentCategory", idParameter);
        }
    }
}

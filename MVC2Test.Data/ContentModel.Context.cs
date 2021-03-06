//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace MVC2Test.Domain
{
    public partial class ContentModelContainer : ObjectContext, IContentModelContainer
    {
        public const string ConnectionString = "name=ContentModelContainer";
        public const string ContainerName = "ContentModelContainer";
    
        #region Constructors
    
        public ContentModelContainer()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public ContentModelContainer(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public ContentModelContainer(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Content> Content
        {
            get { return _content   ?? (_content = CreateObjectSet<Content>("Content")); }
        }
        private ObjectSet<Content> _content;
    
        public ObjectSet<Author> Authors
        {
            get { return _authors  ?? (_authors = CreateObjectSet<Author>("Authors")); }
        }
        private ObjectSet<Author> _authors;

        #endregion
    }
}

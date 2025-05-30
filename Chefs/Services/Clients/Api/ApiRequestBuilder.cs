// <auto-generated/>
using Chefs.Services.Clients.Api.Cookbook;
using Chefs.Services.Clients.Api.Notification;
using Chefs.Services.Clients.Api.Recipe;
using Chefs.Services.Clients.Api.User;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Chefs.Services.Clients.Api
{
    /// <summary>
    /// Builds and executes requests for operations under \api
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ApiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The cookbook property</summary>
        public global::Chefs.Services.Clients.Api.Cookbook.CookbookRequestBuilder Cookbook
        {
            get => new global::Chefs.Services.Clients.Api.Cookbook.CookbookRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notification property</summary>
        public global::Chefs.Services.Clients.Api.Notification.NotificationRequestBuilder Notification
        {
            get => new global::Chefs.Services.Clients.Api.Notification.NotificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The recipe property</summary>
        public global::Chefs.Services.Clients.Api.Recipe.RecipeRequestBuilder Recipe
        {
            get => new global::Chefs.Services.Clients.Api.Recipe.RecipeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The user property</summary>
        public global::Chefs.Services.Clients.Api.User.UserRequestBuilder User
        {
            get => new global::Chefs.Services.Clients.Api.User.UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Chefs.Services.Clients.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Chefs.Services.Clients.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", rawUrl)
        {
        }
    }
}

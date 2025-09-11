/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateEmbedUrlForAnonymousUser operation.
    /// Generates an embed URL that you can use to embed an Amazon QuickSight dashboard or
    /// visual in your website, without having to register any reader users. Before you use
    /// this action, make sure that you have configured the dashboards and permissions.
    /// 
    ///  
    /// <para>
    /// The following rules apply to the generated URL:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// It contains a temporary bearer token. It is valid for 5 minutes after it is generated.
    /// Once redeemed within this period, it cannot be re-used again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The URL validity period should not be confused with the actual session lifetime that
    /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForAnonymousUser.html#QS-GenerateEmbedUrlForAnonymousUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
    /// </c> parameter. The resulting user session is valid for 15 minutes (minimum) to 10
    /// hours (maximum). The default session duration is 10 hours.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You are charged only when the URL is used or there is interaction with Amazon QuickSight.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics.html">Embedded
    /// Analytics</a> in the <i>Amazon QuickSight User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the high-level steps for embedding and for an interactive
    /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
    /// QuickSight Developer Portal</a>.
    /// </para>
    /// </summary>
    public partial class GenerateEmbedUrlForAnonymousUserRequest : AmazonQuickSightRequest
    {
        private List<string> _allowedDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _authorizedResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsAccountId;
        private AnonymousUserEmbeddingExperienceConfiguration _experienceConfiguration;
        private string _awsNamespace;
        private long? _sessionLifetimeInMinutes;
        private List<SessionTag> _sessionTags = AWSConfigs.InitializeCollections ? new List<SessionTag>() : null;

        /// <summary>
        /// Gets and sets the property AllowedDomains. 
        /// <para>
        /// The domains that you want to add to the allow list for access to the generated URL
        /// that is then embedded. This optional parameter overrides the static domains that are
        /// configured in the Manage QuickSight menu in the QuickSight console. Instead, it allows
        /// only the domains that you include in this parameter. You can list up to three domains
        /// or subdomains in each API call.
        /// </para>
        ///  
        /// <para>
        /// To include all subdomains under a specific domain to the allow list, use <c>*</c>.
        /// For example, <c>https://*.sapp.amazon.com</c> includes all subdomains under <c>https://sapp.amazon.com</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedDomains
        {
            get { return this._allowedDomains; }
            set { this._allowedDomains = value; }
        }

        // Check to see if AllowedDomains property is set
        internal bool IsSetAllowedDomains()
        {
            return this._allowedDomains != null && (this._allowedDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizedResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the QuickSight resources that the user is authorized
        /// to access during the lifetime of the session.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>Dashboard</c> embedding experience, pass the list of dashboard ARNs
        /// in the account that you want the user to be able to view.
        /// </para>
        ///  
        /// <para>
        /// If you want to make changes to the theme of your embedded content, pass a list of
        /// theme ARNs that the anonymous users need access to.
        /// </para>
        ///  
        /// <para>
        /// Currently, you can pass up to 25 theme ARNs in each API call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AuthorizedResourceArns
        {
            get { return this._authorizedResourceArns; }
            set { this._authorizedResourceArns = value; }
        }

        // Check to see if AuthorizedResourceArns property is set
        internal bool IsSetAuthorizedResourceArns()
        {
            return this._authorizedResourceArns != null && (this._authorizedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that contains the dashboard that you're
        /// embedding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ExperienceConfiguration. 
        /// <para>
        /// The configuration of the experience that you are embedding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnonymousUserEmbeddingExperienceConfiguration ExperienceConfiguration
        {
            get { return this._experienceConfiguration; }
            set { this._experienceConfiguration = value; }
        }

        // Check to see if ExperienceConfiguration property is set
        internal bool IsSetExperienceConfiguration()
        {
            return this._experienceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The QuickSight namespace that the anonymous user virtually belongs to. If you are
        /// not using an Amazon QuickSight custom namespace, set this to <c>default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SessionLifetimeInMinutes. 
        /// <para>
        /// How many minutes the session is valid. The session lifetime must be in [15-600] minutes
        /// range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=600)]
        public long? SessionLifetimeInMinutes
        {
            get { return this._sessionLifetimeInMinutes; }
            set { this._sessionLifetimeInMinutes = value; }
        }

        // Check to see if SessionLifetimeInMinutes property is set
        internal bool IsSetSessionLifetimeInMinutes()
        {
            return this._sessionLifetimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionTags. 
        /// <para>
        /// The session tags used for row-level security. Before you use this parameter, make
        /// sure that you have configured the relevant datasets using the <c>DataSet$RowLevelPermissionTagConfiguration</c>
        /// parameter so that session tags can be used to provide row-level security.
        /// </para>
        ///  
        /// <para>
        /// These are not the tags used for the Amazon Web Services resource tagging feature.
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-rls-tags.html">Using
        /// Row-Level Security (RLS) with Tags</a>in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<SessionTag> SessionTags
        {
            get { return this._sessionTags; }
            set { this._sessionTags = value; }
        }

        // Check to see if SessionTags property is set
        internal bool IsSetSessionTags()
        {
            return this._sessionTags != null && (this._sessionTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
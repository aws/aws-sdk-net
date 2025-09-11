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
    /// Container for the parameters to the GenerateEmbedUrlForRegisteredUser operation.
    /// Generates an embed URL that you can use to embed an Amazon QuickSight experience in
    /// your website. This action can be used for any type of user registered in an Amazon
    /// QuickSight account. Before you use this action, make sure that you have configured
    /// the relevant Amazon QuickSight resource and permissions.
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
    /// can be customized using the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_GenerateEmbedUrlForRegisteredUser.html#QS-GenerateEmbedUrlForRegisteredUser-request-SessionLifetimeInMinutes">SessionLifetimeInMinutes</a>
    /// </c> parameter.
    /// </para>
    ///  
    /// <para>
    /// The resulting user session is valid for 15 minutes (minimum) to 10 hours (maximum).
    /// The default session duration is 10 hours.
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
    public partial class GenerateEmbedUrlForRegisteredUserRequest : AmazonQuickSightRequest
    {
        private List<string> _allowedDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsAccountId;
        private RegisteredUserEmbeddingExperienceConfiguration _experienceConfiguration;
        private long? _sessionLifetimeInMinutes;
        private string _userArn;

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
        /// The experience that you want to embed. For registered users, you can embed QuickSight
        /// dashboards, QuickSight visuals, the QuickSight Q search bar, the QuickSight Generative
        /// Q&amp;A experience, or the entire QuickSight console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegisteredUserEmbeddingExperienceConfiguration ExperienceConfiguration
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
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name for the registered user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}
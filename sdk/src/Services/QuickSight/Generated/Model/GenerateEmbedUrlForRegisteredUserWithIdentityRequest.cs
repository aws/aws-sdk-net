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
    /// Container for the parameters to the GenerateEmbedUrlForRegisteredUserWithIdentity operation.
    /// Generates an embed URL that you can use to embed an QuickSight experience in your
    /// website. This action can be used for any type of user that is registered in an QuickSight
    /// account that uses IAM Identity Center for authentication. This API requires <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html#types-identity-enhanced-iam-role-sessions">identity-enhanced
    /// IAM Role sessions</a> for the authenticated user that the API call is being made for.
    /// 
    ///  
    /// <para>
    /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
    /// identity propagation</a> to ensure that an end user is authenticated and receives
    /// the embed URL that is specific to that user. The IAM Identity Center application that
    /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
    /// Identity Propagation enabled for QuickSight</a> with the scope value set to <c>quicksight:read</c>.
    /// Before you use this action, make sure that you have configured the relevant QuickSight
    /// resource and permissions.
    /// </para>
    /// </summary>
    public partial class GenerateEmbedUrlForRegisteredUserWithIdentityRequest : AmazonQuickSightRequest
    {
        private List<string> _allowedDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _awsAccountId;
        private RegisteredUserEmbeddingExperienceConfiguration _experienceConfiguration;
        private long? _sessionLifetimeInMinutes;

        /// <summary>
        /// Gets and sets the property AllowedDomains. 
        /// <para>
        /// A list of domains to be allowed to generate the embed URL.
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
        /// The ID of the Amazon Web Services registered user.
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
        /// The validity of the session in minutes.
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

    }
}
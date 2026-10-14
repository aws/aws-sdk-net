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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The settings for Amazon Pinpoint analytics configuration. With an analytics configuration,
    /// your application can collect user-activity metrics for user notifications with a Amazon
    /// Pinpoint campaign.
    /// 
    ///  
    /// <para>
    /// Amazon Pinpoint isn't available in all Amazon Web Services Regions. For a list of
    /// available Regions, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-pinpoint-integration.html#cognito-user-pools-find-region-mappings">Amazon
    /// Cognito and Amazon Pinpoint Region availability</a>.
    /// </para>
    /// </summary>
    public partial class AnalyticsConfigurationType
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Pinpoint project that you want to connect
        /// to your user pool app client. Amazon Cognito publishes events to the Amazon Pinpoint
        /// project that <c>ApplicationArn</c> declares. You can also configure your application
        /// to pass an endpoint ID in the <c>AnalyticsMetadata</c> parameter of sign-in operations.
        /// The endpoint ID is information about the destination for push notifications
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// Your Amazon Pinpoint project ID.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-user_externalid.html">external
        /// ID</a> of the role that Amazon Cognito assumes to send analytics data to Amazon Pinpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of an Identity and Access Management role that has the permissions required
        /// for Amazon Cognito to publish events to Amazon Pinpoint analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UserDataShared. 
        /// <para>
        /// If <c>UserDataShared</c> is <c>true</c>, Amazon Cognito includes user data in the
        /// events that it publishes to Amazon Pinpoint analytics.
        /// </para>
        /// </summary>
        public bool? UserDataShared { get; set; }

        /// <summary>
        /// Checks to see if the UserDataShared property is set.
        /// </summary>
        internal bool IsSetUserDataShared() => this.UserDataShared.HasValue;
    }
}

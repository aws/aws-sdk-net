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
    /// Container for the parameters to the SetUserPoolSessionConfiguration operation. Enables
    /// or disables session tracking for a user pool, and sets the pool-wide maximum number
    /// of active token sessions that each user can have. This operation performs a full replacement
    /// of the pool-level session configuration; every request parameter is required. The
    /// user pool must be in the Essentials or Plus tier. Otherwise, this operation returns
    /// a <c>FeatureUnavailableInTierException</c>.
    /// </summary>
    public partial class SetUserPoolSessionConfigurationRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property TokenSession. 
        /// <para>
        /// The pool-wide token session settings to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserPoolTokenSessionConfigType TokenSession { get; set; }

        /// <summary>
        /// Checks to see if the TokenSession property is set.
        /// </summary>
        internal bool IsSetTokenSession() => this.TokenSession != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to configure session tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;

        /// <summary>
        /// Gets and sets the property UserSessionTracking. 
        /// <para>
        /// Specifies whether Amazon Cognito tracks sessions for users in the user pool. Set this
        /// value to <c>ENABLED</c> to turn on server-side session tracking, or <c>DISABLED</c>
        /// to turn it off. When you set this value to <c>DISABLED</c> while the user pool remains
        /// active, existing client-level session configurations are retained but dormant, and
        /// are reactivated when you enable tracking again.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UserSessionTrackingType UserSessionTracking { get; set; }

        /// <summary>
        /// Checks to see if the UserSessionTracking property is set.
        /// </summary>
        internal bool IsSetUserSessionTracking() => this.UserSessionTracking != null;
    }
}

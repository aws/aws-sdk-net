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
    /// This is the response object from the GetUserPoolSessionConfiguration operation.
    /// </summary>
    public partial class GetUserPoolSessionConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TokenSession. 
        /// <para>
        /// The pool-wide token session settings for the user pool.
        /// </para>
        /// </summary>
        public UserPoolTokenSessionConfigType TokenSession { get; set; }

        /// <summary>
        /// Checks to see if the TokenSession property is set.
        /// </summary>
        internal bool IsSetTokenSession() => this.TokenSession != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that the session configuration applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;

        /// <summary>
        /// Gets and sets the property UserSessionTracking. 
        /// <para>
        /// Indicates whether session tracking is enabled for the user pool.
        /// </para>
        /// </summary>
        public UserSessionTrackingType UserSessionTracking { get; set; }

        /// <summary>
        /// Checks to see if the UserSessionTracking property is set.
        /// </summary>
        internal bool IsSetUserSessionTracking() => this.UserSessionTracking != null;
    }
}

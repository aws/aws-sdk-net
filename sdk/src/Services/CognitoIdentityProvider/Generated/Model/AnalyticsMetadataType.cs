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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// Information that your application adds to authentication requests. Applies an endpoint
    /// ID to the analytics data that your user pool sends to Amazon Pinpoint.
    /// 
    ///  
    /// <para>
    /// An endpoint ID uniquely identifies a mobile device, email address or phone number
    /// that can receive messages from Amazon Pinpoint analytics. For more information about
    /// Amazon Web Services Regions that can contain Amazon Pinpoint resources for use with
    /// Amazon Cognito user pools, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-pinpoint-integration.html">Using
    /// Amazon Pinpoint analytics with Amazon Cognito user pools</a>.
    /// </para>
    /// </summary>
    public partial class AnalyticsMetadataType
    {
        private string _analyticsEndpointId;

        /// <summary>
        /// Gets and sets the property AnalyticsEndpointId. 
        /// <para>
        /// The endpoint ID. Information that you want to pass to Amazon Pinpoint about where
        /// to send notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string AnalyticsEndpointId
        {
            get { return this._analyticsEndpointId; }
            set { this._analyticsEndpointId = value; }
        }

        // Check to see if AnalyticsEndpointId property is set
        internal bool IsSetAnalyticsEndpointId()
        {
            return this._analyticsEndpointId != null;
        }

    }
}
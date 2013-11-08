/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the SetPlatformApplicationAttributes operation.
    /// <para>The <c>SetPlatformApplicationAttributes</c> action sets the attributes of the platform application object for the supported push
    /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html"
    /// >Using Amazon SNS Mobile Push Notifications</a> .
    /// </para>
    /// </summary>
    public partial class SetPlatformApplicationAttributesRequest : AmazonWebServiceRequest
    {
        private string platformApplicationArn;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();

        /// <summary>
        /// PlatformApplicationArn for SetPlatformApplicationAttributes action.
        ///  
        /// </summary>
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArn; }
            set { this.platformApplicationArn = value; }
        }

        // Check to see if PlatformApplicationArn property is set
        internal bool IsSetPlatformApplicationArn()
        {
            return this.platformApplicationArn != null;
        }

        /// <summary>
        /// A map of the platform application attributes. Attributes in this map include the following: <ul> <!-- AllowEndpointPolicies,
        /// EventDeliveryAttemptFailure, and Policy are not yet supported. Will remove comments once it is available --> <li><c>PlatformCredential</c>
        /// -- The credential received from the notification service. For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM,
        /// PlatformCredential is "API key". For ADM,<!-- , WNS and MPNS--> PlatformCredential is "client secret".</li> <li><c>PlatformPrincipal</c> --
        /// The principal received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". For GCM,
        /// PlatformPrincipal is not applicable. For ADM,<!-- , WNS and MPNS--> PlatformPrincipal is "client id".</li> <!--
        /// <li><c>AllowEndpointPolicies</c> true or false (default false) - If true, then policies on endpoints will be evaluated to determine if the
        /// topic or user has the rights to send messages to it. If false, the endpoint policy will be ignored and only the mobile app policy will be
        /// considered.</li> --> <li><c>EventEndpointCreated</c> -- Topic ARN to which EndpointCreated event notifications should be sent.</li>
        /// <li><c>EventEndpointDeleted</c> -- Topic ARN to which EndpointDeleted event notifications should be sent.</li>
        /// <li><c>EventEndpointUpdated</c> -- Topic ARN to which EndpointUpdate event notifications should be sent.</li> <!--
        /// <li><c>EventDeliveryAttemptFailure</c> Topic ARN to which DeliveryAttemptFailure event notifications should be sent upon Direct Publish
        /// delivery attempt failures to one of the application's endpoints.</li> --> <li><c>EventDeliveryFailure</c> -- Topic ARN to which
        /// DeliveryFailure event notifications should be sent upon Direct Publish delivery failure (permanent) to one of the application's
        /// endpoints.</li> <!-- <li><c>Policy</c> Access policy controlling who can send messages to endpoints under this mobile app.</li> --> </ul>
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

    }
}
    

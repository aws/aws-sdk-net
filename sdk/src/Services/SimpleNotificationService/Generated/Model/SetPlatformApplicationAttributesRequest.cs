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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the SetPlatformApplicationAttributes operation.
    /// Sets the attributes of the platform application object for the supported push notification
    /// services, such as APNS and GCM (Firebase Cloud Messaging). For more information, see
    /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
    /// SNS Mobile Push Notifications</a>. For information on configuring attributes for message
    /// delivery status, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using
    /// Amazon SNS Application Attributes for Message Delivery Status</a>.
    /// </summary>
    public partial class SetPlatformApplicationAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _platformApplicationArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the platform application attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PlatformCredential</code> – The credential received from the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For ADM, <code>PlatformCredential</code>is client secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using certificate credentials, <code>PlatformCredential</code>
        /// is private key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using token credentials, <code>PlatformCredential</code> is signing
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GCM (Firebase Cloud Messaging), <code>PlatformCredential</code> is API key. 
        /// </para>
        ///  </li> </ul> </li> </ul> <ul> <li> 
        /// <para>
        ///  <code>PlatformPrincipal</code> – The principal received from the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For ADM, <code>PlatformPrincipal</code>is client id.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using certificate credentials, <code>PlatformPrincipal</code> is
        /// SSL certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using token credentials, <code>PlatformPrincipal</code> is signing
        /// key ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GCM (Firebase Cloud Messaging), there is no <code>PlatformPrincipal</code>. 
        /// </para>
        ///  </li> </ul> </li> </ul> <ul> <li> 
        /// <para>
        ///  <code>EventEndpointCreated</code> – Topic ARN to which <code>EndpointCreated</code>
        /// event notifications are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EventEndpointDeleted</code> – Topic ARN to which <code>EndpointDeleted</code>
        /// event notifications are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EventEndpointUpdated</code> – Topic ARN to which <code>EndpointUpdate</code>
        /// event notifications are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EventDeliveryFailure</code> – Topic ARN to which <code>DeliveryFailure</code>
        /// event notifications are sent upon Direct Publish delivery failure (permanent) to one
        /// of the application's endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SuccessFeedbackRoleArn</code> – IAM role ARN used to give Amazon SNS write
        /// access to use CloudWatch Logs on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FailureFeedbackRoleArn</code> – IAM role ARN used to give Amazon SNS write
        /// access to use CloudWatch Logs on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SuccessFeedbackSampleRate</code> – Sample rate percentage (0-100) of successfully
        /// delivered messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes only apply to <code>APNs</code> token-based authentication:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ApplePlatformTeamID</code> – The identifier that's assigned to your Apple developer
        /// account team.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApplePlatformBundleID</code> – The bundle identifier that's assigned to your
        /// iOS app.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformApplicationArn. 
        /// <para>
        /// PlatformApplicationArn for SetPlatformApplicationAttributes action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlatformApplicationArn
        {
            get { return this._platformApplicationArn; }
            set { this._platformApplicationArn = value; }
        }

        // Check to see if PlatformApplicationArn property is set
        internal bool IsSetPlatformApplicationArn()
        {
            return this._platformApplicationArn != null;
        }

    }
}
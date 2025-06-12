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

#pragma warning disable CS0612,CS0618,CS1570
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
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _platformApplicationArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the platform application attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PlatformCredential</c> – The credential received from the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For ADM, <c>PlatformCredential</c>is client secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using certificate credentials, <c>PlatformCredential</c> is private
        /// key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using token credentials, <c>PlatformCredential</c> is signing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GCM (Firebase Cloud Messaging) using key credentials, there is no <c>PlatformPrincipal</c>.
        /// The <c>PlatformCredential</c> is <c>API key</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GCM (Firebase Cloud Messaging) using token credentials, there is no <c>PlatformPrincipal</c>.
        /// The <c>PlatformCredential</c> is a JSON formatted private key file. When using the
        /// Amazon Web Services CLI, the file must be in string format and special characters
        /// must be ignored. To format the file correctly, Amazon SNS recommends using the following
        /// command: <c>SERVICE_JSON=`jq @json &lt;&lt;&lt; cat service.json`</c>.
        /// </para>
        ///  </li> </ul> </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>PlatformPrincipal</c> – The principal received from the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For ADM, <c>PlatformPrincipal</c>is client id.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using certificate credentials, <c>PlatformPrincipal</c> is SSL
        /// certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Apple Services using token credentials, <c>PlatformPrincipal</c> is signing key
        /// ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GCM (Firebase Cloud Messaging), there is no <c>PlatformPrincipal</c>. 
        /// </para>
        ///  </li> </ul> </li> </ul> <ul> <li> 
        /// <para>
        ///  <c>EventEndpointCreated</c> – Topic ARN to which <c>EndpointCreated</c> event notifications
        /// are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventEndpointDeleted</c> – Topic ARN to which <c>EndpointDeleted</c> event notifications
        /// are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventEndpointUpdated</c> – Topic ARN to which <c>EndpointUpdate</c> event notifications
        /// are sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventDeliveryFailure</c> – Topic ARN to which <c>DeliveryFailure</c> event notifications
        /// are sent upon Direct Publish delivery failure (permanent) to one of the application's
        /// endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SuccessFeedbackRoleArn</c> – IAM role ARN used to give Amazon SNS write access
        /// to use CloudWatch Logs on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FailureFeedbackRoleArn</c> – IAM role ARN used to give Amazon SNS write access
        /// to use CloudWatch Logs on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SuccessFeedbackSampleRate</c> – Sample rate percentage (0-100) of successfully
        /// delivered messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes only apply to <c>APNs</c> token-based authentication:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ApplePlatformTeamID</c> – The identifier that's assigned to your Apple developer
        /// account team.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApplePlatformBundleID</c> – The bundle identifier that's assigned to your iOS
        /// app.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformApplicationArn. 
        /// <para>
        ///  <c>PlatformApplicationArn</c> for <c>SetPlatformApplicationAttributes</c> action.
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
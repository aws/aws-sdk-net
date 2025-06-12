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
    /// Container for the parameters to the SetEndpointAttributes operation.
    /// Sets the attributes for an endpoint for a device on one of the supported push notification
    /// services, such as GCM (Firebase Cloud Messaging) and APNS. For more information, see
    /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
    /// SNS Mobile Push Notifications</a>.
    /// </summary>
    public partial class SetEndpointAttributesRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _endpointArn;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the endpoint attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CustomUserData</c> – arbitrary user data to associate with the endpoint. Amazon
        /// SNS does not use this data. The data must be in UTF-8 format and less than 2KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Enabled</c> – flag that enables/disables delivery to the endpoint. Amazon SNS
        /// will set this to false when a notification service indicates to Amazon SNS that the
        /// endpoint is invalid. Users can set it back to true, typically after updating Token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Token</c> – device token, also referred to as a registration id, for an app and
        /// mobile device. This is returned from the notification service when an app and mobile
        /// device are registered with the notification service.
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
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// EndpointArn used for <c>SetEndpointAttributes</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

    }
}
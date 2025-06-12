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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the delivery configuration settings for sending a campaign or campaign treatment
    /// through a custom channel. This object is required if you use the CampaignCustomMessage
    /// object to define the message to send for the campaign or campaign treatment.
    /// </summary>
    public partial class CustomDeliveryConfiguration
    {
        private string _deliveryUri;
        private List<string> _endpointTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DeliveryUri. 
        /// <para>
        /// The destination to send the campaign or treatment to. This value can be one of the
        /// following:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// The name or Amazon Resource Name (ARN) of an AWS Lambda function to invoke to handle
        /// delivery of the campaign or treatment.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The URL for a web application or service that supports HTTPS and can receive the message.
        /// The URL has to be a full URL, including the HTTPS protocol.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliveryUri
        {
            get { return this._deliveryUri; }
            set { this._deliveryUri = value; }
        }

        // Check to see if DeliveryUri property is set
        internal bool IsSetDeliveryUri()
        {
            return this._deliveryUri != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointTypes. 
        /// <para>
        /// The types of endpoints to send the campaign or treatment to. Each valid value maps
        /// to a type of channel that you can associate with an endpoint by using the ChannelType
        /// property of an endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EndpointTypes
        {
            get { return this._endpointTypes; }
            set { this._endpointTypes = value; }
        }

        // Check to see if EndpointTypes property is set
        internal bool IsSetEndpointTypes()
        {
            return this._endpointTypes != null && (this._endpointTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
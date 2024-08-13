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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the ListQueuedMessages operation.
    /// List queued messages in the downlink queue.
    /// </summary>
    public partial class ListQueuedMessagesRequest : AmazonIoTWirelessRequest
    {
        private string _id;
        private int? _maxResults;
        private string _nextToken;
        private WirelessDeviceType _wirelessDeviceType;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of a given wireless device which the downlink message packets are being sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// The wireless device type, whic can be either Sidewalk or LoRaWAN.
        /// </para>
        /// </summary>
        public WirelessDeviceType WirelessDeviceType
        {
            get { return this._wirelessDeviceType; }
            set { this._wirelessDeviceType = value; }
        }

        // Check to see if WirelessDeviceType property is set
        internal bool IsSetWirelessDeviceType()
        {
            return this._wirelessDeviceType != null;
        }

    }
}
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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the ListWirelessDevices operation. Lists the wireless
    /// devices registered to your AWS account.
    /// </summary>
    public partial class ListWirelessDevicesRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// A filter to list only the wireless devices that use as uplink destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// A filter to list only the wireless devices that use this device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DeviceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProfileId property is set.
        /// </summary>
        internal bool IsSetDeviceProfileId() => this.DeviceProfileId != null;

        /// <summary>
        /// Gets and sets the property FuotaTaskId.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FuotaTaskId { get; set; }

        /// <summary>
        /// Checks to see if the FuotaTaskId property is set.
        /// </summary>
        internal bool IsSetFuotaTaskId() => this.FuotaTaskId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MulticastGroupId.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MulticastGroupId { get; set; }

        /// <summary>
        /// Checks to see if the MulticastGroupId property is set.
        /// </summary>
        internal bool IsSetMulticastGroupId() => this.MulticastGroupId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceProfileId. 
        /// <para>
        /// A filter to list only the wireless devices that use this service profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ServiceProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceProfileId property is set.
        /// </summary>
        internal bool IsSetServiceProfileId() => this.ServiceProfileId != null;

        /// <summary>
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// A filter to list only the wireless devices that use this wireless device type.
        /// </para>
        /// </summary>
        public WirelessDeviceType WirelessDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the WirelessDeviceType property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceType() => this.WirelessDeviceType != null;
    }
}

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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// This is the response object from the ListDevicesForWirelessDeviceImportTask operation.
    /// </summary>
    public partial class ListDevicesForWirelessDeviceImportTaskResponse : AmazonWebServiceResponse
    {
        private string _destinationName;
        private List<ImportedWirelessDevice> _importedWirelessDeviceList = new List<ImportedWirelessDevice>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the Sidewalk destination that describes the IoT rule to route messages
        /// received from devices in an import task that are onboarded to AWS IoT Wireless.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedWirelessDeviceList. 
        /// <para>
        /// List of wireless devices in an import task and their onboarding status.
        /// </para>
        /// </summary>
        public List<ImportedWirelessDevice> ImportedWirelessDeviceList
        {
            get { return this._importedWirelessDeviceList; }
            set { this._importedWirelessDeviceList = value; }
        }

        // Check to see if ImportedWirelessDeviceList property is set
        internal bool IsSetImportedWirelessDeviceList()
        {
            return this._importedWirelessDeviceList != null && this._importedWirelessDeviceList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next set of results, or <code>null</code> if there are
        /// no additional results.
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

    }
}
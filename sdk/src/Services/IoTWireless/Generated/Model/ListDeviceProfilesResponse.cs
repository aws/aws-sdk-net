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
    /// This is the response object from the ListDeviceProfiles operation.
    /// </summary>
    public partial class ListDeviceProfilesResponse : AmazonWebServiceResponse
    {
        private List<DeviceProfile> _deviceProfileList = new List<DeviceProfile>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DeviceProfileList. 
        /// <para>
        /// The list of device profiles.
        /// </para>
        /// </summary>
        public List<DeviceProfile> DeviceProfileList
        {
            get { return this._deviceProfileList; }
            set { this._deviceProfileList = value; }
        }

        // Check to see if DeviceProfileList property is set
        internal bool IsSetDeviceProfileList()
        {
            return this._deviceProfileList != null && this._deviceProfileList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next set of results, or <b>null</b> if there are no additional
        /// results.
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
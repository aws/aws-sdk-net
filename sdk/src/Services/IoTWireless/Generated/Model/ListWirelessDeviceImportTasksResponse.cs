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
    /// This is the response object from the ListWirelessDeviceImportTasks operation.
    /// </summary>
    public partial class ListWirelessDeviceImportTasksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WirelessDeviceImportTask> _wirelessDeviceImportTaskList = new List<WirelessDeviceImportTask>();

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

        /// <summary>
        /// Gets and sets the property WirelessDeviceImportTaskList. 
        /// <para>
        /// List of import tasks and summary information of onboarding status of devices in each
        /// import task.
        /// </para>
        /// </summary>
        public List<WirelessDeviceImportTask> WirelessDeviceImportTaskList
        {
            get { return this._wirelessDeviceImportTaskList; }
            set { this._wirelessDeviceImportTaskList = value; }
        }

        // Check to see if WirelessDeviceImportTaskList property is set
        internal bool IsSetWirelessDeviceImportTaskList()
        {
            return this._wirelessDeviceImportTaskList != null && this._wirelessDeviceImportTaskList.Count > 0; 
        }

    }
}
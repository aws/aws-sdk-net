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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteDetector operation.
    /// </summary>
    public partial class BatchDeleteDetectorResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteDetectorErrorEntry> _batchDeleteDetectorErrorEntries = new List<BatchDeleteDetectorErrorEntry>();

        /// <summary>
        /// Gets and sets the property BatchDeleteDetectorErrorEntries. 
        /// <para>
        /// A list of errors associated with the request, or an empty array (<code>[]</code>)
        /// if there are no errors. Each error entry contains a <code>messageId</code> that helps
        /// you identify the entry that failed.
        /// </para>
        /// </summary>
        public List<BatchDeleteDetectorErrorEntry> BatchDeleteDetectorErrorEntries
        {
            get { return this._batchDeleteDetectorErrorEntries; }
            set { this._batchDeleteDetectorErrorEntries = value; }
        }

        // Check to see if BatchDeleteDetectorErrorEntries property is set
        internal bool IsSetBatchDeleteDetectorErrorEntries()
        {
            return this._batchDeleteDetectorErrorEntries != null && this._batchDeleteDetectorErrorEntries.Count > 0; 
        }

    }
}
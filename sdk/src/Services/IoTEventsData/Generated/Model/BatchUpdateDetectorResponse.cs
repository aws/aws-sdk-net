/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateDetector operation.
    /// </summary>
    public partial class BatchUpdateDetectorResponse : AmazonWebServiceResponse
    {
        private List<BatchUpdateDetectorErrorEntry> _batchUpdateDetectorErrorEntries = new List<BatchUpdateDetectorErrorEntry>();

        /// <summary>
        /// Gets and sets the property BatchUpdateDetectorErrorEntries. 
        /// <para>
        /// A list of those detector updates that resulted in errors. (If an error is listed here,
        /// the specific update did not occur.)
        /// </para>
        /// </summary>
        public List<BatchUpdateDetectorErrorEntry> BatchUpdateDetectorErrorEntries
        {
            get { return this._batchUpdateDetectorErrorEntries; }
            set { this._batchUpdateDetectorErrorEntries = value; }
        }

        // Check to see if BatchUpdateDetectorErrorEntries property is set
        internal bool IsSetBatchUpdateDetectorErrorEntries()
        {
            return this._batchUpdateDetectorErrorEntries != null && this._batchUpdateDetectorErrorEntries.Count > 0; 
        }

    }
}
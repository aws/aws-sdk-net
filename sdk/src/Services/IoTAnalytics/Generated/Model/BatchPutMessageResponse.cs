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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// This is the response object from the BatchPutMessage operation.
    /// </summary>
    public partial class BatchPutMessageResponse : AmazonWebServiceResponse
    {
        private List<BatchPutMessageErrorEntry> _batchPutMessageErrorEntries = new List<BatchPutMessageErrorEntry>();

        /// <summary>
        /// Gets and sets the property BatchPutMessageErrorEntries. 
        /// <para>
        /// A list of any errors encountered when sending the messages to the channel.
        /// </para>
        /// </summary>
        public List<BatchPutMessageErrorEntry> BatchPutMessageErrorEntries
        {
            get { return this._batchPutMessageErrorEntries; }
            set { this._batchPutMessageErrorEntries = value; }
        }

        // Check to see if BatchPutMessageErrorEntries property is set
        internal bool IsSetBatchPutMessageErrorEntries()
        {
            return this._batchPutMessageErrorEntries != null && this._batchPutMessageErrorEntries.Count > 0; 
        }

    }
}
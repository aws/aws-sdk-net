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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the TestTransformer operation.
    /// </summary>
    public partial class TestTransformerResponse : AmazonWebServiceResponse
    {
        private List<TransformedLogRecord> _transformedLogs = AWSConfigs.InitializeCollections ? new List<TransformedLogRecord>() : null;

        /// <summary>
        /// Gets and sets the property TransformedLogs. 
        /// <para>
        /// An array where each member of the array includes both the original version and the
        /// transformed version of one of the log events that you input.
        /// </para>
        /// </summary>
        public List<TransformedLogRecord> TransformedLogs
        {
            get { return this._transformedLogs; }
            set { this._transformedLogs = value; }
        }

        // Check to see if TransformedLogs property is set
        internal bool IsSetTransformedLogs()
        {
            return this._transformedLogs != null && (this._transformedLogs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
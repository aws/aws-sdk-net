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
    /// Statistics about the import progress
    /// </summary>
    public partial class ImportStatistics
    {
        private long? _bytesImported;

        /// <summary>
        /// Gets and sets the property BytesImported. 
        /// <para>
        /// The total number of bytes that have been imported to the managed log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? BytesImported
        {
            get { return this._bytesImported; }
            set { this._bytesImported = value; }
        }

        // Check to see if BytesImported property is set
        internal bool IsSetBytesImported()
        {
            return this._bytesImported.HasValue; 
        }

    }
}
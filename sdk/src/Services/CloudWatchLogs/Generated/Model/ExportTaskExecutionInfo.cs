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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents the status of an export task.
    /// </summary>
    public partial class ExportTaskExecutionInfo
    {
        private long? _completionTime;
        private long? _creationTime;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The completion time of the export task, expressed as the number of milliseconds after
        /// <code>Jan 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the export task, expressed as the number of milliseconds after
        /// <code>Jan 1, 1970 00:00:00 UTC</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

    }
}
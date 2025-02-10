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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the CancelExportTask operation.
    /// Cancel the specified export task.
    /// </summary>
    public partial class CancelExportTaskRequest : AmazonNeptuneGraphRequest
    {
        private string _taskIdentifier;

        /// <summary>
        /// Gets and sets the property TaskIdentifier. 
        /// <para>
        /// The unique identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskIdentifier
        {
            get { return this._taskIdentifier; }
            set { this._taskIdentifier = value; }
        }

        // Check to see if TaskIdentifier property is set
        internal bool IsSetTaskIdentifier()
        {
            return this._taskIdentifier != null;
        }

    }
}
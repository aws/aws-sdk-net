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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Identifies a specific batch job.
    /// </summary>
    public partial class BatchJobIdentifier
    {
        private FileBatchJobIdentifier _fileBatchJobIdentifier;
        private ScriptBatchJobIdentifier _scriptBatchJobIdentifier;

        /// <summary>
        /// Gets and sets the property FileBatchJobIdentifier. 
        /// <para>
        /// Specifies a file associated with a specific batch job.
        /// </para>
        /// </summary>
        public FileBatchJobIdentifier FileBatchJobIdentifier
        {
            get { return this._fileBatchJobIdentifier; }
            set { this._fileBatchJobIdentifier = value; }
        }

        // Check to see if FileBatchJobIdentifier property is set
        internal bool IsSetFileBatchJobIdentifier()
        {
            return this._fileBatchJobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptBatchJobIdentifier. 
        /// <para>
        /// A batch job identifier in which the batch job to run is identified by the script name.
        /// </para>
        /// </summary>
        public ScriptBatchJobIdentifier ScriptBatchJobIdentifier
        {
            get { return this._scriptBatchJobIdentifier; }
            set { this._scriptBatchJobIdentifier = value; }
        }

        // Check to see if ScriptBatchJobIdentifier property is set
        internal bool IsSetScriptBatchJobIdentifier()
        {
            return this._scriptBatchJobIdentifier != null;
        }

    }
}
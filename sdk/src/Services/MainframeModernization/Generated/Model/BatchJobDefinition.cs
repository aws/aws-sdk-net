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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Defines the details of a batch job.
    /// </summary>
    public partial class BatchJobDefinition
    {
        private FileBatchJobDefinition _fileBatchJobDefinition;
        private ScriptBatchJobDefinition _scriptBatchJobDefinition;

        /// <summary>
        /// Gets and sets the property FileBatchJobDefinition. 
        /// <para>
        /// Specifies a file containing a batch job definition.
        /// </para>
        /// </summary>
        public FileBatchJobDefinition FileBatchJobDefinition
        {
            get { return this._fileBatchJobDefinition; }
            set { this._fileBatchJobDefinition = value; }
        }

        // Check to see if FileBatchJobDefinition property is set
        internal bool IsSetFileBatchJobDefinition()
        {
            return this._fileBatchJobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptBatchJobDefinition. 
        /// <para>
        /// A script containing a batch job definition.
        /// </para>
        /// </summary>
        public ScriptBatchJobDefinition ScriptBatchJobDefinition
        {
            get { return this._scriptBatchJobDefinition; }
            set { this._scriptBatchJobDefinition = value; }
        }

        // Check to see if ScriptBatchJobDefinition property is set
        internal bool IsSetScriptBatchJobDefinition()
        {
            return this._scriptBatchJobDefinition != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipeline operation.
    /// Updates a specified pipeline with edits or changes to its structure. Use a JSON file
    /// with the pipeline structure and <c>UpdatePipeline</c> to provide the full structure
    /// of the pipeline. Updating the pipeline increases the version number of the pipeline
    /// by 1.
    /// </summary>
    public partial class UpdatePipelineRequest : AmazonCodePipelineRequest
    {
        private PipelineDeclaration _pipeline;

        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// The name of the pipeline to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PipelineDeclaration Pipeline
        {
            get { return this._pipeline; }
            set { this._pipeline = value; }
        }

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this._pipeline != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePipeline operation.
    /// Creates a new empty pipeline. When this action succeeds, you can then use the <a>PutPipelineDefinition</a>
    /// action to populate the pipeline.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonDataPipelineRequest
    {
        private string _description;
        private string _name;
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the new pipeline.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the new pipeline. You can use the same name for multiple pipelines associated
        /// with your AWS account, because AWS Data Pipeline assigns each new pipeline a unique
        /// pipeline identifier. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        ///  A unique identifier that you specify. This identifier is not the same as the pipeline
        /// identifier assigned by AWS Data Pipeline. You are responsible for defining the format
        /// and ensuring the uniqueness of this identifier. You use this parameter to ensure idempotency
        /// during repeated calls to <a>CreatePipeline</a>. For example, if the first call to
        /// <a>CreatePipeline</a> does not return a clear success, you can pass in the same unique
        /// identifier and pipeline name combination on a subsequent call to <a>CreatePipeline</a>.
        /// <a>CreatePipeline</a> ensures that if a pipeline already exists with the same name
        /// and unique identifier, a new pipeline will not be created. Instead, you'll receive
        /// the pipeline identifier from the previous attempt. The uniqueness of the name and
        /// unique identifier combination is scoped to the AWS account or IAM user credentials.
        /// 
        /// </para>
        /// </summary>
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this._uniqueId = value; }
        }

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this._uniqueId != null;
        }

    }
}
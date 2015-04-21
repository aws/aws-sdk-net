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
    /// Creates a new, empty pipeline. Use <a>PutPipelineDefinition</a> to populate the pipeline.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonDataPipelineRequest
    {
        private string _description;
        private string _name;
        private List<Tag> _tags = new List<Tag>();
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the pipeline.
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
        /// The name for the pipeline. You can use the same name for multiple pipelines associated
        /// with your AWS account, because AWS Data Pipeline assigns each pipeline a unique pipeline
        /// identifier.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the pipeline at creation. Tags let you control access
        /// to pipelines. For more information, see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-control-access.html">Controlling
        /// User Access to Pipelines</a> in the <i>AWS Data Pipeline Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// A unique identifier. This identifier is not the same as the pipeline identifier assigned
        /// by AWS Data Pipeline. You are responsible for defining the format and ensuring the
        /// uniqueness of this identifier. You use this parameter to ensure idempotency during
        /// repeated calls to <code>CreatePipeline</code>. For example, if the first call to <code>CreatePipeline</code>
        /// does not succeed, you can pass in the same unique identifier and pipeline name combination
        /// on a subsequent call to <code>CreatePipeline</code>. <code>CreatePipeline</code> ensures
        /// that if a pipeline already exists with the same name and unique identifier, a new
        /// pipeline is not created. Instead, you'll receive the pipeline identifier from the
        /// previous attempt. The uniqueness of the name and unique identifier combination is
        /// scoped to the AWS account or IAM user credentials.
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
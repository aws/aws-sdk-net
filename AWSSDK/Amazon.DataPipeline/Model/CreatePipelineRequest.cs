/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates a new empty pipeline. When this action succeeds, you can then use the PutPipelineDefinition action to populate the
    /// pipeline.</para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.CreatePipeline"/>
    public class CreatePipelineRequest : AmazonWebServiceRequest
    {
        private string name;
        private string uniqueId;
        private string description;

        /// <summary>
        /// The name of the new pipeline. You can use the same name for multiple pipelines associated with your AWS account, because AWS Data Pipeline
        /// assigns each new pipeline a unique pipeline identifier.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A unique identifier that you specify. This identifier is not the same as the pipeline identifier assigned by AWS Data Pipeline. You are
        /// responsible for defining the format and ensuring the uniqueness of this identifier. You use this parameter to ensure idempotency during
        /// repeated calls to <a>CreatePipeline</a>. For example, if the first call to <a>CreatePipeline</a> does not return a clear success, you can
        /// pass in the same unique identifier and pipeline name combination on a subsequent call to <a>CreatePipeline</a>. <a>CreatePipeline</a>
        /// ensures that if a pipeline already exists with the same name and unique identifier, a new pipeline will not be created. Instead, you'll
        /// receive the pipeline identifier from the previous attempt. The uniqueness of the name and unique identifier combination is scoped to the AWS
        /// account or IAM user credentials.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UniqueId
        {
            get { return this.uniqueId; }
            set { this.uniqueId = value; }
        }

        /// <summary>
        /// Sets the UniqueId property
        /// </summary>
        /// <param name="uniqueId">The value to set for the UniqueId property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithUniqueId(string uniqueId)
        {
            this.uniqueId = uniqueId;
            return this;
        }
            

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this.uniqueId != null;
        }

        /// <summary>
        /// The description of the new pipeline.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public CreatePipelineRequest WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
    

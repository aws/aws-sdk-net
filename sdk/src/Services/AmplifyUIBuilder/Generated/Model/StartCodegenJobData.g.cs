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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// The code generation job resource configuration.
    /// </summary>
    public partial class StartCodegenJobData
    {
        /// <summary>
        /// Gets and sets the property AutoGenerateForms. 
        /// <para>
        /// Specifies whether to autogenerate forms in the code generation job.
        /// </para>
        /// </summary>
        public bool? AutoGenerateForms { get; set; }

        /// <summary>
        /// Checks to see if the AutoGenerateForms property is set.
        /// </summary>
        internal bool IsSetAutoGenerateForms() => this.AutoGenerateForms.HasValue;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The feature flags for a code generation job.
        /// </para>
        /// </summary>
        public CodegenFeatureFlags Features { get; set; }

        /// <summary>
        /// Checks to see if the Features property is set.
        /// </summary>
        internal bool IsSetFeatures() => this.Features != null;

        /// <summary>
        /// Gets and sets the property GenericDataSchema. 
        /// <para>
        /// The data schema to use for a code generation job.
        /// </para>
        /// </summary>
        public CodegenJobGenericDataSchema GenericDataSchema { get; set; }

        /// <summary>
        /// Checks to see if the GenericDataSchema property is set.
        /// </summary>
        internal bool IsSetGenericDataSchema() => this.GenericDataSchema != null;

        /// <summary>
        /// Gets and sets the property RenderConfig. 
        /// <para>
        /// The code generation configuration for the codegen job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodegenJobRenderConfig RenderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RenderConfig property is set.
        /// </summary>
        internal bool IsSetRenderConfig() => this.RenderConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the code generation job data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

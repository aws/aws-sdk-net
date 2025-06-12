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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
        private bool? _autoGenerateForms;
        private CodegenFeatureFlags _features;
        private CodegenJobGenericDataSchema _genericDataSchema;
        private CodegenJobRenderConfig _renderConfig;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AutoGenerateForms. 
        /// <para>
        /// Specifies whether to autogenerate forms in the code generation job.
        /// </para>
        /// </summary>
        public bool? AutoGenerateForms
        {
            get { return this._autoGenerateForms; }
            set { this._autoGenerateForms = value; }
        }

        // Check to see if AutoGenerateForms property is set
        internal bool IsSetAutoGenerateForms()
        {
            return this._autoGenerateForms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// The feature flags for a code generation job.
        /// </para>
        /// </summary>
        public CodegenFeatureFlags Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null;
        }

        /// <summary>
        /// Gets and sets the property GenericDataSchema. 
        /// <para>
        /// The data schema to use for a code generation job.
        /// </para>
        /// </summary>
        public CodegenJobGenericDataSchema GenericDataSchema
        {
            get { return this._genericDataSchema; }
            set { this._genericDataSchema = value; }
        }

        // Check to see if GenericDataSchema property is set
        internal bool IsSetGenericDataSchema()
        {
            return this._genericDataSchema != null;
        }

        /// <summary>
        /// Gets and sets the property RenderConfig. 
        /// <para>
        /// The code generation configuration for the codegen job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodegenJobRenderConfig RenderConfig
        {
            get { return this._renderConfig; }
            set { this._renderConfig = value; }
        }

        // Check to see if RenderConfig property is set
        internal bool IsSetRenderConfig()
        {
            return this._renderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more key-value pairs to use when tagging the code generation job data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
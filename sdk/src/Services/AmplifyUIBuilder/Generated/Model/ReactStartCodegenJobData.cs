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
    /// Describes the code generation job configuration for a React project.
    /// </summary>
    public partial class ReactStartCodegenJobData
    {
        private ApiConfiguration _apiConfiguration;
        private Dictionary<string, string> _dependencies = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _inlineSourceMap;
        private JSModule _module;
        private bool? _renderTypeDeclarations;
        private JSScript _script;
        private JSTarget _target;

        /// <summary>
        /// Gets and sets the property ApiConfiguration. 
        /// <para>
        /// The API configuration for the code generation job.
        /// </para>
        /// </summary>
        public ApiConfiguration ApiConfiguration
        {
            get { return this._apiConfiguration; }
            set { this._apiConfiguration = value; }
        }

        // Check to see if ApiConfiguration property is set
        internal bool IsSetApiConfiguration()
        {
            return this._apiConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Lists the dependency packages that may be required for the project code to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Dependencies
        {
            get { return this._dependencies; }
            set { this._dependencies = value; }
        }

        // Check to see if Dependencies property is set
        internal bool IsSetDependencies()
        {
            return this._dependencies != null && (this._dependencies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InlineSourceMap. 
        /// <para>
        /// Specifies whether the code generation job should render inline source maps.
        /// </para>
        /// </summary>
        public bool? InlineSourceMap
        {
            get { return this._inlineSourceMap; }
            set { this._inlineSourceMap = value; }
        }

        // Check to see if InlineSourceMap property is set
        internal bool IsSetInlineSourceMap()
        {
            return this._inlineSourceMap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Module. 
        /// <para>
        /// The JavaScript module type.
        /// </para>
        /// </summary>
        public JSModule Module
        {
            get { return this._module; }
            set { this._module = value; }
        }

        // Check to see if Module property is set
        internal bool IsSetModule()
        {
            return this._module != null;
        }

        /// <summary>
        /// Gets and sets the property RenderTypeDeclarations. 
        /// <para>
        /// Specifies whether the code generation job should render type declaration files.
        /// </para>
        /// </summary>
        public bool? RenderTypeDeclarations
        {
            get { return this._renderTypeDeclarations; }
            set { this._renderTypeDeclarations = value; }
        }

        // Check to see if RenderTypeDeclarations property is set
        internal bool IsSetRenderTypeDeclarations()
        {
            return this._renderTypeDeclarations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// The file type to use for a JavaScript project.
        /// </para>
        /// </summary>
        public JSScript Script
        {
            get { return this._script; }
            set { this._script = value; }
        }

        // Check to see if Script property is set
        internal bool IsSetScript()
        {
            return this._script != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The ECMAScript specification to use.
        /// </para>
        /// </summary>
        public JSTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}
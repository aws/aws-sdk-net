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
    /// Describes the code generation job configuration for a React project.
    /// </summary>
    public partial class ReactStartCodegenJobData
    {
        /// <summary>
        /// Gets and sets the property ApiConfiguration. 
        /// <para>
        /// The API configuration for the code generation job.
        /// </para>
        /// </summary>
        public ApiConfiguration ApiConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApiConfiguration property is set.
        /// </summary>
        internal bool IsSetApiConfiguration() => this.ApiConfiguration != null;

        /// <summary>
        /// Gets and sets the property Dependencies. 
        /// <para>
        /// Lists the dependency packages that may be required for the project code to run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Dependencies { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dependencies property is set.
        /// </summary>
        internal bool IsSetDependencies() => this.Dependencies != null && (this.Dependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InlineSourceMap. 
        /// <para>
        /// Specifies whether the code generation job should render inline source maps.
        /// </para>
        /// </summary>
        public bool? InlineSourceMap { get; set; }

        /// <summary>
        /// Checks to see if the InlineSourceMap property is set.
        /// </summary>
        internal bool IsSetInlineSourceMap() => this.InlineSourceMap.HasValue;

        /// <summary>
        /// Gets and sets the property Module. 
        /// <para>
        /// The JavaScript module type.
        /// </para>
        /// </summary>
        public JSModule Module { get; set; }

        /// <summary>
        /// Checks to see if the Module property is set.
        /// </summary>
        internal bool IsSetModule() => this.Module != null;

        /// <summary>
        /// Gets and sets the property RenderTypeDeclarations. 
        /// <para>
        /// Specifies whether the code generation job should render type declaration files.
        /// </para>
        /// </summary>
        public bool? RenderTypeDeclarations { get; set; }

        /// <summary>
        /// Checks to see if the RenderTypeDeclarations property is set.
        /// </summary>
        internal bool IsSetRenderTypeDeclarations() => this.RenderTypeDeclarations.HasValue;

        /// <summary>
        /// Gets and sets the property Script. 
        /// <para>
        /// The file type to use for a JavaScript project.
        /// </para>
        /// </summary>
        public JSScript Script { get; set; }

        /// <summary>
        /// Checks to see if the Script property is set.
        /// </summary>
        internal bool IsSetScript() => this.Script != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The ECMAScript specification to use.
        /// </para>
        /// </summary>
        public JSTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}

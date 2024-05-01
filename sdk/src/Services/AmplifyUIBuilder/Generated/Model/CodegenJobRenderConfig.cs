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
    /// Describes the configuration information for rendering the UI component associated
    /// with the code generation job.
    /// </summary>
    public partial class CodegenJobRenderConfig
    {
        private ReactStartCodegenJobData _react;

        /// <summary>
        /// Gets and sets the property React. 
        /// <para>
        /// The name of the <c>ReactStartCodegenJobData</c> object.
        /// </para>
        /// </summary>
        public ReactStartCodegenJobData React
        {
            get { return this._react; }
            set { this._react = value; }
        }

        // Check to see if React property is set
        internal bool IsSetReact()
        {
            return this._react != null;
        }

    }
}
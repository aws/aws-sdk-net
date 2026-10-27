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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// The build configuration for a web function revision, including code location and runtime
    /// settings.
    /// </summary>
    public partial class BuildConfig
    {
        /// <summary>
        /// Gets and sets the property CodeConfig. 
        /// <para>
        /// The code configuration specifying where the deployment artifact is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeConfig CodeConfig { get; set; }

        /// <summary>
        /// Checks to see if the CodeConfig property is set.
        /// </summary>
        internal bool IsSetCodeConfig() => this.CodeConfig != null;

        /// <summary>
        /// Gets and sets the property RuntimeConfig. 
        /// <para>
        /// The runtime configuration for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeConfig property is set.
        /// </summary>
        internal bool IsSetRuntimeConfig() => this.RuntimeConfig != null;
    }
}

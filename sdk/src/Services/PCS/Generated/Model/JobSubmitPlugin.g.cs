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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// A job submit plugin configuration, including its name, runtime language, and script
    /// source.
    /// </summary>
    public partial class JobSubmitPlugin
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the plugin. The name can be up to 64 characters long. Valid characters
        /// are letters, numbers, spaces, underscores (<c>_</c>), and hyphens (<c>-</c>). The
        /// first character must be a letter or a number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScriptSource. 
        /// <para>
        /// The source location and integrity information for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobSubmitScriptSource ScriptSource { get; set; }

        /// <summary>
        /// Checks to see if the ScriptSource property is set.
        /// </summary>
        internal bool IsSetScriptSource() => this.ScriptSource != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The runtime language used to execute the custom script. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STARLARK</c> – The script uses Starlark syntax.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobSubmitPluginType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

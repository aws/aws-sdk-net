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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for a <c>CUSTOM_OUTPUT</c> function. MediaTailor evaluates the output
    /// expressions against the current session state and commits the results as output bindings.
    /// <c>CUSTOM_OUTPUT</c> functions do not make external calls. For more information, see
    /// <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-types-custom-output.html">CUSTOM_OUTPUT</a>
    /// in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class CustomOutputConfiguration
    {
        private Dictionary<string, string> _output = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private RuntimeType _runtime;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A map of output bindings. Each key is a namespaced output path (such as <c>player_params.device_type</c>
        /// or <c>temp.variant</c>), and each value is an expression that MediaTailor evaluates
        /// at runtime against the current session state. For more information about expression
        /// syntax, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions-jsonata.html">JSONata
        /// expression reference</a> in the <i>MediaTailor User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Output
        {
            get { return this._output; }
            set { this._output = value; }
        }

        // Check to see if Output property is set
        internal bool IsSetOutput()
        {
            return this._output != null && (this._output.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The expression language used to evaluate expressions in the function configuration.
        /// Set this to <c>JSONata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeType Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

    }
}
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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// A value such as an Amazon Resource Name (ARN) or an Amazon Simple Notification Service
    /// topic entered in an extension when invoked. Parameter values are specified in an extension
    /// association. For more information about extensions, see <a href="https://docs.aws.amazon.com/appconfig/latest/userguide/working-with-appconfig-extensions.html">Extending
    /// workflows</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Dynamic. 
        /// <para>
        /// Indicates whether this parameter's value can be supplied at the extension's action
        /// point instead of during extension association. Dynamic parameters can't be marked
        /// <c>Required</c>.
        /// </para>
        /// </summary>
        public bool? Dynamic { get; set; }

        /// <summary>
        /// Checks to see if the Dynamic property is set.
        /// </summary>
        internal bool IsSetDynamic() => this.Dynamic.HasValue;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// A parameter value must be specified in the extension association.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}

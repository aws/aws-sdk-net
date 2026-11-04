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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>TemplateParameter</c> data type.
    /// </summary>
    public partial class TemplateParameter
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value associated with the parameter.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User defined description associated with the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NoEcho. 
        /// <para>
        /// Flag indicating whether the parameter should be displayed as plain text in logs and
        /// UIs.
        /// </para>
        /// </summary>
        public bool? NoEcho { get; set; }

        /// <summary>
        /// Checks to see if the NoEcho property is set.
        /// </summary>
        internal bool IsSetNoEcho() => this.NoEcho.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The name associated with the parameter.
        /// </para>
        /// </summary>
        public string ParameterKey { get; set; }

        /// <summary>
        /// Checks to see if the ParameterKey property is set.
        /// </summary>
        internal bool IsSetParameterKey() => this.ParameterKey != null;
    }
}

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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The input parameters of a template.
    /// </summary>
    public partial class TemplateInput
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the template input.
        /// </para>
        /// </summary>
        public DataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InputName { get; set; }

        /// <summary>
        /// Checks to see if the InputName property is set.
        /// </summary>
        internal bool IsSetInputName() => this.InputName != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Determine if an input is required from the template.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}

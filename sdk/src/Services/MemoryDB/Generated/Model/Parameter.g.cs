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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Describes an individual setting that controls some aspect of MemoryDB behavior.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The valid range of values for the parameter.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The parameter's data type
        /// </para>
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The earliest engine version to which the parameter can apply.
        /// </para>
        /// </summary>
        public string MinimumEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumEngineVersion property is set.
        /// </summary>
        internal bool IsSetMinimumEngineVersion() => this.MinimumEngineVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the parameter
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

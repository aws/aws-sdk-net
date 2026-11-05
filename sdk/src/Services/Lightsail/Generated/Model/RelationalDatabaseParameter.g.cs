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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the parameters of a database.
    /// </summary>
    public partial class RelationalDatabaseParameter
    {
        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// Specifies the valid range of values for the parameter.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property ApplyMethod. 
        /// <para>
        /// Indicates when parameter updates are applied.
        /// </para>
        ///  
        /// <para>
        /// Can be <c>immediate</c> or <c>pending-reboot</c>.
        /// </para>
        /// </summary>
        public string ApplyMethod { get; set; }

        /// <summary>
        /// Checks to see if the ApplyMethod property is set.
        /// </summary>
        internal bool IsSetApplyMethod() => this.ApplyMethod != null;

        /// <summary>
        /// Gets and sets the property ApplyType. 
        /// <para>
        /// Specifies the engine-specific parameter type.
        /// </para>
        /// </summary>
        public string ApplyType { get; set; }

        /// <summary>
        /// Checks to see if the ApplyType property is set.
        /// </summary>
        internal bool IsSetApplyType() => this.ApplyType != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// Specifies the valid data type for the parameter.
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
        /// Provides a description of the parameter.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// A Boolean value indicating whether the parameter can be modified.
        /// </para>
        /// </summary>
        public bool? IsModifiable { get; set; }

        /// <summary>
        /// Checks to see if the IsModifiable property is set.
        /// </summary>
        internal bool IsSetIsModifiable() => this.IsModifiable.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// Specifies the name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// Specifies the value of the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// Checks to see if the ParameterValue property is set.
        /// </summary>
        internal bool IsSetParameterValue() => this.ParameterValue != null;
    }
}

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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The comparison operand used to compare the defined value against the value supplied
    /// in request.
    /// </summary>
    public partial class CommandParameterValueComparisonOperand
    {
        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// An operand of number value type, defined as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number != null;

        /// <summary>
        /// Gets and sets the property NumberRange. 
        /// <para>
        /// An operand of numerical range value type.
        /// </para>
        /// </summary>
        public CommandParameterValueNumberRange NumberRange { get; set; }

        /// <summary>
        /// Checks to see if the NumberRange property is set.
        /// </summary>
        internal bool IsSetNumberRange() => this.NumberRange != null;

        /// <summary>
        /// Gets and sets the property Numbers. 
        /// <para>
        /// A List of operands of numerical value type, defined as strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Numbers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Numbers property is set.
        /// </summary>
        internal bool IsSetNumbers() => this.Numbers != null && (this.Numbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// An operand of string value type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;

        /// <summary>
        /// Gets and sets the property Strings. 
        /// <para>
        /// A List of operands of string value type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Strings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Strings property is set.
        /// </summary>
        internal bool IsSetStrings() => this.Strings != null && (this.Strings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

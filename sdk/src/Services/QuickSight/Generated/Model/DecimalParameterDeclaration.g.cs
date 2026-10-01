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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A parameter declaration for the <c>Decimal</c> data type.
    /// </summary>
    public partial class DecimalParameterDeclaration
    {
        /// <summary>
        /// Gets and sets the property DefaultValues. 
        /// <para>
        /// The default values of a parameter. If the parameter is a single-value parameter, a
        /// maximum of one default value can be provided.
        /// </para>
        /// </summary>
        public DecimalDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValues property is set.
        /// </summary>
        internal bool IsSetDefaultValues() => this.DefaultValues != null;

        /// <summary>
        /// Gets and sets the property MappedDataSetParameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public List<MappedDataSetParameter> MappedDataSetParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<MappedDataSetParameter>() : null;

        /// <summary>
        /// Checks to see if the MappedDataSetParameters property is set.
        /// </summary>
        internal bool IsSetMappedDataSetParameters() => this.MappedDataSetParameters != null && (this.MappedDataSetParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that is being declared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterValueType. 
        /// <para>
        /// The value type determines whether the parameter is a single-value or multi-value parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParameterValueType ParameterValueType { get; set; }

        /// <summary>
        /// Checks to see if the ParameterValueType property is set.
        /// </summary>
        internal bool IsSetParameterValueType() => this.ParameterValueType != null;

        /// <summary>
        /// Gets and sets the property ValueWhenUnset. 
        /// <para>
        /// The configuration that defines the default value of a <c>Decimal</c> parameter when
        /// a value has not been set.
        /// </para>
        /// </summary>
        public DecimalValueWhenUnsetConfiguration ValueWhenUnset { get; set; }

        /// <summary>
        /// Checks to see if the ValueWhenUnset property is set.
        /// </summary>
        internal bool IsSetValueWhenUnset() => this.ValueWhenUnset != null;
    }
}

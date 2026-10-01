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
    /// An integer parameter for a dataset.
    /// </summary>
    public partial class IntegerDatasetParameter
    {
        /// <summary>
        /// Gets and sets the property DefaultValues. 
        /// <para>
        /// A list of default values for a given integer parameter. This structure only accepts
        /// static values.
        /// </para>
        /// </summary>
        public IntegerDatasetParameterDefaultValues DefaultValues { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValues property is set.
        /// </summary>
        internal bool IsSetDefaultValues() => this.DefaultValues != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for the integer parameter created in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the integer parameter that is created in the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The value type of the dataset parameter. Valid values are <c>single value</c> or <c>multi
        /// value</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetParameterValueType ValueType { get; set; }

        /// <summary>
        /// Checks to see if the ValueType property is set.
        /// </summary>
        internal bool IsSetValueType() => this.ValueType != null;
    }
}

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
    /// A transform operation that overrides the dataset parameter values that are defined
    /// in another dataset.
    /// </summary>
    public partial class OverrideDatasetParameterOperation
    {
        /// <summary>
        /// Gets and sets the property NewDefaultValues. 
        /// <para>
        /// The new default values for the parameter.
        /// </para>
        /// </summary>
        public NewDefaultValues NewDefaultValues { get; set; }

        /// <summary>
        /// Checks to see if the NewDefaultValues property is set.
        /// </summary>
        internal bool IsSetNewDefaultValues() => this.NewDefaultValues != null;

        /// <summary>
        /// Gets and sets the property NewParameterName. 
        /// <para>
        /// The new name for the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NewParameterName { get; set; }

        /// <summary>
        /// Checks to see if the NewParameterName property is set.
        /// </summary>
        internal bool IsSetNewParameterName() => this.NewParameterName != null;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter to be overridden with different values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;
    }
}

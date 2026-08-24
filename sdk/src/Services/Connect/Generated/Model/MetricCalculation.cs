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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the formula and component metrics that define a custom metric calculation.
    /// </summary>
    public partial class MetricCalculation
    {
        private string _calculation;
        private List<CalculationComponent> _calculationComponents = AWSConfigs.InitializeCollections ? new List<CalculationComponent>() : null;

        /// <summary>
        /// Gets and sets the property Calculation. 
        /// <para>
        /// The formula expression that defines how the metric is calculated. Uses component aliases
        /// (for example, <c>100 * SUM(M1) / SUM(M2)</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Calculation
        {
            get { return this._calculation; }
            set { this._calculation = value; }
        }

        // Check to see if Calculation property is set
        internal bool IsSetCalculation()
        {
            return this._calculation != null;
        }

        /// <summary>
        /// Gets and sets the property CalculationComponents. 
        /// <para>
        /// The list of component metrics referenced in the calculation formula. Each component
        /// has an alias used in the formula expression.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<CalculationComponent> CalculationComponents
        {
            get { return this._calculationComponents; }
            set { this._calculationComponents = value; }
        }

        // Check to see if CalculationComponents property is set
        internal bool IsSetCalculationComponents()
        {
            return this._calculationComponents != null && (this._calculationComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
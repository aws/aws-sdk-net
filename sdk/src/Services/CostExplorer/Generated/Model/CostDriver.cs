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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Represents factors that contribute to cost variations between the baseline and comparison
    /// time periods, including the type of driver, an identifier of the driver, and associated
    /// metrics.
    /// </summary>
    public partial class CostDriver
    {
        private Dictionary<string, ComparisonMetricValue> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, ComparisonMetricValue>() : null;
        private string _name;
        private string _type;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A mapping of metric names to their comparison values, measuring the impact of this
        /// cost driver.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComparisonMetricValue> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The specific identifier of the cost driver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The category or classification of the cost driver.
        /// </para>
        ///  
        /// <para>
        /// Values include: BUNDLED_DISCOUNT, CREDIT, OUT_OF_CYCLE_CHARGE, REFUND, RECURRING_RESERVATION_FEE,
        /// RESERVATION_USAGE, RI_VOLUME_DISCOUNT, SAVINGS_PLAN_USAGE, SAVINGS_PLAN_RECURRING_FEE,
        /// SUPPORT_FEE, TAX, UPFRONT_RESERVATION_FEE, USAGE_CHANGE, COMMITMENT
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
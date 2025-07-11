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
    /// The result that's associated with a time period.
    /// </summary>
    public partial class ResultByTime
    {
        private bool? _estimated;
        private List<Group> _groups = AWSConfigs.InitializeCollections ? new List<Group>() : null;
        private DateInterval _timePeriod;
        private Dictionary<string, MetricValue> _total = AWSConfigs.InitializeCollections ? new Dictionary<string, MetricValue>() : null;

        /// <summary>
        /// Gets and sets the property Estimated. 
        /// <para>
        /// Determines whether the result is estimated.
        /// </para>
        /// </summary>
        public bool? Estimated
        {
            get { return this._estimated; }
            set { this._estimated = value; }
        }

        // Check to see if Estimated property is set
        internal bool IsSetEstimated()
        {
            return this._estimated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The groups that this time period includes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Group> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period that the result covers.
        /// </para>
        /// </summary>
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total amount of cost or usage accrued during the time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MetricValue> Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total != null && (this._total.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
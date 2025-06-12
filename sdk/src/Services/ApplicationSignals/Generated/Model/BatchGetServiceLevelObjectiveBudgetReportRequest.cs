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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetServiceLevelObjectiveBudgetReport operation.
    /// Use this operation to retrieve one or more <i>service level objective (SLO) budget
    /// reports</i>.
    /// 
    ///  
    /// <para>
    /// An <i>error budget</i> is the amount of time or requests in an unhealthy state that
    /// your service can accumulate during an interval before your overall SLO budget health
    /// is breached and the SLO is considered to be unmet. For example, an SLO with a threshold
    /// of 99.95% and a monthly interval translates to an error budget of 21.9 minutes of
    /// downtime in a 30-day month.
    /// </para>
    ///  
    /// <para>
    /// Budget reports include a health indicator, the attainment value, and remaining budget.
    /// </para>
    ///  
    /// <para>
    /// For more information about SLO error budgets, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html#CloudWatch-ServiceLevelObjectives-concepts">
    /// SLO concepts</a>.
    /// </para>
    /// </summary>
    public partial class BatchGetServiceLevelObjectiveBudgetReportRequest : AmazonApplicationSignalsRequest
    {
        private List<string> _sloIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property SloIds. 
        /// <para>
        /// An array containing the IDs of the service level objectives that you want to include
        /// in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> SloIds
        {
            get { return this._sloIds; }
            set { this._sloIds = value; }
        }

        // Check to see if SloIds property is set
        internal bool IsSetSloIds()
        {
            return this._sloIds != null && (this._sloIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that you want the report to be for. It is expressed as the number
        /// of milliseconds since Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}
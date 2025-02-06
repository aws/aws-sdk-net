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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the settings used to enable point in time recovery.
    /// </summary>
    public partial class PointInTimeRecoverySpecification
    {
        private bool? _pointInTimeRecoveryEnabled;
        private int? _recoveryPeriodInDays;

        /// <summary>
        /// Gets and sets the property PointInTimeRecoveryEnabled. 
        /// <para>
        /// Indicates whether point in time recovery is enabled (true) or disabled (false) on
        /// the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PointInTimeRecoveryEnabled
        {
            get { return this._pointInTimeRecoveryEnabled; }
            set { this._pointInTimeRecoveryEnabled = value; }
        }

        // Check to see if PointInTimeRecoveryEnabled property is set
        internal bool IsSetPointInTimeRecoveryEnabled()
        {
            return this._pointInTimeRecoveryEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPeriodInDays. 
        /// <para>
        /// The number of preceding days for which continuous backups are taken and maintained.
        /// Your table data is only recoverable to any point-in-time from within the configured
        /// recovery period. This parameter is optional. If no value is provided, the value will
        /// default to 35.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=35)]
        public int? RecoveryPeriodInDays
        {
            get { return this._recoveryPeriodInDays; }
            set { this._recoveryPeriodInDays = value; }
        }

        // Check to see if RecoveryPeriodInDays property is set
        internal bool IsSetRecoveryPeriodInDays()
        {
            return this._recoveryPeriodInDays.HasValue; 
        }

    }
}
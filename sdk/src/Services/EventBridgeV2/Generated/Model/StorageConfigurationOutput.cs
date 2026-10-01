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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Event storage configuration of an event bus, as returned on reads.
    /// </summary>
    public partial class StorageConfigurationOutput
    {
        private int? _retentionPeriodInDays;
        private DateTime? _retentionWindowStartTime;

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays.
        /// </summary>
        [AWSProperty(Min=1, Max=365)]
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionWindowStartTime. 
        /// <para>
        /// The earliest point in time from which stored events are available. Events older than
        /// this have expired from retention.
        /// </para>
        /// </summary>
        public DateTime? RetentionWindowStartTime
        {
            get { return this._retentionWindowStartTime; }
            set { this._retentionWindowStartTime = value; }
        }

        // Check to see if RetentionWindowStartTime property is set
        internal bool IsSetRetentionWindowStartTime()
        {
            return this._retentionWindowStartTime.HasValue; 
        }

    }
}
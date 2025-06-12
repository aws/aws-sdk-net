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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Defines limits controlling whether an event triggers the destination, based on ingestion
    /// latency and the number of invocations per profile over specific time periods.
    /// </summary>
    public partial class EventTriggerLimits
    {
        private long? _eventExpiration;
        private List<Period> _periods = AWSConfigs.InitializeCollections ? new List<Period>() : null;

        /// <summary>
        /// Gets and sets the property EventExpiration. 
        /// <para>
        /// In milliseconds. Specifies that an event will only trigger the destination if it is
        /// processed within a certain latency period.
        /// </para>
        /// </summary>
        public long? EventExpiration
        {
            get { return this._eventExpiration; }
            set { this._eventExpiration = value; }
        }

        // Check to see if EventExpiration property is set
        internal bool IsSetEventExpiration()
        {
            return this._eventExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Periods. 
        /// <para>
        /// A list of time periods during which the limits apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<Period> Periods
        {
            get { return this._periods; }
            set { this._periods = value; }
        }

        // Check to see if Periods property is set
        internal bool IsSetPeriods()
        {
            return this._periods != null && (this._periods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
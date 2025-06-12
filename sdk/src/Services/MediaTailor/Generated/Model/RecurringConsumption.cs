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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The settings that determine how and when MediaTailor places prefetched ads into upcoming
    /// ad breaks for recurring prefetch scedules.
    /// </summary>
    public partial class RecurringConsumption
    {
        private List<AvailMatchingCriteria> _availMatchingCriteria = AWSConfigs.InitializeCollections ? new List<AvailMatchingCriteria>() : null;
        private int? _retrievedAdExpirationSeconds;

        /// <summary>
        /// Gets and sets the property AvailMatchingCriteria. 
        /// <para>
        /// The configuration for the dynamic variables that determine which ad breaks that MediaTailor
        /// inserts prefetched ads in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailMatchingCriteria> AvailMatchingCriteria
        {
            get { return this._availMatchingCriteria; }
            set { this._availMatchingCriteria = value; }
        }

        // Check to see if AvailMatchingCriteria property is set
        internal bool IsSetAvailMatchingCriteria()
        {
            return this._availMatchingCriteria != null && (this._availMatchingCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetrievedAdExpirationSeconds. 
        /// <para>
        /// The number of seconds that an ad is available for insertion after it was prefetched.
        /// </para>
        /// </summary>
        public int? RetrievedAdExpirationSeconds
        {
            get { return this._retrievedAdExpirationSeconds; }
            set { this._retrievedAdExpirationSeconds = value; }
        }

        // Check to see if RetrievedAdExpirationSeconds property is set
        internal bool IsSetRetrievedAdExpirationSeconds()
        {
            return this._retrievedAdExpirationSeconds.HasValue; 
        }

    }
}
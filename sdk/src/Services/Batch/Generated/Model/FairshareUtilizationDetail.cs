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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The fairshare utilization for a job queue, including the number of active shares and
    /// top capacity utilization.
    /// </summary>
    public partial class FairshareUtilizationDetail
    {
        private long? _activeShareCount;
        private List<FairshareCapacityUtilization> _topCapacityUtilization = AWSConfigs.InitializeCollections ? new List<FairshareCapacityUtilization>() : null;

        /// <summary>
        /// Gets and sets the property ActiveShareCount. 
        /// <para>
        /// The total number of active shares in the fairshare scheduling job queue that are currently
        /// utilizing capacity.
        /// </para>
        /// </summary>
        public long? ActiveShareCount
        {
            get { return this._activeShareCount; }
            set { this._activeShareCount = value; }
        }

        // Check to see if ActiveShareCount property is set
        internal bool IsSetActiveShareCount()
        {
            return this._activeShareCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopCapacityUtilization. 
        /// <para>
        /// A list of the top 20 shares with the highest capacity utilization, ordered by usage
        /// amount.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FairshareCapacityUtilization> TopCapacityUtilization
        {
            get { return this._topCapacityUtilization; }
            set { this._topCapacityUtilization = value; }
        }

        // Check to see if TopCapacityUtilization property is set
        internal bool IsSetTopCapacityUtilization()
        {
            return this._topCapacityUtilization != null && (this._topCapacityUtilization.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
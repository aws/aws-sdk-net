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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Status information about the aggregated associations.
    /// </summary>
    public partial class InstanceAggregatedAssociationOverview
    {
        private string _detailedStatus;
        private Dictionary<string, int> _instanceAssociationStatusAggregatedCount = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property DetailedStatus. 
        /// <para>
        /// Detailed status information about the aggregated associations.
        /// </para>
        /// </summary>
        public string DetailedStatus
        {
            get { return this._detailedStatus; }
            set { this._detailedStatus = value; }
        }

        // Check to see if DetailedStatus property is set
        internal bool IsSetDetailedStatus()
        {
            return this._detailedStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceAssociationStatusAggregatedCount. 
        /// <para>
        /// The number of associations for the instance(s).
        /// </para>
        /// </summary>
        public Dictionary<string, int> InstanceAssociationStatusAggregatedCount
        {
            get { return this._instanceAssociationStatusAggregatedCount; }
            set { this._instanceAssociationStatusAggregatedCount = value; }
        }

        // Check to see if InstanceAssociationStatusAggregatedCount property is set
        internal bool IsSetInstanceAssociationStatusAggregatedCount()
        {
            return this._instanceAssociationStatusAggregatedCount != null && this._instanceAssociationStatusAggregatedCount.Count > 0; 
        }

    }
}
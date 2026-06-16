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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Capacity details for an OpenSearch Serverless collection group, including the current
    /// capacity and autoscaling status.
    /// </summary>
    public partial class CapacityDetails
    {
        private AutoscalingStatus _autoscalingStatus;
        private float? _capacityInOcu;

        /// <summary>
        /// Gets and sets the property AutoscalingStatus. 
        /// <para>
        /// The current autoscaling status for the collection group.
        /// </para>
        /// </summary>
        public AutoscalingStatus AutoscalingStatus
        {
            get { return this._autoscalingStatus; }
            set { this._autoscalingStatus = value; }
        }

        // Check to see if AutoscalingStatus property is set
        internal bool IsSetAutoscalingStatus()
        {
            return this._autoscalingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityInOcu. 
        /// <para>
        /// The current capacity in OpenSearch Compute Units (OCUs).
        /// </para>
        /// </summary>
        public float? CapacityInOcu
        {
            get { return this._capacityInOcu; }
            set { this._capacityInOcu = value; }
        }

        // Check to see if CapacityInOcu property is set
        internal bool IsSetCapacityInOcu()
        {
            return this._capacityInOcu.HasValue; 
        }

    }
}
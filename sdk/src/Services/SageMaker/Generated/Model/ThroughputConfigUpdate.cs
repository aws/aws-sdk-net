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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The new throughput configuration for the feature group. You can switch between on-demand
    /// and provisioned modes or update the read / write capacity of provisioned feature groups.
    /// You can switch a feature group to on-demand only once in a 24 hour period.
    /// </summary>
    public partial class ThroughputConfigUpdate
    {
        private int? _provisionedReadCapacityUnits;
        private int? _provisionedWriteCapacityUnits;
        private ThroughputMode _throughputMode;

        /// <summary>
        /// Gets and sets the property ProvisionedReadCapacityUnits. 
        /// <para>
        /// For provisioned feature groups with online store enabled, this indicates the read
        /// throughput you are billed for and can consume without throttling. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? ProvisionedReadCapacityUnits
        {
            get { return this._provisionedReadCapacityUnits; }
            set { this._provisionedReadCapacityUnits = value; }
        }

        // Check to see if ProvisionedReadCapacityUnits property is set
        internal bool IsSetProvisionedReadCapacityUnits()
        {
            return this._provisionedReadCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedWriteCapacityUnits. 
        /// <para>
        /// For provisioned feature groups, this indicates the write throughput you are billed
        /// for and can consume without throttling. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public int? ProvisionedWriteCapacityUnits
        {
            get { return this._provisionedWriteCapacityUnits; }
            set { this._provisionedWriteCapacityUnits = value; }
        }

        // Check to see if ProvisionedWriteCapacityUnits property is set
        internal bool IsSetProvisionedWriteCapacityUnits()
        {
            return this._provisionedWriteCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// Target throughput mode of the feature group. Throughput update is an asynchronous
        /// operation, and the outcome should be monitored by polling <c>LastUpdateStatus</c>
        /// field in <c>DescribeFeatureGroup</c> response. You cannot update a feature group's
        /// throughput while another update is in progress. 
        /// </para>
        /// </summary>
        public ThroughputMode ThroughputMode
        {
            get { return this._throughputMode; }
            set { this._throughputMode = value; }
        }

        // Check to see if ThroughputMode property is set
        internal bool IsSetThroughputMode()
        {
            return this._throughputMode != null;
        }

    }
}
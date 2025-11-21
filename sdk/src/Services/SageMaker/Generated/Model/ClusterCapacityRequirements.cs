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
    /// Defines the instance capacity requirements for an instance group, including configurations
    /// for both Spot and On-Demand capacity types.
    /// </summary>
    public partial class ClusterCapacityRequirements
    {
        private ClusterOnDemandOptions _onDemand;
        private ClusterSpotOptions _spot;

        /// <summary>
        /// Gets and sets the property OnDemand. 
        /// <para>
        /// Configuration options specific to On-Demand instances.
        /// </para>
        /// </summary>
        public ClusterOnDemandOptions OnDemand
        {
            get { return this._onDemand; }
            set { this._onDemand = value; }
        }

        // Check to see if OnDemand property is set
        internal bool IsSetOnDemand()
        {
            return this._onDemand != null;
        }

        /// <summary>
        /// Gets and sets the property Spot. 
        /// <para>
        /// Configuration options specific to Spot instances.
        /// </para>
        /// </summary>
        public ClusterSpotOptions Spot
        {
            get { return this._spot; }
            set { this._spot = value; }
        }

        // Check to see if Spot property is set
        internal bool IsSetSpot()
        {
            return this._spot != null;
        }

    }
}
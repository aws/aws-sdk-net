/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RequestSpotFleet operation.
    /// Creates a Spot fleet request.
    /// 
    ///  
    /// <para>
    /// You can submit a single request that specifies multiple instance types, each with
    /// its own instance weighting that reflects its value to your application workload. Amazon
    /// EC2 computes the bid price for each launch specification and requests Spot Instances
    /// in the Spot pool where the price per unit is the lowest. For more information, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet.html">Spot
    /// Fleets</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RequestSpotFleetRequest : AmazonEC2Request
    {
        private SpotFleetRequestConfigData _spotFleetRequestConfig;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestConfig. 
        /// <para>
        /// The configuration for the Spot fleet request.
        /// </para>
        /// </summary>
        public SpotFleetRequestConfigData SpotFleetRequestConfig
        {
            get { return this._spotFleetRequestConfig; }
            set { this._spotFleetRequestConfig = value; }
        }

        // Check to see if SpotFleetRequestConfig property is set
        internal bool IsSetSpotFleetRequestConfig()
        {
            return this._spotFleetRequestConfig != null;
        }

    }
}
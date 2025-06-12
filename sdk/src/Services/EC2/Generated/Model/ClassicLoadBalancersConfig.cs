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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Classic Load Balancers to attach to a Spot Fleet. Spot Fleet registers
    /// the running Spot Instances with these Classic Load Balancers.
    /// </summary>
    public partial class ClassicLoadBalancersConfig
    {
        private List<ClassicLoadBalancer> _classicLoadBalancers = AWSConfigs.InitializeCollections ? new List<ClassicLoadBalancer>() : null;

        /// <summary>
        /// Gets and sets the property ClassicLoadBalancers. 
        /// <para>
        /// One or more Classic Load Balancers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<ClassicLoadBalancer> ClassicLoadBalancers
        {
            get { return this._classicLoadBalancers; }
            set { this._classicLoadBalancers = value; }
        }

        // Check to see if ClassicLoadBalancers property is set
        internal bool IsSetClassicLoadBalancers()
        {
            return this._classicLoadBalancers != null && (this._classicLoadBalancers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
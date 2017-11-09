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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Describes the Classic Load Balancers to attach to a Spot fleet. Spot fleet registers
    /// the running Spot instances with these Classic Load Balancers.
    /// </summary>
    public partial class ClassicLoadBalancersConfig
    {
        private List<ClassicLoadBalancer> _classicLoadBalancers = new List<ClassicLoadBalancer>();

        /// <summary>
        /// Gets and sets the property ClassicLoadBalancers. 
        /// <para>
        /// One or more Classic Load Balancers.
        /// </para>
        /// </summary>
        public List<ClassicLoadBalancer> ClassicLoadBalancers
        {
            get { return this._classicLoadBalancers; }
            set { this._classicLoadBalancers = value; }
        }

        // Check to see if ClassicLoadBalancers property is set
        internal bool IsSetClassicLoadBalancers()
        {
            return this._classicLoadBalancers != null && this._classicLoadBalancers.Count > 0; 
        }

    }
}
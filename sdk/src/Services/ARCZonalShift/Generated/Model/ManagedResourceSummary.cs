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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// A complex structure for a managed resource in an account.
    /// 
    ///  
    /// <para>
    /// A managed resource is a Network Load Balancer or Application Load Balancer that has
    /// been registered with Route 53 ARC by Elastic Load Balancing. You can start a zonal
    /// shift in Route 53 ARC for a managed resource to temporarily move traffic for the resource
    /// away from an Availability Zone in an AWS Region.
    /// </para>
    ///  <note> 
    /// <para>
    /// At this time, you can only start a zonal shift for Network Load Balancers and Application
    /// Load Balancers with cross-zone load balancing turned off.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ManagedResourceSummary
    {
        private string _arn;
        private List<string> _availabilityZones = new List<string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones that a resource is deployed in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
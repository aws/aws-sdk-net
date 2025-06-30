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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the StartZonalShift operation.
    /// You start a zonal shift to temporarily move load balancer traffic away from an Availability
    /// Zone in an Amazon Web Services Region, to help your application recover immediately,
    /// for example, from a developer's bad code deployment or from an Amazon Web Services
    /// infrastructure failure in a single Availability Zone. You can start a zonal shift
    /// in ARC only for managed resources in your Amazon Web Services account in an Amazon
    /// Web Services Region. Resources are automatically registered with ARC by Amazon Web
    /// Services services.
    /// 
    ///  
    /// <para>
    /// Amazon Application Recovery Controller currently supports enabling the following resources
    /// for zonal shift and zonal autoshift:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.ec2-auto-scaling-groups.html">Amazon
    /// EC2 Auto Scaling groups</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.eks.html">Amazon
    /// Elastic Kubernetes Service</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.app-load-balancers.html">Application
    /// Load Balancer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.network-load-balancers.html">Network
    /// Load Balancer</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When you start a zonal shift, traffic for the resource is no longer routed to the
    /// Availability Zone. The zonal shift is created immediately in ARC. However, it can
    /// take a short time, typically up to a few minutes, for existing, in-progress connections
    /// in the Availability Zone to complete.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.html">Zonal
    /// shift</a> in the Amazon Application Recovery Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class StartZonalShiftRequest : AmazonARCZonalShiftRequest
    {
        private string _awayFrom;
        private string _comment;
        private string _expiresIn;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic is moved away from
        /// for a resource when you start a zonal shift. Until the zonal shift expires or you
        /// cancel it, traffic for the resource is instead moved to other Availability Zones in
        /// the Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public string AwayFrom
        {
            get { return this._awayFrom; }
            set { this._awayFrom = value; }
        }

        // Check to see if AwayFrom property is set
        internal bool IsSetAwayFrom()
        {
            return this._awayFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment that you enter about the zonal shift. Only the latest comment is retained;
        /// no comment history is maintained. A new comment overwrites any existing comment string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The length of time that you want a zonal shift to be active, which ARC converts to
        /// an expiry time (expiration time). Zonal shifts are temporary. You can set a zonal
        /// shift to be active initially for up to three days (72 hours).
        /// </para>
        ///  
        /// <para>
        /// If you want to still keep traffic away from an Availability Zone, you can update the
        /// zonal shift and set a new expiration. You can also cancel a zonal shift, before it
        /// expires, for example, if you're ready to restore traffic to the Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// To set a length of time for a zonal shift to be active, specify a whole number, and
        /// then one of the following, with no space:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>A lowercase letter m:</b> To specify that the value is in minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A lowercase letter h:</b> To specify that the value is in hours.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example: <c>20h</c> means the zonal shift expires in 20 hours. <c>120m</c> means
        /// the zonal shift expires in 120 minutes (2 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5)]
        public string ExpiresIn
        {
            get { return this._expiresIn; }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that Amazon Web Services shifts traffic for. The identifier
        /// is the Amazon Resource Name (ARN) for the resource.
        /// </para>
        ///  
        /// <para>
        /// Amazon Application Recovery Controller currently supports enabling the following resources
        /// for zonal shift and zonal autoshift:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.ec2-auto-scaling-groups.html">Amazon
        /// EC2 Auto Scaling groups</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.eks.html">Amazon
        /// Elastic Kubernetes Service</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.app-load-balancers.html">Application
        /// Load Balancer</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.network-load-balancers.html">Network
        /// Load Balancer</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}
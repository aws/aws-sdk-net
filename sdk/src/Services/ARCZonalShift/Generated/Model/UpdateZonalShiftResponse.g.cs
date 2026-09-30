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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the UpdateZonalShift operation.
    /// </summary>
    public partial class UpdateZonalShiftResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic is moved away from
        /// for a resource when you start a zonal shift. Until the zonal shift expires or you
        /// cancel it, traffic for the resource is instead moved to other Availability Zones in
        /// the Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public string AwayFrom { get; set; }

        /// <summary>
        /// Checks to see if the AwayFrom property is set.
        /// </summary>
        internal bool IsSetAwayFrom() => this.AwayFrom != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment that you enter about the zonal shift. Only the latest comment is retained;
        /// no comment history is maintained. A new comment overwrites any existing comment string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The expiry time (expiration time) for a customer-initiated zonal shift. A zonal shift
        /// is temporary and must be set to expire when you start the zonal shift. You can initially
        /// set a zonal shift to expire in a maximum of three days (72 hours). However, you can
        /// update a zonal shift to set a new expiration at any time. 
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, you specify how long you want it to be active, which
        /// ARC converts to an expiry time (expiration time). You can cancel a zonal shift when
        /// you're ready to restore traffic to the Availability Zone, or just wait for it to expire.
        /// Or you can update the zonal shift to specify another length of time to expire in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime.HasValue;

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
        [AWSProperty(Required = true, Min = 8, Max = 1024)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (UTC) when the zonal shift starts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status for a zonal shift.
        /// </para>
        ///  
        /// <para>
        /// The <c>Status</c> for a zonal shift can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE:</b> The zonal shift has been started and is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EXPIRED:</b> The zonal shift has expired (the expiry time was exceeded).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELED:</b> The zonal shift was canceled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ZonalShiftStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ZonalShiftId. 
        /// <para>
        /// The identifier of a zonal shift.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 36)]
        public string ZonalShiftId { get; set; }

        /// <summary>
        /// Checks to see if the ZonalShiftId property is set.
        /// </summary>
        internal bool IsSetZonalShiftId() => this.ZonalShiftId != null;
    }
}

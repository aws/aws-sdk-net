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
    /// A complex structure that lists the zonal shifts for a managed resource and their statuses
    /// for the resource.
    /// </summary>
    public partial class ZonalShiftInResource
    {
        /// <summary>
        /// Gets and sets the property AppliedStatus. 
        /// <para>
        /// The <c>appliedStatus</c> field specifies which application traffic shift is in effect
        /// for a resource when there is more than one active traffic shift. There can be more
        /// than one application traffic shift in progress at the same time - that is, practice
        /// run zonal shifts, customer-initiated zonal shifts, or an autoshift. The <c>appliedStatus</c>
        /// field for a shift that is in progress for a resource can have one of two values: <c>APPLIED</c>
        /// or <c>NOT_APPLIED</c>. The zonal shift or autoshift that is currently in effect for
        /// the resource has an <c>appliedStatus</c> set to <c>APPLIED</c>.
        /// </para>
        ///  
        /// <para>
        /// The overall principle for precedence is that zonal shifts that you start as a customer
        /// take precedence autoshifts, which take precedence over practice runs. That is, customer-initiated
        /// zonal shifts &gt; autoshifts &gt; practice run zonal shifts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html">How
        /// zonal autoshift and practice runs work</a> in the Amazon Application Recovery Controller
        /// Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AppliedStatus AppliedStatus { get; set; }

        /// <summary>
        /// Checks to see if the AppliedStatus property is set.
        /// </summary>
        internal bool IsSetAppliedStatus() => this.AppliedStatus != null;

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
        /// A comment that you enter for a customer-initiated zonal shift. Only the latest comment
        /// is retained; no comment history is maintained. That is, a new comment overwrites any
        /// existing comment string.
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
        /// Gets and sets the property PracticeRunOutcome. 
        /// <para>
        /// The outcome, or end state, returned for a practice run. The following values can be
        /// returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PENDING:</b> Outcome value when a practice run is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCEEDED:</b> Outcome value when the outcome alarm specified for the practice
        /// run configuration does not go into an <c>ALARM</c> state during the practice run,
        /// and the practice run was not interrupted before it completed the expected 30 minute
        /// zonal shift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERRUPTED:</b> Outcome value when the practice run was stopped before the expected
        /// 30 minute zonal shift duration, or there was another problem with the practice run
        /// that created an inconclusive outcome.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED:</b> Outcome value when the outcome alarm specified for the practice run
        /// configuration goes into an <c>ALARM</c> state during the practice run, and the practice
        /// run was not interrupted before it completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CAPACITY_CHECK_FAILED:</b> The check for balanced capacity across Availability
        /// Zones for your load balancing and Auto Scaling group resources failed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about practice run outcomes, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.configure.html">
        /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
        /// Controller Developer Guide.
        /// </para>
        /// </summary>
        public PracticeRunOutcome PracticeRunOutcome { get; set; }

        /// <summary>
        /// Checks to see if the PracticeRunOutcome property is set.
        /// </summary>
        internal bool IsSetPracticeRunOutcome() => this.PracticeRunOutcome != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource to include in a zonal shift. The identifier is the
        /// Amazon Resource Name (ARN) for the resource.
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
        /// Gets and sets the property ShiftType. 
        /// <para>
        /// Defines the zonal shift type.
        /// </para>
        /// </summary>
        public ShiftType ShiftType { get; set; }

        /// <summary>
        /// Checks to see if the ShiftType property is set.
        /// </summary>
        internal bool IsSetShiftType() => this.ShiftType != null;

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

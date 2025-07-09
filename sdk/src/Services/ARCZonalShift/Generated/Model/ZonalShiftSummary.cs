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
    /// Lists information about zonal shifts in Amazon Application Recovery Controller, including
    /// zonal shifts that you start yourself and zonal shifts that ARC starts on your behalf
    /// for practice runs with zonal autoshift.
    /// 
    ///  
    /// <para>
    /// Zonal shifts are temporary, including customer-initiated zonal shifts and the zonal
    /// autoshift practice run zonal shifts that ARC starts weekly, on your behalf. A zonal
    /// shift that a customer starts can be active for up to three days (72 hours). A practice
    /// run zonal shift has a 30 minute duration.
    /// </para>
    /// </summary>
    public partial class ZonalShiftSummary
    {
        private string _awayFrom;
        private string _comment;
        private DateTime? _expiryTime;
        private PracticeRunOutcome _practiceRunOutcome;
        private string _resourceIdentifier;
        private ShiftType _shiftType;
        private DateTime? _startTime;
        private ZonalShiftStatus _status;
        private string _zonalShiftId;

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
        /// no comment history is maintained. That is, a new comment overwrites any existing comment
        /// string.
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
        [AWSProperty(Required=true)]
        public DateTime? ExpiryTime
        {
            get { return this._expiryTime; }
            set { this._expiryTime = value; }
        }

        // Check to see if ExpiryTime property is set
        internal bool IsSetExpiryTime()
        {
            return this._expiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PracticeRunOutcome. 
        /// <para>
        /// The outcome, or end state, of a practice run. The following values can be returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PENDING:</b> Outcome value when the practice run is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCEEDED:</b> Outcome value when the outcome alarm specified for the practice
        /// run configuration does not go into an <c>ALARM</c> state during the practice run,
        /// and the practice run was not interrupted before it completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERRUPTED:</b> Outcome value when the practice run did not run for the expected
        /// 30 minutes or there was another problem with the practice run that created an inconclusive
        /// outcome.
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
        public PracticeRunOutcome PracticeRunOutcome
        {
            get { return this._practiceRunOutcome; }
            set { this._practiceRunOutcome = value; }
        }

        // Check to see if PracticeRunOutcome property is set
        internal bool IsSetPracticeRunOutcome()
        {
            return this._practiceRunOutcome != null;
        }

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
        /// Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-shift.resource-types.network-load-balancers.html">Network
        /// Load Balancers</a> 
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

        /// <summary>
        /// Gets and sets the property ShiftType. 
        /// <para>
        /// Defines the zonal shift type.
        /// </para>
        /// </summary>
        public ShiftType ShiftType
        {
            get { return this._shiftType; }
            set { this._shiftType = value; }
        }

        // Check to see if ShiftType property is set
        internal bool IsSetShiftType()
        {
            return this._shiftType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (UTC) when the zonal shift starts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

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
        [AWSProperty(Required=true)]
        public ZonalShiftStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalShiftId. 
        /// <para>
        /// The identifier of a zonal shift.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=36)]
        public string ZonalShiftId
        {
            get { return this._zonalShiftId; }
            set { this._zonalShiftId = value; }
        }

        // Check to see if ZonalShiftId property is set
        internal bool IsSetZonalShiftId()
        {
            return this._zonalShiftId != null;
        }

    }
}
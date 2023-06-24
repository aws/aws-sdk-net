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
    /// This is the response object from the CancelZonalShift operation.
    /// </summary>
    public partial class CancelZonalShiftResponse : AmazonWebServiceResponse
    {
        private string _awayFrom;
        private string _comment;
        private DateTime? _expiryTime;
        private string _resourceIdentifier;
        private DateTime? _startTime;
        private ZonalShiftStatus _status;
        private string _zonalShiftId;

        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone that traffic is moved away from for a resource when you start
        /// a zonal shift. Until the zonal shift expires or you cancel it, traffic for the resource
        /// is instead moved to other Availability Zones in the AWS Region.
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
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// The expiry time (expiration time) for the zonal shift. A zonal shift is temporary
        /// and must be set to expire when you start the zonal shift. You can initially set a
        /// zonal shift to expire in a maximum of three days (72 hours). However, you can update
        /// a zonal shift to set a new expiration at any time. 
        /// </para>
        ///  
        /// <para>
        /// When you start a zonal shift, you specify how long you want it to be active, which
        /// Route 53 ARC converts to an expiry time (expiration time). You can cancel a zonal
        /// shift, for example, if you're ready to restore traffic to the Availability Zone. Or
        /// you can update the zonal shift to specify another length of time to expire in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExpiryTime
        {
            get { return this._expiryTime.GetValueOrDefault(); }
            set { this._expiryTime = value; }
        }

        // Check to see if ExpiryTime property is set
        internal bool IsSetExpiryTime()
        {
            return this._expiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource to include in a zonal shift. The identifier is the
        /// Amazon Resource Name (ARN) for the resource.
        /// </para>
        ///  
        /// <para>
        /// At this time, you can only start a zonal shift for Network Load Balancers and Application
        /// Load Balancers with cross-zone load balancing turned off.
        /// </para>
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (UTC) when the zonal shift is started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The <code>Status</code> for a zonal shift can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVE:</b> The zonal shift is started and active.
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
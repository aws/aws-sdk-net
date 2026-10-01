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
    /// This is the response object from the CancelPracticeRun operation.
    /// </summary>
    public partial class CancelPracticeRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic was moved away from
        /// for a resource that you specified for the practice run.
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
        /// The initial comment that you entered about the practice run. Be aware that this comment
        /// can be overwritten by Amazon Web Services if the automatic check for balanced capacity
        /// fails. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.capacity-check.html">
        /// Capacity checks for practice runs</a> in the Amazon Application Recovery Controller
        /// Developer Guide. 
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
        /// The expiry time (expiration time) for an on-demand practice run zonal shift is 30
        /// minutes from the time when you start the practice run, unless you cancel it before
        /// that time. However, be aware that the <c>expiryTime</c> field for practice run zonal
        /// shifts always has a value of 1 minute. 
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
        /// The identifier for the resource that you canceled a practice run zonal shift for.
        /// The identifier is the Amazon Resource Name (ARN) for the resource.
        /// </para>
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
        /// A status for the practice run that you canceled (expected status is <b>CANCELED</b>).
        /// </para>
        ///  
        /// <para>
        /// The <c>Status</c> for a practice run zonal shift can have one of the following values:
        /// </para>
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
        /// The identifier of the practice run zonal shift in Amazon Application Recovery Controller
        /// that was canceled.
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

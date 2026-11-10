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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceEventWindow operation. Creates an
    /// event window in which scheduled events for the associated Amazon EC2 instances can
    /// run. <para> You can define either a set of time ranges or a cron expression when creating
    /// the event window, but not both. All event window times are in UTC. </para> <para>
    /// You can create up to 200 event windows per Amazon Web Services Region. </para> <para>
    /// When you create the event window, targets (instance IDs, Dedicated Host IDs, or tags)
    /// are not yet associated with it. To ensure that the event window can be used, you must
    /// associate one or more targets with it by using the <a>AssociateInstanceEventWindow</a>
    /// API. </para> <important> <para> Event windows are applicable only for scheduled events
    /// that stop, reboot, or terminate instances. </para> <para> Event windows are <i>not</i>
    /// applicable for: </para> <ul> <li> <para> Expedited scheduled events and network maintenance
    /// events. </para> </li> <li> <para> Unscheduled maintenance such as AutoRecovery and
    /// unplanned reboots. </para> </li> </ul> </important> <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/event-windows.html">Define
    /// event windows for scheduled events</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class CreateInstanceEventWindowRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// The cron expression for the event window, for example, <c>* 0-4,20-23 * * 1,5</c>.
        /// If you specify a cron expression, you can't specify a time range.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only hour and day of the week values are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For day of the week values, you can specify either integers <c>0</c> through <c>6</c>,
        /// or alternative single values <c>SUN</c> through <c>SAT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The minute, month, and year must be specified by <c>*</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The hour value must be one or a multiple range, for example, <c>0-4</c> or <c>0-4,20-23</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each hour range must be >= 2 hours, for example, <c>0-2</c> or <c>20-23</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The event window must be >= 4 hours. The combined total time ranges in the event window
        /// must be >= 4 hours.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about cron expressions, see <a href="https://en.wikipedia.org/wiki/Cron">cron</a>
        /// on the <i>Wikipedia website</i>.
        /// </para>
        /// </summary>
        public string CronExpression { get; set; }

        /// <summary>
        /// Checks to see if the CronExpression property is set.
        /// </summary>
        internal bool IsSetCronExpression() => this.CronExpression != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event window.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the event window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// The time range for the event window. If you specify a time range, you can't specify
        /// a cron expression.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceEventWindowTimeRangeRequest> TimeRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceEventWindowTimeRangeRequest>() : null;

        /// <summary>
        /// Checks to see if the TimeRanges property is set.
        /// </summary>
        internal bool IsSetTimeRanges() => this.TimeRanges != null && (this.TimeRanges.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

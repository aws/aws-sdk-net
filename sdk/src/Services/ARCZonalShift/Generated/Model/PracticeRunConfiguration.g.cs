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
    /// A practice run configuration for a resource includes the Amazon CloudWatch alarms
    /// that you've specified for a practice run, as well as any blocked dates or blocked
    /// windows for the practice run. When a resource has a practice run configuration, ARC
    /// shifts traffic for the resource weekly for practice runs.
    /// 
    ///  
    /// <para>
    /// Practice runs are required for zonal autoshift. The zonal shifts that ARC starts for
    /// practice runs help you to ensure that shifting away traffic from an Availability Zone
    /// during an autoshift is safe for your application.
    /// </para>
    ///  
    /// <para>
    /// You can update or delete a practice run configuration. Before you delete a practice
    /// run configuration, you must disable zonal autoshift for the resource. A practice run
    /// configuration is required when zonal autoshift is enabled.
    /// </para>
    /// </summary>
    public partial class PracticeRunConfiguration
    {
        /// <summary>
        /// Gets and sets the property AllowedWindows. 
        /// <para>
        /// An array of one or more windows of days and times that you can allow ARC to start
        /// practice runs for a resource.
        /// </para>
        ///  
        /// <para>
        /// For example, say you want to allow practice runs only on Wednesdays and Fridays from
        /// noon to 5 p.m. For this scenario, you could set the following recurring days and times
        /// as allowed windows, for example: <c>Wed-12:00-Wed:17:00 Fri-12:00-Fri:17:00</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>allowedWindows</c> have to start and end on the same day. Windows that span
        /// multiple days aren't supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<string> AllowedWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedWindows property is set.
        /// </summary>
        internal bool IsSetAllowedWindows() => this.AllowedWindows != null && (this.AllowedWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockedDates. 
        /// <para>
        /// An array of one or more dates that you can specify when Amazon Web Services does not
        /// start practice runs for a resource.
        /// </para>
        ///  
        /// <para>
        /// Specify blocked dates, in UTC, in the format <c>YYYY-MM-DD</c>, separated by spaces.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<string> BlockedDates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BlockedDates property is set.
        /// </summary>
        internal bool IsSetBlockedDates() => this.BlockedDates != null && (this.BlockedDates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockedWindows. 
        /// <para>
        /// An array of one or more windows of days and times that you can block ARC from starting
        /// practice runs for a resource.
        /// </para>
        ///  
        /// <para>
        /// Specify the blocked windows in UTC, using the format <c>DAY:HH:MM-DAY:HH:MM</c>, separated
        /// by spaces. For example, <c>MON:18:30-MON:19:30 TUE:18:30-TUE:19:30</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>blockedWindows</c> have to start and end on the same day. Windows that span
        /// multiple days aren't supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public List<string> BlockedWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BlockedWindows property is set.
        /// </summary>
        internal bool IsSetBlockedWindows() => this.BlockedWindows != null && (this.BlockedWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockingAlarms. 
        /// <para>
        ///  <i>Blocking alarms</i> for practice runs are optional alarms that you can specify
        /// that block practice runs when one or more of the alarms is in an <c>ALARM</c> state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ControlCondition> BlockingAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;

        /// <summary>
        /// Checks to see if the BlockingAlarms property is set.
        /// </summary>
        internal bool IsSetBlockingAlarms() => this.BlockingAlarms != null && (this.BlockingAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutcomeAlarms. 
        /// <para>
        ///  <i>Outcome alarms</i> for practice runs are alarms that you specify that end a practice
        /// run when one or more of the alarms is in an <c>ALARM</c> state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ControlCondition> OutcomeAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;

        /// <summary>
        /// Checks to see if the OutcomeAlarms property is set.
        /// </summary>
        internal bool IsSetOutcomeAlarms() => this.OutcomeAlarms != null && (this.OutcomeAlarms.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

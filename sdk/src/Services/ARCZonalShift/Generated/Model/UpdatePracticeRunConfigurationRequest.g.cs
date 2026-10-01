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
    /// Container for the parameters to the UpdatePracticeRunConfiguration operation. Update
    /// a practice run configuration to change one or more of the following: add, change,
    /// or remove the blocking alarm; change the outcome alarm; or add, change, or remove
    /// blocking dates or time windows.
    /// </summary>
    public partial class UpdatePracticeRunConfigurationRequest : AmazonARCZonalShiftRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedWindows. 
        /// <para>
        /// Add, change, or remove windows of days and times for when you can, optionally, allow
        /// ARC to start a practice run for a resource.
        /// </para>
        ///  
        /// <para>
        /// The format for allowed windows is: DAY:HH:SS-DAY:HH:SS. Keep in mind, when you specify
        /// dates, that dates and times for practice runs are in UTC. Also, be aware of potential
        /// time adjustments that might be required for daylight saving time differences. Separate
        /// multiple allowed windows with spaces.
        /// </para>
        ///  
        /// <para>
        /// For example, say you want to allow practice runs only on Wednesdays and Fridays from
        /// noon to 5 p.m. For this scenario, you could set the following recurring days and times
        /// as allowed windows, for example: <c>Wed-12:00-Wed:17:00 Fri-12:00-Fri:17:00</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>allowedWindows</c> have to start and end on the same day. Windows that span
        /// multiple days aren't supported.
        /// </para>
        ///  </important>
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
        /// Add, change, or remove blocked dates for a practice run in zonal autoshift.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can block practice runs for specific calendar dates. The format for
        /// blocked dates is: YYYY-MM-DD. Keep in mind, when you specify dates, that dates and
        /// times for practice runs are in UTC. Separate multiple blocked dates with spaces.
        /// </para>
        ///  
        /// <para>
        /// For example, if you have an application update scheduled to launch on May 1, 2024,
        /// and you don't want practice runs to shift traffic away at that time, you could set
        /// a blocked date for <c>2024-05-01</c>.
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
        /// Add, change, or remove windows of days and times for when you can, optionally, block
        /// ARC from starting a practice run for a resource.
        /// </para>
        ///  
        /// <para>
        /// The format for blocked windows is: DAY:HH:SS-DAY:HH:SS. Keep in mind, when you specify
        /// dates, that dates and times for practice runs are in UTC. Also, be aware of potential
        /// time adjustments that might be required for daylight saving time differences. Separate
        /// multiple blocked windows with spaces.
        /// </para>
        ///  
        /// <para>
        /// For example, say you run business report summaries three days a week. For this scenario,
        /// you might set the following recurring days and times as blocked windows, for example:
        /// <c>MON-20:30-21:30 WED-20:30-21:30 FRI-20:30-21:30</c>.
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
        /// Add, change, or remove the Amazon CloudWatch alarms that you optionally specify as
        /// the blocking alarms for practice runs.
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
        /// Specify one or more Amazon CloudWatch alarms as the outcome alarms for practice runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ControlCondition> OutcomeAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;

        /// <summary>
        /// Checks to see if the OutcomeAlarms property is set.
        /// </summary>
        internal bool IsSetOutcomeAlarms() => this.OutcomeAlarms != null && (this.OutcomeAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that you want to update the practice run configuration
        /// for. The identifier is the Amazon Resource Name (ARN) for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 1024)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}

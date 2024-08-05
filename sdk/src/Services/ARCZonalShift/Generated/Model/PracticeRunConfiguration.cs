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
    /// A practice run configuration for a resource includes the Amazon CloudWatch alarms
    /// that you've specified for a practice run, as well as any blocked dates or blocked
    /// windows for the practice run. When a resource has a practice run configuration, Route
    /// 53 ARC shifts traffic for the resource weekly for practice runs.
    /// 
    ///  
    /// <para>
    /// Practice runs are required for zonal autoshift. The zonal shifts that Route 53 ARC
    /// starts for practice runs help you to ensure that shifting away traffic from an Availability
    /// Zone during an autoshift is safe for your application.
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
        private List<string> _blockedDates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedWindows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ControlCondition> _blockingAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;
        private List<ControlCondition> _outcomeAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;

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
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<string> BlockedDates
        {
            get { return this._blockedDates; }
            set { this._blockedDates = value; }
        }

        // Check to see if BlockedDates property is set
        internal bool IsSetBlockedDates()
        {
            return this._blockedDates != null && (this._blockedDates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedWindows. 
        /// <para>
        /// An array of one or more windows of days and times that you can block Route 53 ARC
        /// from starting practice runs for a resource.
        /// </para>
        ///  
        /// <para>
        /// Specify the blocked windows in UTC, using the format <c>DAY:HH:MM-DAY:HH:MM</c>, separated
        /// by spaces. For example, <c>MON:18:30-MON:19:30 TUE:18:30-TUE:19:30</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<string> BlockedWindows
        {
            get { return this._blockedWindows; }
            set { this._blockedWindows = value; }
        }

        // Check to see if BlockedWindows property is set
        internal bool IsSetBlockedWindows()
        {
            return this._blockedWindows != null && (this._blockedWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockingAlarms. 
        /// <para>
        /// The <i>blocking alarm</i> for practice runs is an optional alarm that you can specify
        /// that blocks practice runs when the alarm is in an <c>ALARM</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<ControlCondition> BlockingAlarms
        {
            get { return this._blockingAlarms; }
            set { this._blockingAlarms = value; }
        }

        // Check to see if BlockingAlarms property is set
        internal bool IsSetBlockingAlarms()
        {
            return this._blockingAlarms != null && (this._blockingAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutcomeAlarms. 
        /// <para>
        /// The <i>outcome alarm</i> for practice runs is an alarm that you specify that ends
        /// a practice run when the alarm is in an <c>ALARM</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ControlCondition> OutcomeAlarms
        {
            get { return this._outcomeAlarms; }
            set { this._outcomeAlarms = value; }
        }

        // Check to see if OutcomeAlarms property is set
        internal bool IsSetOutcomeAlarms()
        {
            return this._outcomeAlarms != null && (this._outcomeAlarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
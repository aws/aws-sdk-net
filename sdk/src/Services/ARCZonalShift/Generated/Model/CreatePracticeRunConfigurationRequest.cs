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
    /// Container for the parameters to the CreatePracticeRunConfiguration operation.
    /// A practice run configuration for zonal autoshift is required when you enable zonal
    /// autoshift. A practice run configuration includes specifications for blocked dates
    /// and blocked time windows, and for Amazon CloudWatch alarms that you create to use
    /// with practice runs. The alarms that you specify are an <i>outcome alarm</i>, to monitor
    /// application health during practice runs and, optionally, a <i>blocking alarm</i>,
    /// to block practice runs from starting.
    /// 
    ///  
    /// <para>
    /// When a resource has a practice run configuration, Route 53 ARC starts zonal shifts
    /// for the resource weekly, to shift traffic for practice runs. Practice runs help you
    /// to ensure that shifting away traffic from an Availability Zone during an autoshift
    /// is safe for your application.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
    /// Considerations when you configure zonal autoshift</a> in the Amazon Route 53 Application
    /// Recovery Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class CreatePracticeRunConfigurationRequest : AmazonARCZonalShiftRequest
    {
        private List<string> _blockedDates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedWindows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ControlCondition> _blockingAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;
        private List<ControlCondition> _outcomeAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property BlockedDates. 
        /// <para>
        /// Optionally, you can block Route 53 ARC from starting practice runs for a resource
        /// on specific calendar dates.
        /// </para>
        ///  
        /// <para>
        /// The format for blocked dates is: YYYY-MM-DD. Keep in mind, when you specify dates,
        /// that dates and times for practice runs are in UTC. Separate multiple blocked dates
        /// with spaces.
        /// </para>
        ///  
        /// <para>
        /// For example, if you have an application update scheduled to launch on May 1, 2024,
        /// and you don't want practice runs to shift traffic away at that time, you could set
        /// a blocked date for <c>2024-05-01</c>.
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
        /// Optionally, you can block Route 53 ARC from starting practice runs for specific windows
        /// of days and times. 
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
        /// An Amazon CloudWatch alarm that you can specify for zonal autoshift practice runs.
        /// This alarm blocks Route 53 ARC from starting practice run zonal shifts, and ends a
        /// practice run that's in progress, when the alarm is in an <c>ALARM</c> state. 
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
        /// The <i>outcome alarm</i> for practice runs is a required Amazon CloudWatch alarm that
        /// you specify that ends a practice run when the alarm is in an <c>ALARM</c> state.
        /// </para>
        ///  
        /// <para>
        /// Configure the alarm to monitor the health of your application when traffic is shifted
        /// away from an Availability Zone during each weekly practice run. You should configure
        /// the alarm to go into an <c>ALARM</c> state if your application is impacted by the
        /// zonal shift, and you want to stop the zonal shift, to let traffic for the resource
        /// return to the Availability Zone.
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

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier of the resource that Amazon Web Services shifts traffic for with a
        /// practice run zonal shift. The identifier is the Amazon Resource Name (ARN) for the
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// At this time, supported resources are Network Load Balancers and Application Load
        /// Balancers with cross-zone load balancing turned off.
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

    }
}
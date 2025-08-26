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
    /// When a resource has a practice run configuration, ARC starts zonal shifts for the
    /// resource weekly, to shift traffic for practice runs. Practice runs help you to ensure
    /// that shifting away traffic from an Availability Zone during an autoshift is safe for
    /// your application.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
    /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
    /// Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class CreatePracticeRunConfigurationRequest : AmazonARCZonalShiftRequest
    {
        private List<string> _allowedWindows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedDates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedWindows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ControlCondition> _blockingAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;
        private List<ControlCondition> _outcomeAlarms = AWSConfigs.InitializeCollections ? new List<ControlCondition>() : null;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property AllowedWindows. 
        /// <para>
        /// Optionally, you can allow ARC to start practice runs for specific windows of days
        /// and times. 
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public List<string> AllowedWindows
        {
            get { return this._allowedWindows; }
            set { this._allowedWindows = value; }
        }

        // Check to see if AllowedWindows property is set
        internal bool IsSetAllowedWindows()
        {
            return this._allowedWindows != null && (this._allowedWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedDates. 
        /// <para>
        /// Optionally, you can block ARC from starting practice runs for a resource on specific
        /// calendar dates.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Optionally, you can block ARC from starting practice runs for specific windows of
        /// days and times. 
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
        /// you could set the following recurring days and times as blocked windows, for example:
        /// <c>Mon:00:00-Mon:10:00 Wed-20:30-Wed:21:30 Fri-20:30-Fri:21:30</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>blockedWindows</c> have to start and end on the same day. Windows that span
        /// multiple days aren't supported.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        ///  <i>Blocking alarms</i> for practice runs are optional alarms that you can specify
        /// that block practice runs when one or more of the alarms is in an <c>ALARM</c> state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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
        ///  <i>Outcome alarms</i> for practice runs are alarms that you specify that end a practice
        /// run when one or more of the alarms is in an <c>ALARM</c> state.
        /// </para>
        ///  
        /// <para>
        /// Configure one or more of these alarms to monitor the health of your application when
        /// traffic is shifted away from an Availability Zone during each practice run. You should
        /// configure these alarms to go into an <c>ALARM</c> state if you want to stop a zonal
        /// shift, to let traffic for the resource return to the original Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
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
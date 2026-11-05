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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Configure the <c>ZonalConfig</c> object if you want CodeDeploy to deploy your application
    /// to one <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html#concepts-availability-zones">Availability
    /// Zone</a> at a time, within an Amazon Web Services Region. By deploying to one Availability
    /// Zone at a time, you can expose your deployment to a progressively larger audience
    /// as confidence in the deployment's performance and viability grows. If you don't configure
    /// the <c>ZonalConfig</c> object, CodeDeploy deploys your application to a random selection
    /// of hosts across a Region.
    /// 
    ///  
    /// <para>
    /// For more information about the zonal configuration feature, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations-create.html#zonal-config">zonal
    /// configuration</a> in the <i>CodeDeploy User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ZonalConfig
    {
        /// <summary>
        /// Gets and sets the property FirstZoneMonitorDurationInSeconds. 
        /// <para>
        /// The period of time, in seconds, that CodeDeploy must wait after completing a deployment
        /// to the <i>first</i> Availability Zone. CodeDeploy will wait this amount of time before
        /// starting a deployment to the second Availability Zone. You might set this option if
        /// you want to allow extra bake time for the first Availability Zone. If you don't specify
        /// a value for <c>firstZoneMonitorDurationInSeconds</c>, then CodeDeploy uses the <c>monitorDurationInSeconds</c>
        /// value for the first Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// For more information about the zonal configuration feature, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations-create.html#zonal-config">zonal
        /// configuration</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public long? FirstZoneMonitorDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the FirstZoneMonitorDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetFirstZoneMonitorDurationInSeconds() => this.FirstZoneMonitorDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumHealthyHostsPerZone. 
        /// <para>
        /// The number or percentage of instances that must remain available per Availability
        /// Zone during a deployment. This option works in conjunction with the <c>MinimumHealthyHosts</c>
        /// option. For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/instances-health.html#minimum-healthy-hosts-az">About
        /// the minimum number of healthy hosts per Availability Zone</a> in the <i>CodeDeploy
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>minimumHealthyHostsPerZone</c> option, then CodeDeploy
        /// uses a default value of <c>0</c> percent.
        /// </para>
        ///  
        /// <para>
        /// For more information about the zonal configuration feature, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations-create.html#zonal-config">zonal
        /// configuration</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public MinimumHealthyHostsPerZone MinimumHealthyHostsPerZone { get; set; }

        /// <summary>
        /// Checks to see if the MinimumHealthyHostsPerZone property is set.
        /// </summary>
        internal bool IsSetMinimumHealthyHostsPerZone() => this.MinimumHealthyHostsPerZone != null;

        /// <summary>
        /// Gets and sets the property MonitorDurationInSeconds. 
        /// <para>
        /// The period of time, in seconds, that CodeDeploy must wait after completing a deployment
        /// to an Availability Zone. CodeDeploy will wait this amount of time before starting
        /// a deployment to the next Availability Zone. Consider adding a monitor duration to
        /// give the deployment some time to prove itself (or 'bake') in one Availability Zone
        /// before it is released in the next zone. If you don't specify a <c>monitorDurationInSeconds</c>,
        /// CodeDeploy starts deploying to the next Availability Zone immediately.
        /// </para>
        ///  
        /// <para>
        /// For more information about the zonal configuration feature, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations-create.html#zonal-config">zonal
        /// configuration</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public long? MonitorDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MonitorDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetMonitorDurationInSeconds() => this.MonitorDurationInSeconds.HasValue;
    }
}

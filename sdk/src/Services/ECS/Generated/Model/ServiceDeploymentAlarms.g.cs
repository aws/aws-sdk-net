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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The CloudWatch alarms used to determine a service deployment failed. 
    /// 
    ///  
    /// <para>
    /// Amazon ECS considers the service deployment as failed when any of the alarms move
    /// to the <c>ALARM</c> state. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-alarm-failure.html">How
    /// CloudWatch alarms detect Amazon ECS deployment failures</a> in the Amazon ECS Developer
    /// Guide.
    /// </para>
    /// </summary>
    public partial class ServiceDeploymentAlarms
    {
        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        /// The name of the CloudWatch alarms that determine when a service deployment failed.
        /// A "," separates the alarms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlarmNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AlarmNames property is set.
        /// </summary>
        internal bool IsSetAlarmNames() => this.AlarmNames != null && (this.AlarmNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the alarms check. Amazon ECS is not using alarms for service deployment
        /// failures when the status is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ServiceDeploymentRollbackMonitorsStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TriggeredAlarmNames. 
        /// <para>
        /// One or more CloudWatch alarm names that have been triggered during the service deployment.
        /// A "," separates the alarm names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TriggeredAlarmNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TriggeredAlarmNames property is set.
        /// </summary>
        internal bool IsSetTriggeredAlarmNames() => this.TriggeredAlarmNames != null && (this.TriggeredAlarmNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

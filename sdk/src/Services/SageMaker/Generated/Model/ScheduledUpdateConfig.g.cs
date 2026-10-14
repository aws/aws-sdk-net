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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration object of the schedule that SageMaker follows when updating the
    /// AMI.
    /// </summary>
    public partial class ScheduledUpdateConfig
    {
        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The configuration to use when updating the AMI versions.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfig property is set.
        /// </summary>
        internal bool IsSetDeploymentConfig() => this.DeploymentConfig != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression that specifies the schedule that SageMaker follows when updating
        /// the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;
    }
}

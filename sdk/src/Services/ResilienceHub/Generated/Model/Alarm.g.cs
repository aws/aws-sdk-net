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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Indicates the Amazon CloudWatch alarm detected while running an assessment.
    /// </summary>
    public partial class Alarm
    {
        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon CloudWatch alarm.
        /// </para>
        /// </summary>
        public string AlarmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlarmArn property is set.
        /// </summary>
        internal bool IsSetAlarmArn() => this.AlarmArn != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Indicates the source of the Amazon CloudWatch alarm. That is, it indicates if the
        /// alarm was created using Resilience Hub recommendation (<c>AwsResilienceHub</c>), or
        /// if you had created the alarm in Amazon CloudWatch (<c>Customer</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}

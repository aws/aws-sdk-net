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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Sets the time at which a schedule action runs once. This is a type of ScheduleActionStartConfiguration.
    /// </summary>
    public partial class FixedModeScheduleActionStartSettings
    {
        /// <summary>
        /// Gets and sets the property ScheduledAt. 
        /// <para>
        /// The UTC time at which the action runs. Specify the time in whole seconds. For the
        /// range of times that you can specify, see the AWS Elemental Inference User Guide. 
        /// </para>
        ///  
        /// <para>
        /// This time is approximate. The change can take a few minutes to take effect on the
        /// media that the feed is processing. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ScheduledAt { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAt property is set.
        /// </summary>
        internal bool IsSetScheduledAt() => this.ScheduledAt.HasValue;
    }
}

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

namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// Allows you to configure a time window during which EventBridge Scheduler invokes the
    /// schedule.
    /// </summary>
    public partial class FlexibleTimeWindow
    {
        /// <summary>
        /// Gets and sets the property MaximumWindowInMinutes. 
        /// <para>
        /// The maximum time window during which a schedule can be invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1440)]
        public int? MaximumWindowInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MaximumWindowInMinutes property is set.
        /// </summary>
        internal bool IsSetMaximumWindowInMinutes() => this.MaximumWindowInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Determines whether the schedule is invoked within a flexible time window.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlexibleTimeWindowMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}

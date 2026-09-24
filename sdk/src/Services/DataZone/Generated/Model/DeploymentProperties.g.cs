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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The deployment properties of the Amazon DataZone blueprint.
    /// </summary>
    public partial class DeploymentProperties
    {
        /// <summary>
        /// Gets and sets the property EndTimeoutMinutes. 
        /// <para>
        /// The end timeout of the environment blueprint deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 225)]
        public int? EndTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetEndTimeoutMinutes() => this.EndTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property StartTimeoutMinutes. 
        /// <para>
        /// The start timeout of the environment blueprint deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 225)]
        public int? StartTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetStartTimeoutMinutes() => this.StartTimeoutMinutes.HasValue;
    }
}

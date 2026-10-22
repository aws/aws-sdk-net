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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about an activity, such as an API call, that was observed for
    /// a signal.
    /// </summary>
    public partial class Activity
    {
        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// Contains information about the API call that was observed, when the activity type
        /// is <c>API_CALL</c>.
        /// </para>
        /// </summary>
        public ApiCall Api { get; set; }

        /// <summary>
        /// Checks to see if the Api property is set.
        /// </summary>
        internal bool IsSetApi() => this.Api != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the observed activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActivityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Tracks the history of next steps associated with the opportunity. This field captures
    /// the actions planned for the future and their timeline.
    /// </summary>
    public partial class ProfileNextStepsHistory
    {
        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// Indicates the date and time when a particular next step was recorded or planned. This
        /// helps in managing the timeline for the opportunity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Represents the details of the next step recorded, such as follow-up actions or decisions
        /// made. This field helps in tracking progress and ensuring alignment with project goals.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Defines a time range for spending limits, specifying when the limit is active.
    /// </summary>
    public partial class TimePeriod
    {
        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// The end date and time for the spending limit period, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Checks to see if the EndAt property is set.
        /// </summary>
        internal bool IsSetEndAt() => this.EndAt.HasValue;

        /// <summary>
        /// Gets and sets the property StartAt. 
        /// <para>
        /// The start date and time for the spending limit period, in epoch seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartAt { get; set; }

        /// <summary>
        /// Checks to see if the StartAt property is set.
        /// </summary>
        internal bool IsSetStartAt() => this.StartAt.HasValue;
    }
}

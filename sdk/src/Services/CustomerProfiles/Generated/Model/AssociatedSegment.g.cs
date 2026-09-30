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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Represents a segment associated with a membership event stream.
    /// </summary>
    public partial class AssociatedSegment
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An optional message providing context, such as a failure reason. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The unique name of the segment definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The subscription status of the segment. The following are valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STARTING</b>: The segment is being prepared to publish membership events. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RUNNING</b>: The segment is actively publishing membership events to the stream.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STOPPED</b>: The segment has stopped publishing membership events. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>: The segment failed to publish membership events. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EventSubscriptionSegmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

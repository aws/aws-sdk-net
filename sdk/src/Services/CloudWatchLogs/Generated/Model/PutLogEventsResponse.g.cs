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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the PutLogEvents operation.
    /// </summary>
    public partial class PutLogEventsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextSequenceToken. 
        /// <para>
        /// The next sequence token.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field has been deprecated.
        /// </para>
        ///  
        /// <para>
        /// The sequence token is now ignored in <c>PutLogEvents</c> actions. <c>PutLogEvents</c>
        /// actions are always accepted even if the sequence token is not valid. You can use parallel
        /// <c>PutLogEvents</c> actions on the same log stream and you do not need to wait for
        /// the response of a previous <c>PutLogEvents</c> action to obtain the <c>nextSequenceToken</c>
        /// value.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string NextSequenceToken { get; set; }

        /// <summary>
        /// Checks to see if the NextSequenceToken property is set.
        /// </summary>
        internal bool IsSetNextSequenceToken() => this.NextSequenceToken != null;

        /// <summary>
        /// Gets and sets the property RejectedEntityInfo. 
        /// <para>
        /// Information about why the entity is rejected when calling <c>PutLogEvents</c>. Only
        /// returned when the entity is rejected.
        /// </para>
        ///  <note> 
        /// <para>
        /// When the entity is rejected, the events may still be accepted.
        /// </para>
        ///  </note>
        /// </summary>
        public RejectedEntityInfo RejectedEntityInfo { get; set; }

        /// <summary>
        /// Checks to see if the RejectedEntityInfo property is set.
        /// </summary>
        internal bool IsSetRejectedEntityInfo() => this.RejectedEntityInfo != null;

        /// <summary>
        /// Gets and sets the property RejectedLogEventsInfo. 
        /// <para>
        /// The rejected events.
        /// </para>
        /// </summary>
        public RejectedLogEventsInfo RejectedLogEventsInfo { get; set; }

        /// <summary>
        /// Checks to see if the RejectedLogEventsInfo property is set.
        /// </summary>
        internal bool IsSetRejectedLogEventsInfo() => this.RejectedLogEventsInfo != null;
    }
}

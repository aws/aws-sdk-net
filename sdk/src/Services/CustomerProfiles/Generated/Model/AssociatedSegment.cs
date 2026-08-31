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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private string _message;
        private string _segmentName;
        private EventSubscriptionSegmentStatus _status;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An optional message providing context, such as a failure reason. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The unique name of the segment definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

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
        public EventSubscriptionSegmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
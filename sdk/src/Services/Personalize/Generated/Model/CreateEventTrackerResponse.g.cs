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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// This is the response object from the CreateEventTracker operation.
    /// </summary>
    public partial class CreateEventTrackerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EventTrackerArn. 
        /// <para>
        /// The ARN of the event tracker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EventTrackerArn { get; set; }

        /// <summary>
        /// Checks to see if the EventTrackerArn property is set.
        /// </summary>
        internal bool IsSetEventTrackerArn() => this.EventTrackerArn != null;

        /// <summary>
        /// Gets and sets the property TrackingId. 
        /// <para>
        /// The ID of the event tracker. Include this ID in requests to the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UBS_PutEvents.html">PutEvents</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Checks to see if the TrackingId property is set.
        /// </summary>
        internal bool IsSetTrackingId() => this.TrackingId != null;
    }
}

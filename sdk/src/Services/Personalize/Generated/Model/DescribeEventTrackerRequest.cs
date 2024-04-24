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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
    /// Container for the parameters to the DescribeEventTracker operation.
    /// Describes an event tracker. The response includes the <c>trackingId</c> and <c>status</c>
    /// of the event tracker. For more information on event trackers, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>.
    /// </summary>
    public partial class DescribeEventTrackerRequest : AmazonPersonalizeRequest
    {
        private string _eventTrackerArn;

        /// <summary>
        /// Gets and sets the property EventTrackerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event tracker to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string EventTrackerArn
        {
            get { return this._eventTrackerArn; }
            set { this._eventTrackerArn = value; }
        }

        // Check to see if EventTrackerArn property is set
        internal bool IsSetEventTrackerArn()
        {
            return this._eventTrackerArn != null;
        }

    }
}
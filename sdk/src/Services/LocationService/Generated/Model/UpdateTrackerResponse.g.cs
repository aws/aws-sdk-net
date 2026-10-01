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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the UpdateTracker operation.
    /// </summary>
    public partial class UpdateTrackerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property TrackerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated tracker resource. Used to specify a
        /// resource across AWS.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <c>arn:aws:geo:region:account-id:tracker/ExampleTracker</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Max = 1600)]
        public string TrackerArn { get; set; }

        /// <summary>
        /// Checks to see if the TrackerArn property is set.
        /// </summary>
        internal bool IsSetTrackerArn() => this.TrackerArn != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the updated tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp for when the tracker resource was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}

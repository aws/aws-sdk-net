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
    /// Container for the parameters to the DisassociateTrackerConsumer operation. Removes
    /// the association between a tracker resource and a geofence collection. <note> <para>
    /// Once you unlink a tracker resource from a geofence collection, the tracker positions
    /// will no longer be automatically evaluated against geofences. </para> </note>
    /// </summary>
    public partial class DisassociateTrackerConsumerRequest : AmazonLocationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConsumerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the geofence collection to be disassociated from
        /// the tracker resource. Used when you need to specify a resource across all Amazon Web
        /// Services. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <c>arn:aws:geo:region:account-id:geofence-collection/ExampleGeofenceCollectionConsumer</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Max = 1600)]
        public string ConsumerArn { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerArn property is set.
        /// </summary>
        internal bool IsSetConsumerArn() => this.ConsumerArn != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to be dissociated from the consumer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;
    }
}

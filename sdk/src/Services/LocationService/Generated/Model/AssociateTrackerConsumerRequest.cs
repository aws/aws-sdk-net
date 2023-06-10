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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateTrackerConsumer operation.
    /// Creates an association between a geofence collection and a tracker resource. This
    /// allows the tracker resource to communicate location data to the linked geofence collection.
    /// 
    /// 
    ///  
    /// <para>
    /// You can associate up to five geofence collections to each tracker resource.
    /// </para>
    ///  <note> 
    /// <para>
    /// Currently not supported — Cross-account configurations, such as creating associations
    /// between a tracker resource in one account and a geofence collection in another account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AssociateTrackerConsumerRequest : AmazonLocationServiceRequest
    {
        private string _consumerArn;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property ConsumerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the geofence collection to be associated to tracker
        /// resource. Used when you need to specify a resource across all Amazon Web Services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <code>arn:aws:geo:region:account-id:geofence-collection/ExampleGeofenceCollectionConsumer</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1600)]
        public string ConsumerArn
        {
            get { return this._consumerArn; }
            set { this._consumerArn = value; }
        }

        // Check to see if ConsumerArn property is set
        internal bool IsSetConsumerArn()
        {
            return this._consumerArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to be associated with a geofence collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

    }
}
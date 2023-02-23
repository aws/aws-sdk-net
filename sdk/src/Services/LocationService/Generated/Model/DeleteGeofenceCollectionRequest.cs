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
    /// Container for the parameters to the DeleteGeofenceCollection operation.
    /// Deletes a geofence collection from your Amazon Web Services account.
    /// 
    ///  <note> 
    /// <para>
    /// This operation deletes the resource permanently. If the geofence collection is the
    /// target of a tracker resource, the devices will no longer be monitored.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteGeofenceCollectionRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The name of the geofence collection to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CollectionName
        {
            get { return this._collectionName; }
            set { this._collectionName = value; }
        }

        // Check to see if CollectionName property is set
        internal bool IsSetCollectionName()
        {
            return this._collectionName != null;
        }

    }
}
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
    /// Container for the parameters to the BatchDeleteGeofence operation.
    /// Deletes a batch of geofences from a geofence collection.
    /// 
    ///  <note> 
    /// <para>
    /// This action deletes the resource permanently. You can't undo this action.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchDeleteGeofenceRequest : AmazonLocationServiceRequest
    {
        private string _collectionName;
        private List<string> _geofenceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The geofence collection storing the geofences to be deleted.
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

        /// <summary>
        /// Gets and sets the property GeofenceIds. 
        /// <para>
        /// The batch of geofences to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> GeofenceIds
        {
            get { return this._geofenceIds; }
            set { this._geofenceIds = value; }
        }

        // Check to see if GeofenceIds property is set
        internal bool IsSetGeofenceIds()
        {
            return this._geofenceIds != null && this._geofenceIds.Count > 0; 
        }

    }
}
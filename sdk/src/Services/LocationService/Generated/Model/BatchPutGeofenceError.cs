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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains error details for each geofence that failed to be stored in a given geofence
    /// collection.
    /// </summary>
    public partial class BatchPutGeofenceError
    {
        private BatchItemError _error;
        private string _geofenceId;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Contains details associated to the batch error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchItemError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property GeofenceId. 
        /// <para>
        /// The geofence associated with the error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string GeofenceId
        {
            get { return this._geofenceId; }
            set { this._geofenceId = value; }
        }

        // Check to see if GeofenceId property is set
        internal bool IsSetGeofenceId()
        {
            return this._geofenceId != null;
        }

    }
}
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
    /// This is the response object from the BatchPutGeofence operation.
    /// </summary>
    public partial class BatchPutGeofenceResponse : AmazonWebServiceResponse
    {
        private List<BatchPutGeofenceError> _errors = AWSConfigs.InitializeCollections ? new List<BatchPutGeofenceError>() : null;
        private List<BatchPutGeofenceSuccess> _successes = AWSConfigs.InitializeCollections ? new List<BatchPutGeofenceSuccess>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Contains additional error details for each geofence that failed to be stored in a
        /// geofence collection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchPutGeofenceError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Successes. 
        /// <para>
        /// Contains each geofence that was successfully stored in a geofence collection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchPutGeofenceSuccess> Successes
        {
            get { return this._successes; }
            set { this._successes = value; }
        }

        // Check to see if Successes property is set
        internal bool IsSetSuccesses()
        {
            return this._successes != null && (this._successes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
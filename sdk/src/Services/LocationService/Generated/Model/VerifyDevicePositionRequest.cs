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
    /// Container for the parameters to the VerifyDevicePosition operation.
    /// Verifies the integrity of the device's position by determining if it was reported
    /// behind a proxy, and by comparing it to an inferred position estimated based on the
    /// device's state.
    /// 
    ///  <note> 
    /// <para>
    /// The Location Integrity SDK provides enhanced features related to device verification,
    /// and it is available for use by request. To get access to the SDK, contact <a href="https://aws.amazon.com/contact-us/sales-support/?pg=locationprice&amp;cta=herobtn">Sales
    /// Support</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class VerifyDevicePositionRequest : AmazonLocationServiceRequest
    {
        private DeviceState _deviceState;
        private DistanceUnit _distanceUnit;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property DeviceState. 
        /// <para>
        /// The device's state, including position, IP address, cell signals and Wi-Fi access
        /// points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeviceState DeviceState
        {
            get { return this._deviceState; }
            set { this._deviceState = value; }
        }

        // Check to see if DeviceState property is set
        internal bool IsSetDeviceState()
        {
            return this._deviceState != null;
        }

        /// <summary>
        /// Gets and sets the property DistanceUnit. 
        /// <para>
        /// The distance unit for the verification request.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>Kilometers</c> 
        /// </para>
        /// </summary>
        public DistanceUnit DistanceUnit
        {
            get { return this._distanceUnit; }
            set { this._distanceUnit = value; }
        }

        // Check to see if DistanceUnit property is set
        internal bool IsSetDistanceUnit()
        {
            return this._distanceUnit != null;
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource to be associated with verification request.
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
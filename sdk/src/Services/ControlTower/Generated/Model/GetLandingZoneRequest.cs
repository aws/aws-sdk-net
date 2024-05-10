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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the GetLandingZone operation.
    /// Returns details about the landing zone. Displays a message in case of error.
    /// </summary>
    public partial class GetLandingZoneRequest : AmazonControlTowerRequest
    {
        private string _landingZoneIdentifier;

        /// <summary>
        /// Gets and sets the property LandingZoneIdentifier. 
        /// <para>
        /// The unique identifier of the landing zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LandingZoneIdentifier
        {
            get { return this._landingZoneIdentifier; }
            set { this._landingZoneIdentifier = value; }
        }

        // Check to see if LandingZoneIdentifier property is set
        internal bool IsSetLandingZoneIdentifier()
        {
            return this._landingZoneIdentifier != null;
        }

    }
}
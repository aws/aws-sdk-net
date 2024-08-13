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
    /// Container for the parameters to the UpdateLandingZone operation.
    /// This API call updates the landing zone. It starts an asynchronous operation that updates
    /// the landing zone based on the new landing zone version, or on the changed parameters
    /// specified in the updated manifest file.
    /// </summary>
    public partial class UpdateLandingZoneRequest : AmazonControlTowerRequest
    {
        private string _landingZoneIdentifier;
        private Amazon.Runtime.Documents.Document _manifest;
        private string _version;

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

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The manifest file (JSON) is a text file that describes your Amazon Web Services resources.
        /// For an example, review <a href="https://docs.aws.amazon.com/controltower/latest/userguide/lz-api-launch">Launch
        /// your landing zone</a>. The example manifest file contains each of the available parameters.
        /// The schema for the landing zone's JSON manifest file is not published, by design.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return !this._manifest.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The landing zone version, for example, 3.2.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=10)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}
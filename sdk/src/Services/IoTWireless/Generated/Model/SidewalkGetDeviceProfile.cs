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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Gets information about a Sidewalk device profile.
    /// </summary>
    public partial class SidewalkGetDeviceProfile
    {
        private string _applicationServerPublicKey;
        private List<DakCertificateMetadata> _dakCertificateMetadata = AWSConfigs.InitializeCollections ? new List<DakCertificateMetadata>() : null;
        private bool? _qualificationStatus;

        /// <summary>
        /// Gets and sets the property ApplicationServerPublicKey. 
        /// <para>
        /// The Sidewalk application server public key.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string ApplicationServerPublicKey
        {
            get { return this._applicationServerPublicKey; }
            set { this._applicationServerPublicKey = value; }
        }

        // Check to see if ApplicationServerPublicKey property is set
        internal bool IsSetApplicationServerPublicKey()
        {
            return this._applicationServerPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property DakCertificateMetadata. 
        /// <para>
        /// The DAK certificate information of the Sidewalk device profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DakCertificateMetadata> DakCertificateMetadata
        {
            get { return this._dakCertificateMetadata; }
            set { this._dakCertificateMetadata = value; }
        }

        // Check to see if DakCertificateMetadata property is set
        internal bool IsSetDakCertificateMetadata()
        {
            return this._dakCertificateMetadata != null && (this._dakCertificateMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QualificationStatus. 
        /// <para>
        /// Gets information about the certification status of a Sidewalk device profile.
        /// </para>
        /// </summary>
        public bool? QualificationStatus
        {
            get { return this._qualificationStatus; }
            set { this._qualificationStatus = value; }
        }

        // Check to see if QualificationStatus property is set
        internal bool IsSetQualificationStatus()
        {
            return this._qualificationStatus.HasValue; 
        }

    }
}
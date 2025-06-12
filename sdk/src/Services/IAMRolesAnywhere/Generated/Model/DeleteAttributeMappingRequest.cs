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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAttributeMapping operation.
    /// Delete an entry from the attribute mapping rules enforced by a given profile.
    /// </summary>
    public partial class DeleteAttributeMappingRequest : AmazonIAMRolesAnywhereRequest
    {
        private CertificateField _certificateField;
        private string _profileId;
        private List<string> _specifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CertificateField. 
        /// <para>
        /// Fields (x509Subject, x509Issuer and x509SAN) within X.509 certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateField CertificateField
        {
            get { return this._certificateField; }
            set { this._certificateField = value; }
        }

        // Check to see if CertificateField property is set
        internal bool IsSetCertificateField()
        {
            return this._certificateField != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property Specifiers. 
        /// <para>
        /// A list of specifiers of a certificate field; for example, CN, OU, UID from a Subject.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Specifiers
        {
            get { return this._specifiers; }
            set { this._specifiers = value; }
        }

        // Check to see if Specifiers property is set
        internal bool IsSetSpecifiers()
        {
            return this._specifiers != null && (this._specifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
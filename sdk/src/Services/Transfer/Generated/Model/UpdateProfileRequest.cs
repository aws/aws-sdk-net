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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfile operation.
    /// Updates some of the parameters for an existing profile. Provide the <c>ProfileId</c>
    /// for the profile that you want to update, along with the new values for the parameters
    /// to update.
    /// </summary>
    public partial class UpdateProfileRequest : AmazonTransferRequest
    {
        private List<string> _certificateIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property CertificateIds. 
        /// <para>
        /// An array of identifiers for the imported certificates. You use this identifier for
        /// working with profiles and partner profiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CertificateIds
        {
            get { return this._certificateIds; }
            set { this._certificateIds = value; }
        }

        // Check to see if CertificateIds property is set
        internal bool IsSetCertificateIds()
        {
            return this._certificateIds != null && (this._certificateIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The identifier of the profile object that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
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

    }
}
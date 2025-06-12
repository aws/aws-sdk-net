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
    /// The details for a local or partner AS2 profile.
    /// </summary>
    public partial class DescribedProfile
    {
        private string _arn;
        private string _as2Id;
        private List<string> _certificateIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _profileId;
        private ProfileType _profileType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property As2Id. 
        /// <para>
        /// The <c>As2Id</c> is the <i>AS2-name</i>, as defined in the <a href="https://datatracker.ietf.org/doc/html/rfc4130">RFC
        /// 4130</a>. For inbound transfers, this is the <c>AS2-From</c> header for the AS2 messages
        /// sent from the partner. For outbound connectors, this is the <c>AS2-To</c> header for
        /// the AS2 messages sent to the partner using the <c>StartFileTransfer</c> API operation.
        /// This ID cannot include spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string As2Id
        {
            get { return this._as2Id; }
            set { this._as2Id = value; }
        }

        // Check to see if As2Id property is set
        internal bool IsSetAs2Id()
        {
            return this._as2Id != null;
        }

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
        /// A unique identifier for the local or partner AS2 profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
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
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// Indicates whether to list only <c>LOCAL</c> type profiles or only <c>PARTNER</c> type
        /// profiles. If not supplied in the request, the command lists all types of profiles.
        /// </para>
        /// </summary>
        public ProfileType ProfileType
        {
            get { return this._profileType; }
            set { this._profileType = value; }
        }

        // Check to see if ProfileType property is set
        internal bool IsSetProfileType()
        {
            return this._profileType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for profiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the MergeProfiles operation.
    /// Runs an AWS Lambda job that does the following:
    /// 
    ///  <ol> <li> 
    /// <para>
    /// All the profileKeys in the <c>ProfileToBeMerged</c> will be moved to the main profile.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All the objects in the <c>ProfileToBeMerged</c> will be moved to the main profile.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All the <c>ProfileToBeMerged</c> will be deleted at the end.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All the profileKeys in the <c>ProfileIdsToBeMerged</c> will be moved to the main profile.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Standard fields are merged as follows:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Fields are always "union"-ed if there are no conflicts in standard fields or attributeKeys.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When there are conflicting fields:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// If no <c>SourceProfileIds</c> entry is specified, the main Profile value is always
    /// taken. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If a <c>SourceProfileIds</c> entry is specified, the specified profileId is always
    /// taken, even if it is a NULL value.
    /// </para>
    ///  </li> </ol> </li> </ol> </li> </ol> 
    /// <para>
    /// You can use MergeProfiles together with <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>,
    /// which returns potentially matching profiles, or use it with the results of another
    /// matching system. After profiles have been merged, they cannot be separated (unmerged).
    /// </para>
    /// </summary>
    public partial class MergeProfilesRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private FieldSourceProfileIds _fieldSourceProfileIds;
        private string _mainProfileId;
        private List<string> _profileIdsToBeMerged = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldSourceProfileIds. 
        /// <para>
        /// The identifiers of the fields in the profile that has the information you want to
        /// apply to the merge. For example, say you want to merge EmailAddress from Profile1
        /// into MainProfile. This would be the identifier of the EmailAddress field in Profile1.
        /// 
        /// </para>
        /// </summary>
        public FieldSourceProfileIds FieldSourceProfileIds
        {
            get { return this._fieldSourceProfileIds; }
            set { this._fieldSourceProfileIds = value; }
        }

        // Check to see if FieldSourceProfileIds property is set
        internal bool IsSetFieldSourceProfileIds()
        {
            return this._fieldSourceProfileIds != null;
        }

        /// <summary>
        /// Gets and sets the property MainProfileId. 
        /// <para>
        /// The identifier of the profile to be taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MainProfileId
        {
            get { return this._mainProfileId; }
            set { this._mainProfileId = value; }
        }

        // Check to see if MainProfileId property is set
        internal bool IsSetMainProfileId()
        {
            return this._mainProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileIdsToBeMerged. 
        /// <para>
        /// The identifier of the profile to be merged into MainProfileId.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> ProfileIdsToBeMerged
        {
            get { return this._profileIdsToBeMerged; }
            set { this._profileIdsToBeMerged = value; }
        }

        // Check to see if ProfileIdsToBeMerged property is set
        internal bool IsSetProfileIdsToBeMerged()
        {
            return this._profileIdsToBeMerged != null && (this._profileIdsToBeMerged.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
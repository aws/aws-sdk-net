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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// This is the response object from the GetSpace operation.
    /// </summary>
    public partial class GetSpaceResponse : AmazonWebServiceResponse
    {
        private string _applicationArn;
        private string _arn;
        private string _clientId;
        private ConfigurationStatus _configurationStatus;
        private long? _contentSize;
        private DateTime? _createDateTime;
        private string _customerRoleArn;
        private DateTime? _deleteDateTime;
        private string _description;
        private List<string> _groupAdmins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identityStoreId;
        private string _name;
        private string _randomDomain;
        private Dictionary<string, List<string>> _roles = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _spaceId;
        private string _status;
        private long? _storageLimit;
        private SupportedEmailDomainsStatus _supportedEmailDomains;
        private TierLevel _tier;
        private List<string> _userAdmins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _userCount;
        private string _userkmsKey;
        private string _vanityDomain;
        private VanityDomainStatus _vanityDomainStatus;

        /// <summary>
        /// Gets and sets the property ApplicationArn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The Identity Center identifier for the Application Instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationStatus. 
        /// <para>
        /// The configuration status of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationStatus ConfigurationStatus
        {
            get { return this._configurationStatus; }
            set { this._configurationStatus = value; }
        }

        // Check to see if ConfigurationStatus property is set
        internal bool IsSetConfigurationStatus()
        {
            return this._configurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ContentSize. 
        /// <para>
        /// The content size of the private re:Post.
        /// </para>
        /// </summary>
        public long? ContentSize
        {
            get { return this._contentSize; }
            set { this._contentSize = value; }
        }

        // Check to see if ContentSize property is set
        internal bool IsSetContentSize()
        {
            return this._contentSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateDateTime. 
        /// <para>
        /// The date when the private re:Post was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreateDateTime
        {
            get { return this._createDateTime; }
            set { this._createDateTime = value; }
        }

        // Check to see if CreateDateTime property is set
        internal bool IsSetCreateDateTime()
        {
            return this._createDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the private re:Post to convert unanswered
        /// questions into AWS support tickets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomerRoleArn
        {
            get { return this._customerRoleArn; }
            set { this._customerRoleArn = value; }
        }

        // Check to see if CustomerRoleArn property is set
        internal bool IsSetCustomerRoleArn()
        {
            return this._customerRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteDateTime. 
        /// <para>
        /// The date when the private re:Post was deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteDateTime
        {
            get { return this._deleteDateTime; }
            set { this._deleteDateTime = value; }
        }

        // Check to see if DeleteDateTime property is set
        internal bool IsSetDeleteDateTime()
        {
            return this._deleteDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GroupAdmins. 
        /// <para>
        /// The list of groups that are administrators of the private re:Post.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property has been depracted and will be replaced by the roles property.")]
        public List<string> GroupAdmins
        {
            get { return this._groupAdmins; }
            set { this._groupAdmins = value; }
        }

        // Check to see if GroupAdmins property is set
        internal bool IsSetGroupAdmins()
        {
            return this._groupAdmins != null && (this._groupAdmins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId.
        /// </summary>
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=30)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RandomDomain. 
        /// <para>
        /// The AWS generated subdomain of the private re:Post
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RandomDomain
        {
            get { return this._randomDomain; }
            set { this._randomDomain = value; }
        }

        // Check to see if RandomDomain property is set
        internal bool IsSetRandomDomain()
        {
            return this._randomDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// A map of accessor identifiers and their roles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && (this._roles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The creation or deletion status of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLimit. 
        /// <para>
        /// The storage limit of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? StorageLimit
        {
            get { return this._storageLimit; }
            set { this._storageLimit = value; }
        }

        // Check to see if StorageLimit property is set
        internal bool IsSetStorageLimit()
        {
            return this._storageLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedEmailDomains.
        /// </summary>
        public SupportedEmailDomainsStatus SupportedEmailDomains
        {
            get { return this._supportedEmailDomains; }
            set { this._supportedEmailDomains = value; }
        }

        // Check to see if SupportedEmailDomains property is set
        internal bool IsSetSupportedEmailDomains()
        {
            return this._supportedEmailDomains != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The pricing tier of the private re:Post.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TierLevel Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property UserAdmins. 
        /// <para>
        /// The list of users that are administrators of the private re:Post.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property has been depracted and will be replaced by the roles property.")]
        public List<string> UserAdmins
        {
            get { return this._userAdmins; }
            set { this._userAdmins = value; }
        }

        // Check to see if UserAdmins property is set
        internal bool IsSetUserAdmins()
        {
            return this._userAdmins != null && (this._userAdmins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users that have onboarded to the private re:Post.
        /// </para>
        /// </summary>
        public int? UserCount
        {
            get { return this._userCount; }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserKMSKey. 
        /// <para>
        /// The custom AWS KMS key ARN that’s used for the AWS KMS encryption.
        /// </para>
        /// </summary>
        public string UserKMSKey
        {
            get { return this._userkmsKey; }
            set { this._userkmsKey = value; }
        }

        // Check to see if UserKMSKey property is set
        internal bool IsSetUserKMSKey()
        {
            return this._userkmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property VanityDomain. 
        /// <para>
        /// The custom subdomain that you use to access your private re:Post. All custom subdomains
        /// must be approved by AWS before use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VanityDomain
        {
            get { return this._vanityDomain; }
            set { this._vanityDomain = value; }
        }

        // Check to see if VanityDomain property is set
        internal bool IsSetVanityDomain()
        {
            return this._vanityDomain != null;
        }

        /// <summary>
        /// Gets and sets the property VanityDomainStatus. 
        /// <para>
        /// The approval status of the custom subdomain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VanityDomainStatus VanityDomainStatus
        {
            get { return this._vanityDomainStatus; }
            set { this._vanityDomainStatus = value; }
        }

        // Check to see if VanityDomainStatus property is set
        internal bool IsSetVanityDomainStatus()
        {
            return this._vanityDomainStatus != null;
        }

    }
}
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
    /// A structure that contains some information about a private re:Post in the account.
    /// </summary>
    public partial class SpaceData
    {
        private string _arn;
        private ConfigurationStatus _configurationStatus;
        private long? _contentSize;
        private DateTime? _createDateTime;
        private DateTime? _deleteDateTime;
        private string _description;
        private string _name;
        private string _randomDomain;
        private string _spaceId;
        private string _status;
        private long? _storageLimit;
        private SupportedEmailDomainsStatus _supportedEmailDomains;
        private TierLevel _tier;
        private int? _userCount;
        private string _userkmsKey;
        private string _vanityDomain;
        private VanityDomainStatus _vanityDomainStatus;

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
        /// The description for the private re:Post. This is used only to help you identify this
        /// private re:Post.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the private re:Post.
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
        /// The AWS generated subdomain of the private re:Post.
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
        /// The creation/deletion status of the private re:Post.
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
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of onboarded users to the private re:Post.
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
        /// This custom subdomain that you use to access your private re:Post. All custom subdomains
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
        /// This approval status of the custom subdomain.
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
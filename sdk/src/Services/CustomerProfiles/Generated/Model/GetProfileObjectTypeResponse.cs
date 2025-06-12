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
    /// This is the response object from the GetProfileObjectType operation.
    /// </summary>
    public partial class GetProfileObjectTypeResponse : AmazonWebServiceResponse
    {
        private bool? _allowProfileCreation;
        private DateTime? _createdAt;
        private string _description;
        private string _encryptionKey;
        private int? _expirationDays;
        private Dictionary<string, ObjectTypeField> _fields = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;
        private Dictionary<string, List<ObjectTypeKey>> _keys = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ObjectTypeKey>>() : null;
        private DateTime? _lastUpdatedAt;
        private int? _maxAvailableProfileObjectCount;
        private int? _maxProfileObjectCount;
        private string _objectTypeName;
        private string _sourceLastUpdatedTimestampFormat;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _templateId;

        /// <summary>
        /// Gets and sets the property AllowProfileCreation. 
        /// <para>
        /// Indicates whether a profile should be created when data is received if one doesn’t
        /// exist for an object of this type. The default is <c>FALSE</c>. If the AllowProfileCreation
        /// flag is set to <c>FALSE</c>, then the service tries to fetch a standard profile and
        /// associate this object with the profile. If it is set to <c>TRUE</c>, and if no match
        /// is found, then the service creates a new standard profile.
        /// </para>
        /// </summary>
        public bool? AllowProfileCreation
        {
            get { return this._allowProfileCreation; }
            set { this._allowProfileCreation = value; }
        }

        // Check to see if AllowProfileCreation property is set
        internal bool IsSetAllowProfileCreation()
        {
            return this._allowProfileCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the domain was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1000)]
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
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The customer-provided key to encrypt the profile object that will be created in this
        /// profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDays. 
        /// <para>
        /// The number of days until the data in the object expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1098)]
        public int? ExpirationDays
        {
            get { return this._expirationDays; }
            set { this._expirationDays = value; }
        }

        // Check to see if ExpirationDays property is set
        internal bool IsSetExpirationDays()
        {
            return this._expirationDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A map of the name and ObjectType field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, ObjectTypeField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// A list of unique keys that can be used to map data to the profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, List<ObjectTypeKey>> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && (this._keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the domain was most recently edited.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAvailableProfileObjectCount. 
        /// <para>
        /// The amount of provisioned profile object max count available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxAvailableProfileObjectCount
        {
            get { return this._maxAvailableProfileObjectCount; }
            set { this._maxAvailableProfileObjectCount = value; }
        }

        // Check to see if MaxAvailableProfileObjectCount property is set
        internal bool IsSetMaxAvailableProfileObjectCount()
        {
            return this._maxAvailableProfileObjectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxProfileObjectCount. 
        /// <para>
        /// The amount of profile object max count assigned to the object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxProfileObjectCount
        {
            get { return this._maxProfileObjectCount; }
            set { this._maxProfileObjectCount = value; }
        }

        // Check to see if MaxProfileObjectCount property is set
        internal bool IsSetMaxProfileObjectCount()
        {
            return this._maxProfileObjectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The name of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ObjectTypeName
        {
            get { return this._objectTypeName; }
            set { this._objectTypeName = value; }
        }

        // Check to see if ObjectTypeName property is set
        internal bool IsSetObjectTypeName()
        {
            return this._objectTypeName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLastUpdatedTimestampFormat. 
        /// <para>
        /// The format of your <c>sourceLastUpdatedTimestamp</c> that was previously set up.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceLastUpdatedTimestampFormat
        {
            get { return this._sourceLastUpdatedTimestampFormat; }
            set { this._sourceLastUpdatedTimestampFormat = value; }
        }

        // Check to see if SourceLastUpdatedTimestampFormat property is set
        internal bool IsSetSourceLastUpdatedTimestampFormat()
        {
            return this._sourceLastUpdatedTimestampFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}
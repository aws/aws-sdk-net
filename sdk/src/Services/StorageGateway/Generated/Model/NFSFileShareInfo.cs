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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// The Unix file permissions and ownership information assigned, by default, to native
    /// S3 objects when an S3 File Gateway discovers them in S3 buckets. This operation is
    /// only supported in S3 File Gateways.
    /// </summary>
    public partial class NFSFileShareInfo
    {
        private string _auditDestinationARN;
        private string _bucketRegion;
        private CacheAttributes _cacheAttributes;
        private List<string> _clientList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _defaultStorageClass;
        private EncryptionType _encryptionType;
        private string _fileShareARN;
        private string _fileShareId;
        private string _fileShareName;
        private string _fileShareStatus;
        private string _gatewayARN;
        private bool? _guessMIMETypeEnabled;
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private string _locationARN;
        private NFSFileShareDefaults _nfsFileShareDefaults;
        private string _notificationPolicy;
        private ObjectACL _objectACL;
        private string _path;
        private bool? _readOnly;
        private bool? _requesterPays;
        private string _role;
        private string _squash;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _vpcEndpointDNSName;

        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string AuditDestinationARN
        {
            get { return this._auditDestinationARN; }
            set { this._auditDestinationARN = value; }
        }

        // Check to see if AuditDestinationARN property is set
        internal bool IsSetAuditDestinationARN()
        {
            return this._auditDestinationARN != null;
        }

        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// Specifies the Region of the S3 bucket where the NFS file share stores files.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for NFS file shares that connect to Amazon S3 through a
        /// VPC endpoint, a VPC access point, or an access point alias that points to a VPC access
        /// point.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CacheAttributes. 
        /// <para>
        /// Refresh cache information for the file share.
        /// </para>
        /// </summary>
        public CacheAttributes CacheAttributes
        {
            get { return this._cacheAttributes; }
            set { this._cacheAttributes = value; }
        }

        // Check to see if CacheAttributes property is set
        internal bool IsSetCacheAttributes()
        {
            return this._cacheAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ClientList.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ClientList
        {
            get { return this._clientList; }
            set { this._clientList = value; }
        }

        // Check to see if ClientList property is set
        internal bool IsSetClientList()
        {
            return this._clientList != null && (this._clientList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultStorageClass. 
        /// <para>
        /// The default storage class for objects put into an Amazon S3 bucket by the S3 File
        /// Gateway. The default value is <c>S3_STANDARD</c>. Optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>S3_STANDARD</c> | <c>S3_INTELLIGENT_TIERING</c> | <c>S3_STANDARD_IA</c>
        /// | <c>S3_ONEZONE_IA</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string DefaultStorageClass
        {
            get { return this._defaultStorageClass; }
            set { this._defaultStorageClass = value; }
        }

        // Check to see if DefaultStorageClass property is set
        internal bool IsSetDefaultStorageClass()
        {
            return this._defaultStorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// A value that specifies the type of server-side encryption that the file share will
        /// use for the data that it stores in Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend using <c>EncryptionType</c> instead of <c>KMSEncrypted</c> to set the
        /// file share encryption method. You do not need to provide values for both parameters.
        /// </para>
        ///  
        /// <para>
        /// If values for both parameters exist in the same request, then the specified encryption
        /// methods must not conflict. For example, if <c>EncryptionType</c> is <c>SseS3</c>,
        /// then <c>KMSEncrypted</c> must be <c>false</c>. If <c>EncryptionType</c> is <c>SseKms</c>
        /// or <c>DsseKms</c>, then <c>KMSEncrypted</c> must be <c>true</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareId.
        /// </summary>
        [AWSProperty(Min=12, Max=30)]
        public string FileShareId
        {
            get { return this._fileShareId; }
            set { this._fileShareId = value; }
        }

        // Check to see if FileShareId property is set
        internal bool IsSetFileShareId()
        {
            return this._fileShareId != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareName. 
        /// <para>
        /// The name of the file share. Optional.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>FileShareName</c> must be set if an S3 prefix name is set in <c>LocationARN</c>,
        /// or if an access point or access point alias is used.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FileShareName
        {
            get { return this._fileShareName; }
            set { this._fileShareName = value; }
        }

        // Check to see if FileShareName property is set
        internal bool IsSetFileShareName()
        {
            return this._fileShareName != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareStatus.
        /// </summary>
        [AWSProperty(Min=3, Max=50)]
        public string FileShareStatus
        {
            get { return this._fileShareStatus; }
            set { this._fileShareStatus = value; }
        }

        // Check to see if FileShareStatus property is set
        internal bool IsSetFileShareStatus()
        {
            return this._fileShareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GuessMIMETypeEnabled. 
        /// <para>
        /// A value that enables guessing of the MIME type for uploaded objects based on file
        /// extensions. Set this value to <c>true</c> to enable MIME type guessing, otherwise
        /// set to <c>false</c>. The default value is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool GuessMIMETypeEnabled
        {
            get { return this._guessMIMETypeEnabled.GetValueOrDefault(); }
            set { this._guessMIMETypeEnabled = value; }
        }

        // Check to see if GuessMIMETypeEnabled property is set
        internal bool IsSetGuessMIMETypeEnabled()
        {
            return this._guessMIMETypeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// Optional. Set to <c>true</c> to use Amazon S3 server-side encryption with your own
        /// KMS key (SSE-KMS), or <c>false</c> to use a key managed by Amazon S3 (SSE-S3). To
        /// use dual-layer encryption (DSSE-KMS), set the <c>EncryptionType</c> parameter instead.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend using <c>EncryptionType</c> instead of <c>KMSEncrypted</c> to set the
        /// file share encryption method. You do not need to provide values for both parameters.
        /// </para>
        ///  
        /// <para>
        /// If values for both parameters exist in the same request, then the specified encryption
        /// methods must not conflict. For example, if <c>EncryptionType</c> is <c>SseS3</c>,
        /// then <c>KMSEncrypted</c> must be <c>false</c>. If <c>EncryptionType</c> is <c>SseKms</c>
        /// or <c>DsseKms</c>, then <c>KMSEncrypted</c> must be <c>true</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        [Obsolete("KMSEncrypted is deprecated, use EncryptionType instead.")]
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey.
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LocationARN.
        /// </summary>
        [AWSProperty(Min=16, Max=1400)]
        public string LocationARN
        {
            get { return this._locationARN; }
            set { this._locationARN = value; }
        }

        // Check to see if LocationARN property is set
        internal bool IsSetLocationARN()
        {
            return this._locationARN != null;
        }

        /// <summary>
        /// Gets and sets the property NFSFileShareDefaults.
        /// </summary>
        public NFSFileShareDefaults NFSFileShareDefaults
        {
            get { return this._nfsFileShareDefaults; }
            set { this._nfsFileShareDefaults = value; }
        }

        // Check to see if NFSFileShareDefaults property is set
        internal bool IsSetNFSFileShareDefaults()
        {
            return this._nfsFileShareDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationPolicy. 
        /// <para>
        /// The notification policy of the file share. <c>SettlingTimeInSeconds</c> controls the
        /// number of seconds to wait after the last point in time a client wrote to a file before
        /// generating an <c>ObjectUploaded</c> notification. Because clients can make many small
        /// writes to files, it's best to set this parameter for as long as possible to avoid
        /// generating multiple notifications for the same file in a small time period.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>SettlingTimeInSeconds</c> has no effect on the timing of the object uploading
        /// to Amazon S3, only the timing of the notification.
        /// </para>
        ///  
        /// <para>
        /// This setting is not meant to specify an exact time at which the notification will
        /// be sent. In some cases, the gateway might require more than the specified delay time
        /// to generate and send notifications.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following example sets <c>NotificationPolicy</c> on with <c>SettlingTimeInSeconds</c>
        /// set to 60.
        /// </para>
        ///  
        /// <para>
        ///  <c>{\"Upload\": {\"SettlingTimeInSeconds\": 60}}</c> 
        /// </para>
        ///  
        /// <para>
        /// The following example sets <c>NotificationPolicy</c> off.
        /// </para>
        ///  
        /// <para>
        ///  <c>{}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string NotificationPolicy
        {
            get { return this._notificationPolicy; }
            set { this._notificationPolicy = value; }
        }

        // Check to see if NotificationPolicy property is set
        internal bool IsSetNotificationPolicy()
        {
            return this._notificationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectACL.
        /// </summary>
        public ObjectACL ObjectACL
        {
            get { return this._objectACL; }
            set { this._objectACL = value; }
        }

        // Check to see if ObjectACL property is set
        internal bool IsSetObjectACL()
        {
            return this._objectACL != null;
        }

        /// <summary>
        /// Gets and sets the property Path.
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A value that sets the write status of a file share. Set this value to <c>true</c>
        /// to set the write status to read-only, otherwise set to <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterPays. 
        /// <para>
        /// A value that sets who pays the cost of the request and the cost associated with data
        /// download from the S3 bucket. If this value is set to <c>true</c>, the requester pays
        /// the costs; otherwise, the S3 bucket owner pays. However, the S3 bucket owner always
        /// pays the cost of storing data.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>RequesterPays</c> is a configuration for the S3 bucket that backs the file share,
        /// so make sure that the configuration on the file share is the same as the S3 bucket
        /// configuration.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool RequesterPays
        {
            get { return this._requesterPays.GetValueOrDefault(); }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Squash.
        /// </summary>
        [AWSProperty(Min=5, Max=15)]
        public string Squash
        {
            get { return this._squash; }
            set { this._squash = value; }
        }

        // Check to see if Squash property is set
        internal bool IsSetSquash()
        {
            return this._squash != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags assigned to the NFS file share, sorted alphabetically by key
        /// name. Each tag is a key-value pair. For a gateway with more than 10 tags assigned,
        /// you can view all tags using the <c>ListTagsForResource</c> API operation.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VPCEndpointDNSName. 
        /// <para>
        /// Specifies the DNS name for the VPC endpoint that the NFS file share uses to connect
        /// to Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for NFS file shares that connect to Amazon S3 through a
        /// VPC endpoint, a VPC access point, or an access point alias that points to a VPC access
        /// point.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VPCEndpointDNSName
        {
            get { return this._vpcEndpointDNSName; }
            set { this._vpcEndpointDNSName = value; }
        }

        // Check to see if VPCEndpointDNSName property is set
        internal bool IsSetVPCEndpointDNSName()
        {
            return this._vpcEndpointDNSName != null;
        }

    }
}
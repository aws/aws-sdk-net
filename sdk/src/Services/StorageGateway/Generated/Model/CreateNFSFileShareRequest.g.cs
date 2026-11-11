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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateNFSFileShare operation. Creates a Network
    /// File System (NFS) file share on an existing S3 File Gateway. In Storage Gateway, a
    /// file share is a file system mount point backed by Amazon S3 cloud storage. Storage
    /// Gateway exposes file shares using an NFS interface. This operation is only supported
    /// for S3 File Gateways. <important> <para> S3 File gateway requires Security Token Service
    /// (Amazon Web Services STS) to be activated to enable you to create a file share. Make
    /// sure Amazon Web Services STS is activated in the Amazon Web Services Region you are
    /// creating your S3 File Gateway in. If Amazon Web Services STS is not activated in the
    /// Amazon Web Services Region, activate it. For information about how to activate Amazon
    /// Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
    /// <i>Identity and Access Management User Guide</i>. </para> <para> S3 File Gateways
    /// do not support creating hard or symbolic links on a file share. </para> </important>
    /// </summary>
    public partial class CreateNFSFileShareRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AuditDestinationARN { get; set; }

        /// <summary>
        /// Checks to see if the AuditDestinationARN property is set.
        /// </summary>
        internal bool IsSetAuditDestinationARN() => this.AuditDestinationARN != null;

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
        [AWSProperty(Min = 1, Max = 25)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// Checks to see if the BucketRegion property is set.
        /// </summary>
        internal bool IsSetBucketRegion() => this.BucketRegion != null;

        /// <summary>
        /// Gets and sets the property CacheAttributes. 
        /// <para>
        /// Specifies refresh cache information for the file share.
        /// </para>
        /// </summary>
        public CacheAttributes CacheAttributes { get; set; }

        /// <summary>
        /// Checks to see if the CacheAttributes property is set.
        /// </summary>
        internal bool IsSetCacheAttributes() => this.CacheAttributes != null;

        /// <summary>
        /// Gets and sets the property ClientList. 
        /// <para>
        /// The list of clients that are allowed to access the S3 File Gateway. The list must
        /// contain either valid IPv4/IPv6 addresses or valid CIDR blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ClientList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientList property is set.
        /// </summary>
        internal bool IsSetClientList() => this.ClientList != null && (this.ClientList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string value that you supply that is used by S3 File Gateway to ensure idempotent
        /// file share creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        [AWSProperty(Min = 5, Max = 50)]
        public string DefaultStorageClass { get; set; }

        /// <summary>
        /// Checks to see if the DefaultStorageClass property is set.
        /// </summary>
        internal bool IsSetDefaultStorageClass() => this.DefaultStorageClass != null;

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
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

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
        ///  
        /// <para>
        /// A valid NFS file share name can only contain the following characters: <c>a</c>-<c>z</c>,
        /// <c>A</c>-<c>Z</c>, <c>0</c>-<c>9</c>, <c>-</c>, <c>.</c>, and <c>_</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FileShareName { get; set; }

        /// <summary>
        /// Checks to see if the FileShareName property is set.
        /// </summary>
        internal bool IsSetFileShareName() => this.FileShareName != null;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 File Gateway on which you want to create
        /// a file share.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

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
        public bool? GuessMIMETypeEnabled { get; set; }

        /// <summary>
        /// Checks to see if the GuessMIMETypeEnabled property is set.
        /// </summary>
        internal bool IsSetGuessMIMETypeEnabled() => this.GuessMIMETypeEnabled.HasValue;

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
        public bool? KMSEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the KMSEncrypted property is set.
        /// </summary>
        internal bool IsSetKMSEncrypted() => this.KMSEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// Optional. The Amazon Resource Name (ARN) of a symmetric customer master key (CMK)
        /// used for Amazon S3 server-side encryption. Storage Gateway does not support asymmetric
        /// CMKs. This value must be set if <c>KMSEncrypted</c> is <c>true</c>, or if <c>EncryptionType</c>
        /// is <c>SseKms</c> or <c>DsseKms</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 2048)]
        public string KMSKey { get; set; }

        /// <summary>
        /// Checks to see if the KMSKey property is set.
        /// </summary>
        internal bool IsSetKMSKey() => this.KMSKey != null;

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// A custom ARN for the backend storage used for storing data for file shares. It includes
        /// a resource ARN with an optional prefix concatenation. The prefix must end with a forward
        /// slash (/).
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify LocationARN as a bucket ARN, access point ARN or access point alias,
        /// as shown in the following examples.
        /// </para>
        ///  
        /// <para>
        /// Bucket ARN:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:s3:::amzn-s3-demo-bucket/prefix/</c> 
        /// </para>
        ///  
        /// <para>
        /// Access point ARN:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:s3:region:account-id:accesspoint/access-point-name/prefix/</c> 
        /// </para>
        ///  
        /// <para>
        /// If you specify an access point, the bucket policy must be configured to delegate access
        /// control to the access point. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-policies.html#access-points-delegating-control">Delegating
        /// access control to access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Access point alias:
        /// </para>
        ///  
        /// <para>
        ///  <c>test-ap-ab123cdef4gehijklmn5opqrstuvuse1a-s3alias</c> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1400)]
        public string LocationARN { get; set; }

        /// <summary>
        /// Checks to see if the LocationARN property is set.
        /// </summary>
        internal bool IsSetLocationARN() => this.LocationARN != null;

        /// <summary>
        /// Gets and sets the property NFSFileShareDefaults. 
        /// <para>
        /// File share default values. Optional.
        /// </para>
        /// </summary>
        public NFSFileShareDefaults NFSFileShareDefaults { get; set; }

        /// <summary>
        /// Checks to see if the NFSFileShareDefaults property is set.
        /// </summary>
        internal bool IsSetNFSFileShareDefaults() => this.NFSFileShareDefaults != null;

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
        [AWSProperty(Min = 2, Max = 100)]
        public string NotificationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the NotificationPolicy property is set.
        /// </summary>
        internal bool IsSetNotificationPolicy() => this.NotificationPolicy != null;

        /// <summary>
        /// Gets and sets the property ObjectACL. 
        /// <para>
        /// A value that sets the access control list (ACL) permission for objects in the S3 bucket
        /// that a S3 File Gateway puts objects into. The default value is <c>private</c>.
        /// </para>
        /// </summary>
        public ObjectACL ObjectACL { get; set; }

        /// <summary>
        /// Checks to see if the ObjectACL property is set.
        /// </summary>
        internal bool IsSetObjectACL() => this.ObjectACL != null;

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
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

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
        public bool? RequesterPays { get; set; }

        /// <summary>
        /// Checks to see if the RequesterPays property is set.
        /// </summary>
        internal bool IsSetRequesterPays() => this.RequesterPays.HasValue;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) role that an S3 File Gateway assumes
        /// when it accesses the underlying storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Squash. 
        /// <para>
        /// A value that maps a user to anonymous user.
        /// </para>
        ///  
        /// <para>
        /// Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RootSquash</c>: Only root is mapped to anonymous user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoSquash</c>: No one is mapped to anonymous user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AllSquash</c>: Everyone is mapped to anonymous user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 5, Max = 15)]
        public string Squash { get; set; }

        /// <summary>
        /// Checks to see if the Squash property is set.
        /// </summary>
        internal bool IsSetSquash() => this.Squash != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to the NFS file share. Each tag is a
        /// key-value pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 255)]
        public string VPCEndpointDNSName { get; set; }

        /// <summary>
        /// Checks to see if the VPCEndpointDNSName property is set.
        /// </summary>
        internal bool IsSetVPCEndpointDNSName() => this.VPCEndpointDNSName != null;
    }
}

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
    /// Container for the parameters to the UpdateSMBFileShare operation. Updates a Server
    /// Message Block (SMB) file share. This operation is only supported for S3 File Gateways.
    /// <note> <para> To leave a file share field unchanged, set the corresponding input field
    /// to null. </para> </note> <important> <para> File gateways require Security Token Service
    /// (Amazon Web Services STS) to be activated to enable you to create a file share. Make
    /// sure that Amazon Web Services STS is activated in the Amazon Web Services Region you
    /// are creating your file gateway in. If Amazon Web Services STS is not activated in
    /// this Amazon Web Services Region, activate it. For information about how to activate
    /// Amazon Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
    /// <i>Identity and Access Management User Guide</i>. </para> <para> File gateways don't
    /// support creating hard or symbolic links on a file share. </para> </important>
    /// </summary>
    public partial class UpdateSMBFileShareRequest : AmazonStorageGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AccessBasedEnumeration. 
        /// <para>
        /// The files and folders on this share will only be visible to users with read access.
        /// </para>
        /// </summary>
        public bool? AccessBasedEnumeration { get; set; }

        /// <summary>
        /// Checks to see if the AccessBasedEnumeration property is set.
        /// </summary>
        internal bool IsSetAccessBasedEnumeration() => this.AccessBasedEnumeration.HasValue;

        /// <summary>
        /// Gets and sets the property AdminUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that have administrator rights to
        /// the file share. A group must be prefixed with the @ character. Acceptable formats
        /// include: <c>DOMAIN\User1</c>, <c>user1</c>, <c>@group1</c>, and <c>@DOMAIN\group1</c>.
        /// Can only be set if Authentication is set to <c>ActiveDirectory</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> AdminUserList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdminUserList property is set.
        /// </summary>
        internal bool IsSetAdminUserList() => this.AdminUserList != null && (this.AdminUserList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property CaseSensitivity. 
        /// <para>
        /// The case of an object name in an Amazon S3 bucket. For <c>ClientSpecified</c>, the
        /// client determines the case sensitivity. For <c>CaseSensitive</c>, the gateway determines
        /// the case sensitivity. The default value is <c>ClientSpecified</c>.
        /// </para>
        /// </summary>
        public CaseSensitivity CaseSensitivity { get; set; }

        /// <summary>
        /// Checks to see if the CaseSensitivity property is set.
        /// </summary>
        internal bool IsSetCaseSensitivity() => this.CaseSensitivity != null;

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
        /// Gets and sets the property FileShareARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SMB file share that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 500)]
        public string FileShareARN { get; set; }

        /// <summary>
        /// Checks to see if the FileShareARN property is set.
        /// </summary>
        internal bool IsSetFileShareARN() => this.FileShareARN != null;

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
        /// A valid SMB file share name cannot contain the following characters: <c>[</c>,<c>]</c>,<c>#</c>,<c>;</c>,<c>&lt;</c>,<c>></c>,<c>:</c>,<c>"</c>,<c>\</c>,<c>/</c>,<c>|</c>,<c>?</c>,<c>*</c>,<c>+</c>,
        /// or ASCII control characters <c>1-31</c>.
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
        /// Gets and sets the property InvalidUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that are not allowed to access the
        /// file share. A group must be prefixed with the @ character. Acceptable formats include:
        /// <c>DOMAIN\User1</c>, <c>user1</c>, <c>@group1</c>, and <c>@DOMAIN\group1</c>. Can
        /// only be set if Authentication is set to <c>ActiveDirectory</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> InvalidUserList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InvalidUserList property is set.
        /// </summary>
        internal bool IsSetInvalidUserList() => this.InvalidUserList != null && (this.InvalidUserList.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property OplocksEnabled. 
        /// <para>
        /// Specifies whether opportunistic locking is enabled for the SMB file share.
        /// </para>
        ///  <note> 
        /// <para>
        /// Enabling opportunistic locking on case-sensitive shares is not recommended for workloads
        /// that involve access to files with the same name in different case.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? OplocksEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OplocksEnabled property is set.
        /// </summary>
        internal bool IsSetOplocksEnabled() => this.OplocksEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A value that sets the write status of a file share. Set this value to <c>true</c>
        /// to set write status to read-only, otherwise set to <c>false</c>.
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
        /// Gets and sets the property SMBACLEnabled. 
        /// <para>
        /// Set this value to <c>true</c> to enable access control list (ACL) on the SMB file
        /// share. Set it to <c>false</c> to map file and directory permissions to the POSIX permissions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/smb-acl.html">Using
        /// Windows ACLs to limit SMB file share access</a> in the <i>Amazon S3 File Gateway User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? SMBACLEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SMBACLEnabled property is set.
        /// </summary>
        internal bool IsSetSMBACLEnabled() => this.SMBACLEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ValidUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that are allowed to access the file
        /// share. A group must be prefixed with the @ character. Acceptable formats include:
        /// <c>DOMAIN\User1</c>, <c>user1</c>, <c>@group1</c>, and <c>@DOMAIN\group1</c>. Can
        /// only be set if Authentication is set to <c>ActiveDirectory</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ValidUserList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidUserList property is set.
        /// </summary>
        internal bool IsSetValidUserList() => this.ValidUserList != null && (this.ValidUserList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

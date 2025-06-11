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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
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
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Describes the new or existing destination file system for the replication configuration.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you want to replicate to a new file system, do not specify the File System ID for
    /// the destination file system. Amazon EFS creates a new, empty file system. For One
    /// Zone storage, specify the Availability Zone to create the file system in. To use an
    /// Key Management Service key other than the default KMS key, then specify it. For more
    /// information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/create-replication.html">Configuring
    /// replication to new Amazon EFS file system</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// After the file system is created, you cannot change the KMS key or the performance
    /// mode.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// If you want to replicate to an existing file system that's in the same account as
    /// the source file system, then you need to provide the ID or Amazon Resource Name (ARN)
    /// of the file system to which to replicate. The file system's replication overwrite
    /// protection must be disabled. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication#replicate-existing-destination">Replicating
    /// to an existing file system</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are replicating the file system to a file system that's in a different account
    /// than the source file system (cross-account replication), you need to provide the ARN
    /// for the file system and the IAM role that allows Amazon EFS to perform replication
    /// on the destination account. The file system's replication overwrite protection must
    /// be disabled. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/cross-account-replication.html">Replicating
    /// across Amazon Web Services accounts</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DestinationToCreate
    {
        private string _availabilityZoneName;
        private string _fileSystemId;
        private string _kmsKeyId;
        private string _region;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneName. 
        /// <para>
        /// To create a file system that uses One Zone storage, specify the name of the Availability
        /// Zone in which to create the destination file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AvailabilityZoneName
        {
            get { return this._availabilityZoneName; }
            set { this._availabilityZoneName = value; }
        }

        // Check to see if AvailabilityZoneName property is set
        internal bool IsSetAvailabilityZoneName()
        {
            return this._availabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID or ARN of the file system to use for the destination. For cross-account replication,
        /// this must be an ARN. The file system's replication overwrite replication must be disabled.
        /// If no ID or ARN is specified, then a new file system is created. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you initially configure replication to an existing file system, Amazon EFS writes
        /// data to or removes existing data from the destination file system to match data in
        /// the source file system. If you don't want to change data in the destination file system,
        /// then you should replicate to a new file system instead. For more information, see
        /// <a href="https://docs.aws.amazon.com/efs/latest/ug/create-replication.html">https://docs.aws.amazon.com/efs/latest/ug/create-replication.html</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specify the Key Management Service (KMS) key that you want to use to encrypt the destination
        /// file system. If you do not specify a KMS key, Amazon EFS uses your default KMS key
        /// for Amazon EFS, <c>/aws/elasticfilesystem</c>. This ID can be in one of the following
        /// formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID - The unique identifier of the key, for example <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN - The ARN for the key, for example <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias - A previously created display name for a key, for example <c>alias/projectKey1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias ARN - The ARN for a key alias, for example <c>arn:aws:kms:us-west-2:444455556666:alias/projectKey1</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// To create a file system that uses Regional storage, specify the Amazon Web Services
        /// Region in which to create the destination file system. The Region must be enabled
        /// for the Amazon Web Services account that owns the source file system. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html#rande-manage-enable">Managing
        /// Amazon Web Services Regions</a> in the <i>Amazon Web Services General Reference Reference
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM role in the source account that allows Amazon
        /// EFS to perform replication on its behalf. This is optional for same-account replication
        /// and required for cross-account replication.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}
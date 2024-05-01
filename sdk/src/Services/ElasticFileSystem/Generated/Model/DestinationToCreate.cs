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
    /// </summary>
    public partial class DestinationToCreate
    {
        private string _availabilityZoneName;
        private string _fileSystemId;
        private string _kmsKeyId;
        private string _region;

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
        /// The ID of the file system to use for the destination. The file system's replication
        /// overwrite replication must be disabled. If you do not provide an ID, then EFS creates
        /// a new file system for the replication destination.
        /// </para>
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
        /// ARN - The Amazon Resource Name (ARN) for the key, for example <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
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
        /// Region in which to create the destination file system.
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

    }
}
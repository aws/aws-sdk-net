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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationConfiguration operation.
    /// Creates a replication configuration that replicates an existing EFS file system to
    /// a new, read-only file system. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
    /// EFS replication</a> in the <i>Amazon EFS User Guide</i>. The replication configuration
    /// specifies the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Source file system</b> - An existing EFS file system that you want replicated.
    /// The source file system cannot be a destination file system in an existing replication
    /// configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Destination file system configuration</b> - The configuration of the destination
    /// file system to which the source file system will be replicated. There can only be
    /// one destination file system in a replication configuration. The destination file system
    /// configuration consists of the following properties:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Amazon Web Services Region</b> - The Amazon Web Services Region in which the destination
    /// file system is created. Amazon EFS replication is available in all Amazon Web Services
    /// Regions that Amazon EFS is available in, except Africa (Cape Town), Asia Pacific (Hong
    /// Kong), Asia Pacific (Jakarta), Europe (Milan), and Middle East (Bahrain).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Availability Zone</b> - If you want the destination file system to use EFS One
    /// Zone availability and durability, you must specify the Availability Zone to create
    /// the file system in. For more information about EFS storage classes, see <a href="https://docs.aws.amazon.com/efs/latest/ug/storage-classes.html">
    /// Amazon EFS storage classes</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Encryption</b> - All destination file systems are created with encryption at rest
    /// enabled. You can specify the Key Management Service (KMS) key that is used to encrypt
    /// the destination file system. If you don't specify a KMS key, your service-managed
    /// KMS key for Amazon EFS is used. 
    /// </para>
    ///  <note> 
    /// <para>
    /// After the file system is created, you cannot change the KMS key.
    /// </para>
    ///  </note> </li> </ul> </li> </ul> 
    /// <para>
    /// The following properties are set by default:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Performance mode</b> - The destination file system's performance mode matches
    /// that of the source file system, unless the destination file system uses EFS One Zone
    /// storage. In that case, the General Purpose performance mode is used. The performance
    /// mode cannot be changed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Throughput mode</b> - The destination file system's throughput mode matches that
    /// of the source file system. After the file system is created, you can modify the throughput
    /// mode.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following properties are turned off by default:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Lifecycle management</b> - EFS lifecycle management and EFS Intelligent-Tiering
    /// are not enabled on the destination file system. After the destination file system
    /// is created, you can enable EFS lifecycle management and EFS Intelligent-Tiering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Automatic backups</b> - Automatic daily backups not enabled on the destination
    /// file system. After the file system is created, you can change this setting.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
    /// EFS replication</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateReplicationConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private List<DestinationToCreate> _destinations = new List<DestinationToCreate>();
        private string _sourceFileSystemId;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of destination configuration objects. Only one destination configuration
        /// object is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DestinationToCreate> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceFileSystemId. 
        /// <para>
        /// Specifies the Amazon EFS file system that you want to replicate. This file system
        /// cannot already be a source or destination file system in another replication configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string SourceFileSystemId
        {
            get { return this._sourceFileSystemId; }
            set { this._sourceFileSystemId = value; }
        }

        // Check to see if SourceFileSystemId property is set
        internal bool IsSetSourceFileSystemId()
        {
            return this._sourceFileSystemId != null;
        }

    }
}
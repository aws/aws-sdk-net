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
    /// Container for the parameters to the CreateReplicationConfiguration operation.
    /// Creates a replication conﬁguration to either a new or existing EFS file system. For
    /// more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html">Amazon
    /// EFS replication</a> in the <i>Amazon EFS User Guide</i>. The replication configuration
    /// specifies the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Source file system</b> – The EFS file system that you want to replicate. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Destination file system</b> – The destination file system to which the source
    /// file system is replicated. There can only be one destination file system in a replication
    /// configuration. 
    /// </para>
    ///  <note> 
    /// <para>
    /// A file system can be part of only one replication configuration. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The destination parameters for the replication configuration depend on whether you
    /// are replicating to a new file system or to an existing file system, and if you are
    /// replicating across Amazon Web Services accounts. See <a>DestinationToCreate</a> for
    /// more information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation requires permissions for the <c>elasticfilesystem:CreateReplicationConfiguration</c>
    /// action. Additionally, other permissions are required depending on how you are replicating
    /// file systems. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-replication.html#efs-replication-permissions">Required
    /// permissions for replication</a> in the <i>Amazon EFS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateReplicationConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private List<DestinationToCreate> _destinations = AWSConfigs.InitializeCollections ? new List<DestinationToCreate>() : null;
        private string _sourceFileSystemId;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of destination configuration objects. Only one destination configuration
        /// object is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
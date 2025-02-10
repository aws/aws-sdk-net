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
    /// Container for the parameters to the DeleteReplicationConfiguration operation.
    /// Deletes a replication configuration. Deleting a replication configuration ends the
    /// replication process. After a replication configuration is deleted, the destination
    /// file system becomes <c>Writeable</c> and its replication overwrite protection is re-enabled.
    /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/delete-replications.html">Delete
    /// a replication configuration</a>.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions for the <c>elasticfilesystem:DeleteReplicationConfiguration</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DeleteReplicationConfigurationRequest : AmazonElasticFileSystemRequest
    {
        private DeletionMode _deletionMode;
        private string _sourceFileSystemId;

        /// <summary>
        /// Gets and sets the property DeletionMode. 
        /// <para>
        /// When replicating across Amazon Web Services accounts or across Amazon Web Services
        /// Regions, Amazon EFS deletes the replication configuration from both the source and
        /// destination account or Region (<c>ALL_CONFIGURATIONS</c>) by default. If there's a
        /// configuration or permissions issue that prevents Amazon EFS from deleting the replication
        /// configuration from both sides, you can use the <c>LOCAL_CONFIGURATION_ONLY</c> mode
        /// to delete the replication configuration from only the local side (the account or Region
        /// from which the delete is performed). 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only use the <c>LOCAL_CONFIGURATION_ONLY</c> mode in the case that Amazon EFS is unable
        /// to delete the replication configuration in both the source and destination account
        /// or Region. Deleting the local configuration leaves the configuration in the other
        /// account or Region unrecoverable.
        /// </para>
        ///  
        /// <para>
        /// Additionally, do not use this mode for same-account, same-region replication as doing
        /// so results in a BadRequest exception error.
        /// </para>
        ///  </note>
        /// </summary>
        public DeletionMode DeletionMode
        {
            get { return this._deletionMode; }
            set { this._deletionMode = value; }
        }

        // Check to see if DeletionMode property is set
        internal bool IsSetDeletionMode()
        {
            return this._deletionMode != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileSystemId. 
        /// <para>
        /// The ID of the source file system in the replication configuration.
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
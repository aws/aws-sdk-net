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
    /// Container for the parameters to the UpdateFileSystem operation.
    /// Updates the throughput mode or the amount of provisioned throughput of an existing
    /// file system.
    /// </summary>
    public partial class UpdateFileSystemRequest : AmazonElasticFileSystemRequest
    {
        private string _fileSystemId;
        private double? _provisionedThroughputInMibps;
        private ThroughputMode _throughputMode;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the file system that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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
        /// Gets and sets the property ProvisionedThroughputInMibps. 
        /// <para>
        /// (Optional) The throughput, measured in mebibytes per second (MiBps), that you want
        /// to provision for a file system that you're creating. Required if <c>ThroughputMode</c>
        /// is set to <c>provisioned</c>. Valid values are 1-3414 MiBps, with the upper limit
        /// depending on Region. To increase this limit, contact Amazon Web ServicesSupport. For
        /// more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/limits.html#soft-limits">Amazon
        /// EFS quotas that you can increase</a> in the <i>Amazon EFS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public double? ProvisionedThroughputInMibps
        {
            get { return this._provisionedThroughputInMibps; }
            set { this._provisionedThroughputInMibps = value; }
        }

        // Check to see if ProvisionedThroughputInMibps property is set
        internal bool IsSetProvisionedThroughputInMibps()
        {
            return this._provisionedThroughputInMibps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// (Optional) Updates the file system's throughput mode. If you're not updating your
        /// throughput mode, you don't need to provide this value in your request. If you are
        /// changing the <c>ThroughputMode</c> to <c>provisioned</c>, you must also set a value
        /// for <c>ProvisionedThroughputInMibps</c>.
        /// </para>
        /// </summary>
        public ThroughputMode ThroughputMode
        {
            get { return this._throughputMode; }
            set { this._throughputMode = value; }
        }

        // Check to see if ThroughputMode property is set
        internal bool IsSetThroughputMode()
        {
            return this._throughputMode != null;
        }

    }
}
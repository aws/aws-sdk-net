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
    /// This is the response object from the CreateReplicationConfiguration operation.
    /// </summary>
    public partial class CreateReplicationConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private List<Destination> _destinations = new List<Destination>();
        private string _originalSourceFileSystemArn;
        private string _sourceFileSystemArn;
        private string _sourceFileSystemId;
        private string _sourceFileSystemRegion;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Describes when the replication configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of destination objects. Only one destination object is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Destination> Destinations
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
        /// Gets and sets the property OriginalSourceFileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original source Amazon EFS file system in the
        /// replication configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginalSourceFileSystemArn
        {
            get { return this._originalSourceFileSystemArn; }
            set { this._originalSourceFileSystemArn = value; }
        }

        // Check to see if OriginalSourceFileSystemArn property is set
        internal bool IsSetOriginalSourceFileSystemArn()
        {
            return this._originalSourceFileSystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileSystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the current source file system in the replication
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceFileSystemArn
        {
            get { return this._sourceFileSystemArn; }
            set { this._sourceFileSystemArn = value; }
        }

        // Check to see if SourceFileSystemArn property is set
        internal bool IsSetSourceFileSystemArn()
        {
            return this._sourceFileSystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileSystemId. 
        /// <para>
        /// The ID of the source Amazon EFS file system that is being replicated.
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

        /// <summary>
        /// Gets and sets the property SourceFileSystemRegion. 
        /// <para>
        /// The Amazon Web Services Region in which the source Amazon EFS file system is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SourceFileSystemRegion
        {
            get { return this._sourceFileSystemRegion; }
            set { this._sourceFileSystemRegion = value; }
        }

        // Check to see if SourceFileSystemRegion property is set
        internal bool IsSetSourceFileSystemRegion()
        {
            return this._sourceFileSystemRegion != null;
        }

    }
}
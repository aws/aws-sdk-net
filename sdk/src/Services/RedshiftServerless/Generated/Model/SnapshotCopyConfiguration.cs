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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The object that you configure to copy snapshots from one namespace to a namespace
    /// in another Amazon Web Services Region.
    /// </summary>
    public partial class SnapshotCopyConfiguration
    {
        private string _destinationKmsKeyId;
        private string _destinationRegion;
        private string _namespaceName;
        private string _snapshotCopyConfigurationArn;
        private string _snapshotCopyConfigurationId;
        private int? _snapshotRetentionPeriod;

        /// <summary>
        /// Gets and sets the property DestinationKmsKeyId. 
        /// <para>
        /// The ID of the KMS key to use to encrypt your snapshots in the destination Amazon Web
        /// Services Region.
        /// </para>
        /// </summary>
        public string DestinationKmsKeyId
        {
            get { return this._destinationKmsKeyId; }
            set { this._destinationKmsKeyId = value; }
        }

        // Check to see if DestinationKmsKeyId property is set
        internal bool IsSetDestinationKmsKeyId()
        {
            return this._destinationKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Amazon Web Services Region to copy snapshots to.
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to copy snapshots from in the source Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfigurationArn. 
        /// <para>
        /// The ARN of the snapshot copy configuration object.
        /// </para>
        /// </summary>
        public string SnapshotCopyConfigurationArn
        {
            get { return this._snapshotCopyConfigurationArn; }
            set { this._snapshotCopyConfigurationArn = value; }
        }

        // Check to see if SnapshotCopyConfigurationArn property is set
        internal bool IsSetSnapshotCopyConfigurationArn()
        {
            return this._snapshotCopyConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCopyConfigurationId. 
        /// <para>
        /// The ID of the snapshot copy configuration object.
        /// </para>
        /// </summary>
        public string SnapshotCopyConfigurationId
        {
            get { return this._snapshotCopyConfigurationId; }
            set { this._snapshotCopyConfigurationId = value; }
        }

        // Check to see if SnapshotCopyConfigurationId property is set
        internal bool IsSetSnapshotCopyConfigurationId()
        {
            return this._snapshotCopyConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionPeriod. 
        /// <para>
        /// The retention period of snapshots that are copied to the destination Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionPeriod
        {
            get { return this._snapshotRetentionPeriod; }
            set { this._snapshotRetentionPeriod = value; }
        }

        // Check to see if SnapshotRetentionPeriod property is set
        internal bool IsSetSnapshotRetentionPeriod()
        {
            return this._snapshotRetentionPeriod.HasValue; 
        }

    }
}
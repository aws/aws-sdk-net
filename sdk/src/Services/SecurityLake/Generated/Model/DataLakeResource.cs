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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides details of Amazon Security Lake object.
    /// </summary>
    public partial class DataLakeResource
    {
        private DataLakeStatus _createStatus;
        private string _dataLakeArn;
        private DataLakeEncryptionConfiguration _encryptionConfiguration;
        private DataLakeLifecycleConfiguration _lifecycleConfiguration;
        private string _region;
        private DataLakeReplicationConfiguration _replicationConfiguration;
        private string _s3BucketArn;
        private DataLakeUpdateStatus _updateStatus;

        /// <summary>
        /// Gets and sets the property CreateStatus. 
        /// <para>
        /// Retrieves the status of the <c>CreateDatalake</c> API call for an account in Amazon
        /// Security Lake.
        /// </para>
        /// </summary>
        public DataLakeStatus CreateStatus
        {
            get { return this._createStatus; }
            set { this._createStatus = value; }
        }

        // Check to see if CreateStatus property is set
        internal bool IsSetCreateStatus()
        {
            return this._createStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DataLakeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) created by you to provide to the subscriber. For more
        /// information about ARNs and how to use them in policies, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/subscriber-management.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string DataLakeArn
        {
            get { return this._dataLakeArn; }
            set { this._dataLakeArn = value; }
        }

        // Check to see if DataLakeArn property is set
        internal bool IsSetDataLakeArn()
        {
            return this._dataLakeArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Provides encryption details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleConfiguration. 
        /// <para>
        /// Provides lifecycle details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeLifecycleConfiguration LifecycleConfiguration
        {
            get { return this._lifecycleConfiguration; }
            set { this._lifecycleConfiguration = value; }
        }

        // Check to see if LifecycleConfiguration property is set
        internal bool IsSetLifecycleConfiguration()
        {
            return this._lifecycleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Regions where Security Lake is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReplicationConfiguration. 
        /// <para>
        /// Provides replication details of Amazon Security Lake object.
        /// </para>
        /// </summary>
        public DataLakeReplicationConfiguration ReplicationConfiguration
        {
            get { return this._replicationConfiguration; }
            set { this._replicationConfiguration = value; }
        }

        // Check to see if ReplicationConfiguration property is set
        internal bool IsSetReplicationConfiguration()
        {
            return this._replicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The ARN for the Amazon Security Lake Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the last <c>UpdateDataLake </c>or <c>DeleteDataLake</c> API request.
        /// </para>
        /// </summary>
        public DataLakeUpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}
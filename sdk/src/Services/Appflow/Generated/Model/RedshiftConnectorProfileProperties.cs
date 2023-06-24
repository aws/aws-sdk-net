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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties when using Amazon Redshift.
    /// </summary>
    public partial class RedshiftConnectorProfileProperties
    {
        private string _bucketName;
        private string _bucketPrefix;
        private string _clusterIdentifier;
        private string _dataApiRoleArn;
        private string _databaseName;
        private string _databaseUrl;
        private bool? _isRedshiftServerless;
        private string _roleArn;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  A name for the associated Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property BucketPrefix. 
        /// <para>
        ///  The object key for the destination bucket in which Amazon AppFlow places the files.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string BucketPrefix
        {
            get { return this._bucketPrefix; }
            set { this._bucketPrefix = value; }
        }

        // Check to see if BucketPrefix property is set
        internal bool IsSetBucketPrefix()
        {
            return this._bucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique ID that's assigned to an Amazon Redshift cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DataApiRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that permits Amazon AppFlow to access
        /// your Amazon Redshift database through the Data API. For more information, and for
        /// the polices that you attach to this role, see <a href="https://docs.aws.amazon.com/appflow/latest/userguide/security_iam_service-role-policies.html#access-redshift">Allow
        /// Amazon AppFlow to access Amazon Redshift databases with the Data API</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string DataApiRoleArn
        {
            get { return this._dataApiRoleArn; }
            set { this._dataApiRoleArn = value; }
        }

        // Check to see if DataApiRoleArn property is set
        internal bool IsSetDataApiRoleArn()
        {
            return this._dataApiRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of an Amazon Redshift database.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseUrl. 
        /// <para>
        ///  The JDBC URL of the Amazon Redshift cluster. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string DatabaseUrl
        {
            get { return this._databaseUrl; }
            set { this._databaseUrl = value; }
        }

        // Check to see if DatabaseUrl property is set
        internal bool IsSetDatabaseUrl()
        {
            return this._databaseUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IsRedshiftServerless. 
        /// <para>
        /// Indicates whether the connector profile defines a connection to an Amazon Redshift
        /// Serverless data warehouse.
        /// </para>
        /// </summary>
        public bool IsRedshiftServerless
        {
            get { return this._isRedshiftServerless.GetValueOrDefault(); }
            set { this._isRedshiftServerless = value; }
        }

        // Check to see if IsRedshiftServerless property is set
        internal bool IsSetIsRedshiftServerless()
        {
            return this._isRedshiftServerless.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of IAM role that grants Amazon Redshift read-only
        /// access to Amazon S3. For more information, and for the polices that you attach to
        /// this role, see <a href="https://docs.aws.amazon.com/appflow/latest/userguide/security_iam_service-role-policies.html#redshift-access-s3">Allow
        /// Amazon Redshift to access your Amazon AppFlow data in Amazon S3</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
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

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of an Amazon Redshift workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for Redshift Dataset Definition input.
    /// </summary>
    public partial class RedshiftDatasetDefinition
    {
        private string _clusterId;
        private string _clusterRoleArn;
        private string _database;
        private string _dbUser;
        private string _kmsKeyId;
        private RedshiftResultCompressionType _outputCompression;
        private RedshiftResultFormat _outputFormat;
        private string _outputS3Uri;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property ClusterId.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterRoleArn. 
        /// <para>
        /// The IAM role attached to your Redshift cluster that Amazon SageMaker uses to generate
        /// datasets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ClusterRoleArn
        {
            get { return this._clusterRoleArn; }
            set { this._clusterRoleArn = value; }
        }

        // Check to see if ClusterRoleArn property is set
        internal bool IsSetClusterRoleArn()
        {
            return this._clusterRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Database.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property DbUser.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DbUser
        {
            get { return this._dbUser; }
            set { this._dbUser = value; }
        }

        // Check to see if DbUser property is set
        internal bool IsSetDbUser()
        {
            return this._dbUser != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data from a Redshift execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property OutputCompression.
        /// </summary>
        public RedshiftResultCompressionType OutputCompression
        {
            get { return this._outputCompression; }
            set { this._outputCompression = value; }
        }

        // Check to see if OutputCompression property is set
        internal bool IsSetOutputCompression()
        {
            return this._outputCompression != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat.
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftResultFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The location in Amazon S3 where the Redshift query results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string OutputS3Uri
        {
            get { return this._outputS3Uri; }
            set { this._outputS3Uri = value; }
        }

        // Check to see if OutputS3Uri property is set
        internal bool IsSetOutputS3Uri()
        {
            return this._outputS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}
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
    /// Configuration for Athena Dataset Definition input.
    /// </summary>
    public partial class AthenaDatasetDefinition
    {
        private string _catalog;
        private string _database;
        private string _kmsKeyId;
        private AthenaResultCompressionType _outputCompression;
        private AthenaResultFormat _outputFormat;
        private string _outputS3Uri;
        private string _queryString;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property Catalog.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property Database.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data generated from an Athena query execution.
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
        public AthenaResultCompressionType OutputCompression
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
        public AthenaResultFormat OutputFormat
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
        /// The location in Amazon S3 where Athena query results are stored.
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

        /// <summary>
        /// Gets and sets the property WorkGroup.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}
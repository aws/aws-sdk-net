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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Specifies the Amazon S3 location of a workflow definition file. This structure contains
    /// the bucket name, object key, and optional version ID for the workflow definition.
    /// Amazon Managed Workflows for Apache Airflow Serverless takes a snapshot of the definition
    /// file at the time of workflow creation or update, ensuring that the workflow behavior
    /// remains consistent even if the source file is modified. The definition must be a valid
    /// YAML file that uses supported Amazon Web Services operators and Amazon Managed Workflows
    /// for Apache Airflow Serverless syntax.
    /// </summary>
    public partial class DefinitionS3Location
    {
        private string _bucket;
        private string _objectKey;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket that contains the workflow definition file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectKey. 
        /// <para>
        /// The key (name) of the workflow definition file within the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectKey
        {
            get { return this._objectKey; }
            set { this._objectKey = value; }
        }

        // Check to see if ObjectKey property is set
        internal bool IsSetObjectKey()
        {
            return this._objectKey != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Optional. The version ID of the workflow definition file in Amazon S3. If not specified,
        /// the latest version is used.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}
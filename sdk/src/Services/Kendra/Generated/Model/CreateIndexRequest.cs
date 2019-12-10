/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation.
    /// Creates a new Amazon Kendra index. Index creation is an asynchronous operation. To
    /// determine if index creation has completed, check the <code>Status</code> field returned
    /// from a call to . The <code>Status</code> field is set to <code>ACTIVE</code> when
    /// the index is ready to use.
    /// 
    ///  
    /// <para>
    /// Once the index is active you can index your documents using the operation or using
    /// one of the supported data sources. 
    /// </para>
    /// </summary>
    public partial class CreateIndexRequest : AmazonKendraRequest
    {
        private string _description;
        private string _name;
        private string _roleArn;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An IAM role that gives Amazon Kendra permissions to access your Amazon CloudWatch
        /// logs and metrics. This is also the role used when you use the <code>BatchPutDocument</code>
        /// operation to index documents from an Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
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
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// The identifier of the AWS KMS customer managed key (CMK) to use to encrypt data indexed
        /// by Amazon Kendra. Amazon Kendra doesn't support asymmetric CMKs.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

    }
}
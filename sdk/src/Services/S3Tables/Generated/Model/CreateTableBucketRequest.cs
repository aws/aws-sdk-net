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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTableBucket operation.
    /// Creates a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-create.html">Creating
    /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    /// You must have the <c>s3tables:CreateTableBucket</c> permission to use this operation.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use this operation with the optional <c>encryptionConfiguration</c> parameter
    /// you must have the <c>s3tables:PutTableBucketEncryption</c> permission.
    /// </para>
    ///  </li> </ul> </dd> </dl>
    /// </summary>
    public partial class CreateTableBucketRequest : AmazonS3TablesRequest
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private string _name;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration to use for the table bucket. This configuration specifies
        /// the default encryption settings that will be applied to all tables created in this
        /// bucket unless overridden at the table level. The configuration includes the encryption
        /// algorithm and, if using SSE-KMS, the KMS key to use.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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

    }
}
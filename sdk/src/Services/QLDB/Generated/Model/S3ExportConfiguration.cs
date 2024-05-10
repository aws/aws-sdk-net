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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// The Amazon Simple Storage Service (Amazon S3) bucket location in which a journal export
    /// job writes the journal contents.
    /// </summary>
    public partial class S3ExportConfiguration
    {
        private string _bucket;
        private S3EncryptionConfiguration _encryptionConfiguration;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket name in which a journal export job writes the journal contents.
        /// </para>
        ///  
        /// <para>
        /// The bucket name must comply with the Amazon S3 bucket naming conventions. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption settings that are used by a journal export job to write data in an
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3EncryptionConfiguration EncryptionConfiguration
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
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix for the Amazon S3 bucket in which a journal export job writes the journal
        /// contents.
        /// </para>
        ///  
        /// <para>
        /// The prefix must comply with Amazon S3 key naming rules and restrictions. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html">Object
        /// Key and Metadata</a> in the <i>Amazon S3 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The following are examples of valid <c>Prefix</c> values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JournalExports-ForMyLedger/Testing/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JournalExports</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>My:Tests/</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}
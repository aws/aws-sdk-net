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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Contains the bucket name, file format, bucket owner (optional), and prefix (optional)
    /// where inventory results are published.
    /// </summary>
    public partial class InventoryS3BucketDestination
    {
        private string _accountId;
        private string _bucketName;
        private InventoryEncryption _encryption;
        private InventoryFormat _format;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the destination S3 bucket. If no account ID is provided,
        /// the owner is not validated before exporting data. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Although this value is optional, we strongly recommend that you set it to help prevent
        /// problems if the destination bucket ownership changes. 
        /// </para>
        ///  </note>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket where inventory results will be published.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Encryption. 
        /// <para>
        /// Contains the type of server-side encryption used to encrypt the inventory results.
        /// </para>
        /// </summary>
        public InventoryEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the output format of the inventory results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix that is prepended to all inventory results.
        /// </para>
        /// </summary>
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
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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// The Amazon S3 data access that is the asset.
    /// </summary>
    public partial class S3DataAccessAsset
    {
        private string _bucket;
        private List<string> _keyPrefixes = new List<string>();
        private List<string> _keys = new List<string>();
        private List<KmsKeyToGrant> _kmsKeysToGrant = new List<KmsKeyToGrant>();
        private string _s3AccessPointAlias;
        private string _s3AccessPointArn;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket hosting data to be shared in the S3 data access.
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
        /// Gets and sets the property KeyPrefixes. 
        /// <para>
        /// The Amazon S3 bucket used for hosting shared data in the Amazon S3 data access.
        /// </para>
        /// </summary>
        public List<string> KeyPrefixes
        {
            get { return this._keyPrefixes; }
            set { this._keyPrefixes = value; }
        }

        // Check to see if KeyPrefixes property is set
        internal bool IsSetKeyPrefixes()
        {
            return this._keyPrefixes != null && this._keyPrefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// S3 keys made available using this asset.
        /// </para>
        /// </summary>
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && this._keys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeysToGrant. 
        /// <para>
        ///  List of AWS KMS CMKs (Key Management System Customer Managed Keys) and ARNs used
        /// to encrypt S3 objects being shared in this S3 Data Access asset. Providers must include
        /// all AWS KMS keys used to encrypt these shared S3 objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<KmsKeyToGrant> KmsKeysToGrant
        {
            get { return this._kmsKeysToGrant; }
            set { this._kmsKeysToGrant = value; }
        }

        // Check to see if KmsKeysToGrant property is set
        internal bool IsSetKmsKeysToGrant()
        {
            return this._kmsKeysToGrant != null && this._kmsKeysToGrant.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3AccessPointAlias. 
        /// <para>
        /// The automatically-generated bucket-style alias for your Amazon S3 Access Point. Customers
        /// can access their entitled data using the S3 Access Point alias.
        /// </para>
        /// </summary>
        public string S3AccessPointAlias
        {
            get { return this._s3AccessPointAlias; }
            set { this._s3AccessPointAlias = value; }
        }

        // Check to see if S3AccessPointAlias property is set
        internal bool IsSetS3AccessPointAlias()
        {
            return this._s3AccessPointAlias != null;
        }

        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// The ARN for your Amazon S3 Access Point. Customers can also access their entitled
        /// data using the S3 Access Point ARN.
        /// </para>
        /// </summary>
        public string S3AccessPointArn
        {
            get { return this._s3AccessPointArn; }
            set { this._s3AccessPointArn = value; }
        }

        // Check to see if S3AccessPointArn property is set
        internal bool IsSetS3AccessPointArn()
        {
            return this._s3AccessPointArn != null;
        }

    }
}
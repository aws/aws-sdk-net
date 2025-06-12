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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Source details for an Amazon S3 data access asset.
    /// </summary>
    public partial class S3DataAccessAssetSourceEntry
    {
        private string _bucket;
        private List<string> _keyPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _keys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<KmsKeyToGrant> _kmsKeysToGrant = AWSConfigs.InitializeCollections ? new List<KmsKeyToGrant>() : null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket used for hosting shared data in the Amazon S3 data access.
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
        /// Organizes Amazon S3 asset key prefixes stored in an Amazon S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyPrefixes
        {
            get { return this._keyPrefixes; }
            set { this._keyPrefixes = value; }
        }

        // Check to see if KeyPrefixes property is set
        internal bool IsSetKeyPrefixes()
        {
            return this._keyPrefixes != null && (this._keyPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The keys used to create the Amazon S3 data access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && (this._keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeysToGrant. 
        /// <para>
        /// List of AWS KMS CMKs (Key Management System Customer Managed Keys) and ARNs used to
        /// encrypt S3 objects being shared in this S3 Data Access asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._kmsKeysToGrant != null && (this._kmsKeysToGrant.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
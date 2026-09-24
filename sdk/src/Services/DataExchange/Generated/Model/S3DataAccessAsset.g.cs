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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The Amazon S3 data access that is the asset.
    /// </summary>
    public partial class S3DataAccessAsset
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket hosting data to be shared in the S3 data access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property KeyPrefixes. 
        /// <para>
        /// The Amazon S3 bucket used for hosting shared data in the Amazon S3 data access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyPrefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyPrefixes property is set.
        /// </summary>
        internal bool IsSetKeyPrefixes() => this.KeyPrefixes != null && (this.KeyPrefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// S3 keys made available using this asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Keys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeysToGrant. 
        /// <para>
        ///  List of AWS KMS CMKs (Key Management System Customer Managed Keys) and ARNs used
        /// to encrypt S3 objects being shared in this S3 Data Access asset. Providers must include
        /// all AWS KMS keys used to encrypt these shared S3 objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<KmsKeyToGrant> KmsKeysToGrant { get; set; } = AWSConfigs.InitializeCollections ? new List<KmsKeyToGrant>() : null;

        /// <summary>
        /// Checks to see if the KmsKeysToGrant property is set.
        /// </summary>
        internal bool IsSetKmsKeysToGrant() => this.KmsKeysToGrant != null && (this.KmsKeysToGrant.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3AccessPointAlias. 
        /// <para>
        /// The automatically-generated bucket-style alias for your Amazon S3 Access Point. Customers
        /// can access their entitled data using the S3 Access Point alias.
        /// </para>
        /// </summary>
        public string S3AccessPointAlias { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPointAlias property is set.
        /// </summary>
        internal bool IsSetS3AccessPointAlias() => this.S3AccessPointAlias != null;

        /// <summary>
        /// Gets and sets the property S3AccessPointArn. 
        /// <para>
        /// The ARN for your Amazon S3 Access Point. Customers can also access their entitled
        /// data using the S3 Access Point ARN.
        /// </para>
        /// </summary>
        public string S3AccessPointArn { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPointArn property is set.
        /// </summary>
        internal bool IsSetS3AccessPointArn() => this.S3AccessPointArn != null;
    }
}

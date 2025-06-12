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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTapes operation.
    /// Creates one or more virtual tapes. You write data to the virtual tapes and then archive
    /// the tapes. This operation is only supported in the tape gateway type.
    /// 
    ///  <note> 
    /// <para>
    /// Cache storage must be allocated to the gateway before you can create virtual tapes.
    /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateTapesRequest : AmazonStorageGatewayRequest
    {
        private string _clientToken;
        private string _gatewayARN;
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private int? _numTapesToCreate;
        private string _poolId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _tapeBarcodePrefix;
        private long? _tapeSizeInBytes;
        private bool? _worm;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you use to retry a request. If you retry a request, use the
        /// same <c>ClientToken</c> you specified in the initial request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Using the same <c>ClientToken</c> prevents creating the tape multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) that represents the gateway to associate the
        /// virtual tapes with. Use the <a>ListGateways</a> operation to return a list of gateways
        /// for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// Set to <c>true</c> to use Amazon S3 server-side encryption with your own KMS key,
        /// or <c>false</c> to use a key managed by Amazon S3. Optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>true</c> | <c>false</c> 
        /// </para>
        /// </summary>
        public bool? KMSEncrypted
        {
            get { return this._kmsEncrypted; }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <c>KMSEncrypted</c> is <c>true</c>. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property NumTapesToCreate. 
        /// <para>
        /// The number of virtual tapes that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? NumTapesToCreate
        {
            get { return this._numTapesToCreate; }
            set { this._numTapesToCreate = value; }
        }

        // Check to see if NumTapesToCreate property is set
        internal bool IsSetNumTapesToCreate()
        {
            return this._numTapesToCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that you want to add your tape to for archiving. The tape in this
        /// pool is archived in the S3 storage class that is associated with the pool. When you
        /// use your backup application to eject the tape, the tape is archived directly into
        /// the storage class (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the
        /// pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to a virtual tape. Each tag is a key-value
        /// pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TapeBarcodePrefix. 
        /// <para>
        /// A prefix that you append to the barcode of the virtual tape you are creating. This
        /// prefix makes the barcode unique.
        /// </para>
        ///  <note> 
        /// <para>
        /// The prefix must be 1-4 characters in length and must be one of the uppercase letters
        /// from A to Z.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public string TapeBarcodePrefix
        {
            get { return this._tapeBarcodePrefix; }
            set { this._tapeBarcodePrefix = value; }
        }

        // Check to see if TapeBarcodePrefix property is set
        internal bool IsSetTapeBarcodePrefix()
        {
            return this._tapeBarcodePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tapes that you want to create.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size must be aligned by gigabyte (1024*1024*1024 bytes).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TapeSizeInBytes
        {
            get { return this._tapeSizeInBytes; }
            set { this._tapeSizeInBytes = value; }
        }

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this._tapeSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Worm. 
        /// <para>
        /// Set to <c>TRUE</c> if the tape you are creating is to be configured as a write-once-read-many
        /// (WORM) tape.
        /// </para>
        /// </summary>
        public bool? Worm
        {
            get { return this._worm; }
            set { this._worm = value; }
        }

        // Check to see if Worm property is set
        internal bool IsSetWorm()
        {
            return this._worm.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _tapeBarcodePrefix;
        private long? _tapeSizeInBytes;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you use to retry a request. If you retry a request, use the
        /// same <code>ClientToken</code> you specified in the initial request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Using the same <code>ClientToken</code> prevents creating the tape multiple times.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// for your account and region.
        /// </para>
        /// </summary>
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
        /// True to use Amazon S3 server side encryption with your own AWS KMS key, or false to
        /// use a key managed by Amazon S3. Optional.
        /// </para>
        /// </summary>
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of the AWS KMS key used for Amazon S3 server side encryption.
        /// This value can only be set when KMSEncrypted is true. Optional.
        /// </para>
        /// </summary>
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
        public int NumTapesToCreate
        {
            get { return this._numTapesToCreate.GetValueOrDefault(); }
            set { this._numTapesToCreate = value; }
        }

        // Check to see if NumTapesToCreate property is set
        internal bool IsSetNumTapesToCreate()
        {
            return this._numTapesToCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeBarcodePrefix. 
        /// <para>
        /// A prefix that you append to the barcode of the virtual tape you are creating. This
        /// prefix makes the barcode unique.
        /// </para>
        ///  <note> 
        /// <para>
        /// The prefix must be 1 to 4 characters in length and must be one of the uppercase letters
        /// from A to Z.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// The size must be aligned by gigabyte (1024*1024*1024 byte).
        /// </para>
        ///  </note>
        /// </summary>
        public long TapeSizeInBytes
        {
            get { return this._tapeSizeInBytes.GetValueOrDefault(); }
            set { this._tapeSizeInBytes = value; }
        }

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this._tapeSizeInBytes.HasValue; 
        }

    }
}
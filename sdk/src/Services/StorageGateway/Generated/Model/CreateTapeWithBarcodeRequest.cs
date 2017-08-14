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
    /// Container for the parameters to the CreateTapeWithBarcode operation.
    /// Creates a virtual tape by using your own barcode. You write data to the virtual tape
    /// and then archive the tape. A barcode is unique and can not be reused if it has already
    /// been used on a tape . This applies to barcodes used on deleted tapes. This operation
    /// is only supported in the tape gateway. architecture.
    /// 
    ///  <note> 
    /// <para>
    /// Cache storage must be allocated to the gateway before you can create a virtual tape.
    /// Use the <a>AddCache</a> operation to add cache storage to a gateway.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateTapeWithBarcodeRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private string _tapeBarcode;
        private long? _tapeSizeInBytes;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) that represents the gateway to associate the
        /// virtual tape with. Use the <a>ListGateways</a> operation to return a list of gateways
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
        /// Gets and sets the property TapeBarcode. 
        /// <para>
        /// The barcode that you want to assign to the tape.
        /// </para>
        ///  <note> 
        /// <para>
        /// Barcodes cannot be reused. This includes barcodes used for tapes that have been deleted.
        /// </para>
        ///  </note>
        /// </summary>
        public string TapeBarcode
        {
            get { return this._tapeBarcode; }
            set { this._tapeBarcode = value; }
        }

        // Check to see if TapeBarcode property is set
        internal bool IsSetTapeBarcode()
        {
            return this._tapeBarcode != null;
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tape that you want to create.
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
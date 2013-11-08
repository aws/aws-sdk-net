/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Creates one or more virtual tapes. You write data to the virtual tapes and then archive the tapes.</para> <para><b>NOTE:</b>Cache
    /// storage must be allocated to the gateway before you can create virtual tapes. Use the AddCache operation to add cache storage to a gateway.
    /// </para>
    /// </summary>
    public partial class CreateTapesRequest : AmazonStorageGatewayRequest
    {
        private string gatewayARN;
        private long? tapeSizeInBytes;
        private string clientToken;
        private int? numTapesToCreate;
        private string tapeBarcodePrefix;


        /// <summary>
        /// The unique Amazon Resource Name(ARN) that represents the gateway to associate the virtual tapes with. Use the <a>ListGateways</a> operation
        /// to return a list of gateways for your account and region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }

        /// <summary>
        /// The size, in bytes, of the virtual tapes you want to create. <note>The size must be gigabyte (1024*1024*1024 byte) aligned.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>107374182400 - 2748779069440</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long TapeSizeInBytes
        {
            get { return this.tapeSizeInBytes ?? default(long); }
            set { this.tapeSizeInBytes = value; }
        }

        // Check to see if TapeSizeInBytes property is set
        internal bool IsSetTapeSizeInBytes()
        {
            return this.tapeSizeInBytes.HasValue;
        }

        /// <summary>
        /// A unique identifier that you use to retry a request. If you retry a request, use the same <c>ClientToken</c> you specified in the initial
        /// request. <note>Using the same <c>ClientToken</c> prevents creating the tape multiple times.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>5 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

        /// <summary>
        /// The number of virtual tapes you want to create.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int NumTapesToCreate
        {
            get { return this.numTapesToCreate ?? default(int); }
            set { this.numTapesToCreate = value; }
        }

        // Check to see if NumTapesToCreate property is set
        internal bool IsSetNumTapesToCreate()
        {
            return this.numTapesToCreate.HasValue;
        }

        /// <summary>
        /// A prefix you append to the barcode of the virtual tape you are creating. This makes a barcode unique. <note>The prefix must be 1 to 4
        /// characters in length and must be upper-case letters A-Z.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 4</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^[A-Z]*$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TapeBarcodePrefix
        {
            get { return this.tapeBarcodePrefix; }
            set { this.tapeBarcodePrefix = value; }
        }

        // Check to see if TapeBarcodePrefix property is set
        internal bool IsSetTapeBarcodePrefix()
        {
            return this.tapeBarcodePrefix != null;
        }

    }
}
    

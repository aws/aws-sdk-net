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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a virtual tape.
    /// </summary>
    public partial class TapeInfo
    {
        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string GatewayARN { get; set; }

        /// <summary>
        /// Checks to see if the GatewayARN property is set.
        /// </summary>
        internal bool IsSetGatewayARN() => this.GatewayARN != null;

        /// <summary>
        /// Gets and sets the property PoolEntryDate. 
        /// <para>
        /// The date that the tape entered the custom tape pool with tape retention lock enabled.
        /// </para>
        /// </summary>
        public DateTime? PoolEntryDate { get; set; }

        /// <summary>
        /// Checks to see if the PoolEntryDate property is set.
        /// </summary>
        internal bool IsSetPoolEntryDate() => this.PoolEntryDate.HasValue;

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
        [AWSProperty(Min = 1, Max = 100)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property RetentionStartDate. 
        /// <para>
        /// The date that the tape became subject to tape retention lock.
        /// </para>
        /// </summary>
        public DateTime? RetentionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the RetentionStartDate property is set.
        /// </summary>
        internal bool IsSetRetentionStartDate() => this.RetentionStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string TapeARN { get; set; }

        /// <summary>
        /// Checks to see if the TapeARN property is set.
        /// </summary>
        internal bool IsSetTapeARN() => this.TapeARN != null;

        /// <summary>
        /// Gets and sets the property TapeBarcode. 
        /// <para>
        /// The barcode that identifies a specific virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 16)]
        public string TapeBarcode { get; set; }

        /// <summary>
        /// Checks to see if the TapeBarcode property is set.
        /// </summary>
        internal bool IsSetTapeBarcode() => this.TapeBarcode != null;

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a virtual tape.
        /// </para>
        /// </summary>
        public long? TapeSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the TapeSizeInBytes property is set.
        /// </summary>
        internal bool IsSetTapeSizeInBytes() => this.TapeSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TapeStatus. 
        /// <para>
        /// The status of the tape.
        /// </para>
        /// </summary>
        public string TapeStatus { get; set; }

        /// <summary>
        /// Checks to see if the TapeStatus property is set.
        /// </summary>
        internal bool IsSetTapeStatus() => this.TapeStatus != null;
    }
}

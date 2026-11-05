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
    /// An automatic tape creation policy consists of automatic tape creation rules where
    /// each rule defines when and how to create new tapes. For more information about automatic
    /// tape creation, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/GettingStartedCreateTapes.html#CreateTapesAutomatically">Creating
    /// Tapes Automatically</a>.
    /// </summary>
    public partial class AutomaticTapeCreationRule
    {
        /// <summary>
        /// Gets and sets the property MinimumNumTapes. 
        /// <para>
        /// The minimum number of available virtual tapes that the gateway maintains at all times.
        /// If the number of tapes on the gateway goes below this value, the gateway creates as
        /// many new tapes as are needed to have <c>MinimumNumTapes</c> on the gateway. For more
        /// information about automatic tape creation, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/GettingStartedCreateTapes.html#CreateTapesAutomatically">Creating
        /// Tapes Automatically</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? MinimumNumTapes { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNumTapes property is set.
        /// </summary>
        internal bool IsSetMinimumNumTapes() => this.MinimumNumTapes.HasValue;

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that you want to add your tape to for archiving. The tape in this
        /// pool is archived in the Amazon S3 storage class that is associated with the pool.
        /// When you use your backup application to eject the tape, the tape is archived directly
        /// into the storage class (S3 Glacier or S3 Glacier Deep Archive) that corresponds to
        /// the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property TapeBarcodePrefix. 
        /// <para>
        /// A prefix that you append to the barcode of the virtual tape that you are creating.
        /// This prefix makes the barcode unique.
        /// </para>
        ///  <note> 
        /// <para>
        /// The prefix must be 1-4 characters in length and must be one of the uppercase letters
        /// from A to Z.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public string TapeBarcodePrefix { get; set; }

        /// <summary>
        /// Checks to see if the TapeBarcodePrefix property is set.
        /// </summary>
        internal bool IsSetTapeBarcodePrefix() => this.TapeBarcodePrefix != null;

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tape capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? TapeSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the TapeSizeInBytes property is set.
        /// </summary>
        internal bool IsSetTapeSizeInBytes() => this.TapeSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Worm. 
        /// <para>
        /// Set to <c>true</c> to indicate that tapes are to be archived as write-once-read-many
        /// (WORM). Set to <c>false</c> when WORM is not enabled for tapes.
        /// </para>
        /// </summary>
        public bool? Worm { get; set; }

        /// <summary>
        /// Checks to see if the Worm property is set.
        /// </summary>
        internal bool IsSetWorm() => this.Worm.HasValue;
    }
}

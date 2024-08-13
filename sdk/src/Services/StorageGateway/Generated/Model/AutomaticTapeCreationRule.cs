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
    /// An automatic tape creation policy consists of automatic tape creation rules where
    /// each rule defines when and how to create new tapes. For more information about automatic
    /// tape creation, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/GettingStartedCreateTapes.html#CreateTapesAutomatically">Creating
    /// Tapes Automatically</a>.
    /// </summary>
    public partial class AutomaticTapeCreationRule
    {
        private int? _minimumNumTapes;
        private string _poolId;
        private string _tapeBarcodePrefix;
        private long? _tapeSizeInBytes;
        private bool? _worm;

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
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? MinimumNumTapes
        {
            get { return this._minimumNumTapes; }
            set { this._minimumNumTapes = value; }
        }

        // Check to see if MinimumNumTapes property is set
        internal bool IsSetMinimumNumTapes()
        {
            return this._minimumNumTapes.HasValue; 
        }

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
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// The size, in bytes, of the virtual tape capacity.
        /// </para>
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
        /// Set to <c>true</c> to indicate that tapes are to be archived as write-once-read-many
        /// (WORM). Set to <c>false</c> when WORM is not enabled for tapes.
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
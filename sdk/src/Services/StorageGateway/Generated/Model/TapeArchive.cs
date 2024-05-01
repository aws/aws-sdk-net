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
    /// Represents a virtual tape that is archived in the virtual tape shelf (VTS).
    /// </summary>
    public partial class TapeArchive
    {
        private DateTime? _completionTime;
        private string _kmsKey;
        private DateTime? _poolEntryDate;
        private string _poolId;
        private DateTime? _retentionStartDate;
        private string _retrievedTo;
        private string _tapeARN;
        private string _tapeBarcode;
        private DateTime? _tapeCreatedDate;
        private long? _tapeSizeInBytes;
        private string _tapeStatus;
        private long? _tapeUsedInBytes;
        private bool? _worm;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The time that the archiving of the virtual tape was completed.
        /// </para>
        ///  
        /// <para>
        /// The default timestamp format is in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z' format.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey.
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
        /// Gets and sets the property PoolEntryDate. 
        /// <para>
        /// The time that the tape entered the custom tape pool.
        /// </para>
        ///  
        /// <para>
        /// The default timestamp format is in the ISO8601 extended YYYY-MM-DD'T'HH:MM:SS'Z' format.
        /// </para>
        /// </summary>
        public DateTime? PoolEntryDate
        {
            get { return this._poolEntryDate; }
            set { this._poolEntryDate = value; }
        }

        // Check to see if PoolEntryDate property is set
        internal bool IsSetPoolEntryDate()
        {
            return this._poolEntryDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that was used to archive the tape. The tapes in this pool are archived
        /// in the S3 storage class that is associated with the pool.
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
        /// Gets and sets the property RetentionStartDate. 
        /// <para>
        /// If the archived tape is subject to tape retention lock, the date that the archived
        /// tape started being retained.
        /// </para>
        /// </summary>
        public DateTime? RetentionStartDate
        {
            get { return this._retentionStartDate; }
            set { this._retentionStartDate = value; }
        }

        // Check to see if RetentionStartDate property is set
        internal bool IsSetRetentionStartDate()
        {
            return this._retentionStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetrievedTo. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tape gateway that the virtual tape is being
        /// retrieved to.
        /// </para>
        ///  
        /// <para>
        /// The virtual tape is retrieved from the virtual tape shelf (VTS).
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string RetrievedTo
        {
            get { return this._retrievedTo; }
            set { this._retrievedTo = value; }
        }

        // Check to see if RetrievedTo property is set
        internal bool IsSetRetrievedTo()
        {
            return this._retrievedTo != null;
        }

        /// <summary>
        /// Gets and sets the property TapeARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an archived virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string TapeARN
        {
            get { return this._tapeARN; }
            set { this._tapeARN = value; }
        }

        // Check to see if TapeARN property is set
        internal bool IsSetTapeARN()
        {
            return this._tapeARN != null;
        }

        /// <summary>
        /// Gets and sets the property TapeBarcode. 
        /// <para>
        /// The barcode that identifies the archived virtual tape.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=16)]
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
        /// Gets and sets the property TapeCreatedDate. 
        /// <para>
        /// The date the virtual tape was created.
        /// </para>
        /// </summary>
        public DateTime? TapeCreatedDate
        {
            get { return this._tapeCreatedDate; }
            set { this._tapeCreatedDate = value; }
        }

        // Check to see if TapeCreatedDate property is set
        internal bool IsSetTapeCreatedDate()
        {
            return this._tapeCreatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the archived virtual tape.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TapeStatus. 
        /// <para>
        /// The current state of the archived virtual tape.
        /// </para>
        /// </summary>
        public string TapeStatus
        {
            get { return this._tapeStatus; }
            set { this._tapeStatus = value; }
        }

        // Check to see if TapeStatus property is set
        internal bool IsSetTapeStatus()
        {
            return this._tapeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TapeUsedInBytes. 
        /// <para>
        /// The size, in bytes, of data stored on the virtual tape.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is not available for tapes created prior to May 13, 2015.
        /// </para>
        ///  </note>
        /// </summary>
        public long? TapeUsedInBytes
        {
            get { return this._tapeUsedInBytes; }
            set { this._tapeUsedInBytes = value; }
        }

        // Check to see if TapeUsedInBytes property is set
        internal bool IsSetTapeUsedInBytes()
        {
            return this._tapeUsedInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Worm. 
        /// <para>
        /// Set to <c>true</c> if the archived tape is stored as write-once-read-many (WORM).
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
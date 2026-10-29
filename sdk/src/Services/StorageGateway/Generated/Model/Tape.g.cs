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
    /// Describes a virtual tape object.
    /// </summary>
    public partial class Tape
    {
        /// <summary>
        /// Gets and sets the property KMSKey.
        /// </summary>
        [AWSProperty(Min = 7, Max = 2048)]
        public string KMSKey { get; set; }

        /// <summary>
        /// Checks to see if the KMSKey property is set.
        /// </summary>
        internal bool IsSetKMSKey() => this.KMSKey != null;

        /// <summary>
        /// Gets and sets the property PoolEntryDate. 
        /// <para>
        /// The date that the tape enters a custom tape pool.
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
        /// The ID of the pool that contains tapes that will be archived. The tapes in this pool
        /// are archived in the S3 storage class that is associated with the pool. When you use
        /// your backup application to eject the tape, the tape is archived directly into the
        /// storage class (S3 Glacier or S3 Glacier Deep Archive) that corresponds to the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// For archiving virtual tapes, indicates how much data remains to be uploaded before
        /// archiving is complete.
        /// </para>
        ///  
        /// <para>
        /// Range: 0 (not started) to 100 (complete).
        /// </para>
        /// </summary>
        public double? Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionStartDate. 
        /// <para>
        /// The date that the tape is first archived with tape retention lock enabled.
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
        /// The Amazon Resource Name (ARN) of the virtual tape.
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
        /// Gets and sets the property TapeCreatedDate. 
        /// <para>
        /// The date the virtual tape was created.
        /// </para>
        /// </summary>
        public DateTime? TapeCreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the TapeCreatedDate property is set.
        /// </summary>
        internal bool IsSetTapeCreatedDate() => this.TapeCreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property TapeSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the virtual tape capacity.
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
        /// The current state of the virtual tape.
        /// </para>
        /// </summary>
        public string TapeStatus { get; set; }

        /// <summary>
        /// Checks to see if the TapeStatus property is set.
        /// </summary>
        internal bool IsSetTapeStatus() => this.TapeStatus != null;

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
        public long? TapeUsedInBytes { get; set; }

        /// <summary>
        /// Checks to see if the TapeUsedInBytes property is set.
        /// </summary>
        internal bool IsSetTapeUsedInBytes() => this.TapeUsedInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property VTLDevice. 
        /// <para>
        /// The virtual tape library (VTL) device that the virtual tape is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string VTLDevice { get; set; }

        /// <summary>
        /// Checks to see if the VTLDevice property is set.
        /// </summary>
        internal bool IsSetVTLDevice() => this.VTLDevice != null;

        /// <summary>
        /// Gets and sets the property Worm. 
        /// <para>
        /// If the tape is archived as write-once-read-many (WORM), this value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Worm { get; set; }

        /// <summary>
        /// Checks to see if the Worm property is set.
        /// </summary>
        internal bool IsSetWorm() => this.Worm.HasValue;
    }
}

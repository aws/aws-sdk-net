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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the client-specific data.
    /// </summary>
    public partial class ClientData
    {
        private string _comment;
        private DateTime? _uploadEndUtc;
        private double? _uploadSize;
        private DateTime? _uploadStartUtc;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A user-defined comment about the disk upload.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property UploadEndUtc. 
        /// <para>
        /// The time that the disk upload ends.
        /// </para>
        /// </summary>
        public DateTime UploadEndUtc
        {
            get { return this._uploadEndUtc.GetValueOrDefault(); }
            set { this._uploadEnd = this._uploadEndUtc = value; }
        }

        // Check to see if UploadEndUtc property is set
        internal bool IsSetUploadEndUtc()
        {
            return this._uploadEndUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadSize. 
        /// <para>
        /// The size of the uploaded disk image, in GiB.
        /// </para>
        /// </summary>
        public double UploadSize
        {
            get { return this._uploadSize.GetValueOrDefault(); }
            set { this._uploadSize = value; }
        }

        // Check to see if UploadSize property is set
        internal bool IsSetUploadSize()
        {
            return this._uploadSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadStartUtc. 
        /// <para>
        /// The time that the disk upload starts.
        /// </para>
        /// </summary>
        public DateTime UploadStartUtc
        {
            get { return this._uploadStartUtc.GetValueOrDefault(); }
            set { this._uploadStart = this._uploadStartUtc = value; }
        }

        // Check to see if UploadStartUtc property is set
        internal bool IsSetUploadStartUtc()
        {
            return this._uploadStartUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _uploadEnd;
        private DateTime? _uploadStart;

        /// <summary>
        /// Gets and sets the property UploadEndUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use UploadEndUtc instead. Setting either UploadEnd or
        /// UploadEndUtc results in both UploadEnd and UploadEndUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. UploadEnd
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time that the disk upload ends.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use UploadEndUtc instead. Setting either UploadEnd or UploadEndUtc results in both UploadEnd and " +
            "UploadEndUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. UploadEnd is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime UploadEnd
        {
            get { return this._uploadEnd.GetValueOrDefault(); }
            set
            {
                this._uploadEnd = value;
                this._uploadEndUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property UploadStartUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use UploadStartUtc instead. Setting either UploadStart
        /// or UploadStartUtc results in both UploadStart and UploadStartUtc being assigned, the
        /// latest assignment to either one of the two property is reflected in the value of both.
        /// UploadStart is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time that the disk upload starts.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use UploadStartUtc instead. Setting either UploadStart or UploadStartUtc results in both UploadStart and " +
            "UploadStartUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. UploadStart is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime UploadStart
        {
            get { return this._uploadStart.GetValueOrDefault(); }
            set
            {
                this._uploadStart = value;
                this._uploadStartUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}
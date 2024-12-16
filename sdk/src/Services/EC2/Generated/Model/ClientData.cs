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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the client-specific data.
    /// </summary>
    public partial class ClientData
    {
        private string _comment;
        private DateTime? _uploadEnd;
        private double? _uploadSize;
        private DateTime? _uploadStart;

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
        /// Gets and sets the property UploadEnd. 
        /// <para>
        /// The time that the disk upload ends.
        /// </para>
        /// </summary>
        public DateTime? UploadEnd
        {
            get { return this._uploadEnd; }
            set { this._uploadEnd = value; }
        }

        // Check to see if UploadEnd property is set
        internal bool IsSetUploadEnd()
        {
            return this._uploadEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadSize. 
        /// <para>
        /// The size of the uploaded disk image, in GiB.
        /// </para>
        /// </summary>
        public double? UploadSize
        {
            get { return this._uploadSize; }
            set { this._uploadSize = value; }
        }

        // Check to see if UploadSize property is set
        internal bool IsSetUploadSize()
        {
            return this._uploadSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadStart. 
        /// <para>
        /// The time that the disk upload starts.
        /// </para>
        /// </summary>
        public DateTime? UploadStart
        {
            get { return this._uploadStart; }
            set { this._uploadStart = value; }
        }

        // Check to see if UploadStart property is set
        internal bool IsSetUploadStart()
        {
            return this._uploadStart.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// The metadata of a single part of a file that was added to a multipart upload. A list
    /// of these parts is returned in the response to the ListReadSetUploadParts API.
    /// </summary>
    public partial class ReadSetUploadPartListItem
    {
        private string _checksum;
        private DateTime? _creationTime;
        private DateTime? _lastUpdatedTime;
        private int? _partNumber;
        private long? _partSize;
        private ReadSetPartSource _partSource;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        ///  A unique identifier used to confirm that parts are being added to the correct upload.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time stamp for when a direct upload was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        ///  The time stamp for the most recent update to an uploaded part. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        ///  The number identifying the part in an upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public int? PartNumber
        {
            get { return this._partNumber; }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartSize. 
        /// <para>
        ///  The size of the the part in an upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5368709120)]
        public long? PartSize
        {
            get { return this._partSize; }
            set { this._partSize = value; }
        }

        // Check to see if PartSize property is set
        internal bool IsSetPartSize()
        {
            return this._partSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartSource. 
        /// <para>
        ///  The origin of the part being direct uploaded. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadSetPartSource PartSource
        {
            get { return this._partSource; }
            set { this._partSource = value; }
        }

        // Check to see if PartSource property is set
        internal bool IsSetPartSource()
        {
            return this._partSource != null;
        }

    }
}
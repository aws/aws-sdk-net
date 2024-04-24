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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
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
namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Object
    /// </summary>
    public partial class BackupObject
    {
        private long? _chunksCount;
        private string _metadataString;
        private string _name;
        private string _objectChecksum;
        private SummaryChecksumAlgorithm _objectChecksumAlgorithm;
        private string _objectToken;

        /// <summary>
        /// Gets and sets the property ChunksCount. Number of chunks in object
        /// </summary>
        public long ChunksCount
        {
            get { return this._chunksCount.GetValueOrDefault(); }
            set { this._chunksCount = value; }
        }

        // Check to see if ChunksCount property is set
        internal bool IsSetChunksCount()
        {
            return this._chunksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataString. Metadata string associated with the Object
        /// </summary>
        public string MetadataString
        {
            get { return this._metadataString; }
            set { this._metadataString = value; }
        }

        // Check to see if MetadataString property is set
        internal bool IsSetMetadataString()
        {
            return this._metadataString != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Object name
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectChecksum. Object checksum
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectChecksum
        {
            get { return this._objectChecksum; }
            set { this._objectChecksum = value; }
        }

        // Check to see if ObjectChecksum property is set
        internal bool IsSetObjectChecksum()
        {
            return this._objectChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectChecksumAlgorithm. Checksum algorithm
        /// </summary>
        [AWSProperty(Required=true)]
        public SummaryChecksumAlgorithm ObjectChecksumAlgorithm
        {
            get { return this._objectChecksumAlgorithm; }
            set { this._objectChecksumAlgorithm = value; }
        }

        // Check to see if ObjectChecksumAlgorithm property is set
        internal bool IsSetObjectChecksumAlgorithm()
        {
            return this._objectChecksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectToken. Object token
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectToken
        {
            get { return this._objectToken; }
            set { this._objectToken = value; }
        }

        // Check to see if ObjectToken property is set
        internal bool IsSetObjectToken()
        {
            return this._objectToken != null;
        }

    }
}
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
    /// This is the response object from the PutObject operation.
    /// </summary>
    public partial class PutObjectResponse : AmazonWebServiceResponse
    {
        private string _inlineChunkChecksum;
        private DataChecksumAlgorithm _inlineChunkChecksumAlgorithm;
        private string _objectChecksum;
        private SummaryChecksumAlgorithm _objectChecksumAlgorithm;

        /// <summary>
        /// Gets and sets the property InlineChunkChecksum. Inline chunk checksum
        /// </summary>
        [AWSProperty(Required=true)]
        public string InlineChunkChecksum
        {
            get { return this._inlineChunkChecksum; }
            set { this._inlineChunkChecksum = value; }
        }

        // Check to see if InlineChunkChecksum property is set
        internal bool IsSetInlineChunkChecksum()
        {
            return this._inlineChunkChecksum != null;
        }

        /// <summary>
        /// Gets and sets the property InlineChunkChecksumAlgorithm. Inline chunk checksum algorithm
        /// </summary>
        [AWSProperty(Required=true)]
        public DataChecksumAlgorithm InlineChunkChecksumAlgorithm
        {
            get { return this._inlineChunkChecksumAlgorithm; }
            set { this._inlineChunkChecksumAlgorithm = value; }
        }

        // Check to see if InlineChunkChecksumAlgorithm property is set
        internal bool IsSetInlineChunkChecksumAlgorithm()
        {
            return this._inlineChunkChecksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectChecksum. object checksum
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
        /// Gets and sets the property ObjectChecksumAlgorithm. object checksum algorithm
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

    }
}
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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Outposts.Model
{
    /// <summary>
    /// Contains the details for the Outpost object.
    /// </summary>
    public partial class Outpost
    {
        private long? _capacityInBytes;
        private string _outpostArn;
        private string _outpostId;
        private string _ownerId;

        /// <summary>
        /// Gets and sets the property CapacityInBytes. 
        /// <para>
        /// The Amazon S3 capacity of the outpost in bytes.
        /// </para>
        /// </summary>
        public long CapacityInBytes
        {
            get { return this._capacityInBytes.GetValueOrDefault(); }
            set { this._capacityInBytes = value; }
        }

        // Check to see if CapacityInBytes property is set
        internal bool IsSetCapacityInBytes()
        {
            return this._capacityInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// Specifies the unique identifier for the outpost.
        /// </para>
        /// </summary>
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// Returns the Amazon Web Services account ID of the outpost owner. Useful for comparing
        /// owned versus shared outposts.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

    }
}
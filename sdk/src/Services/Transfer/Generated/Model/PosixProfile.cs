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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PosixProfile
    {
        private long? _gid;
        private List<long> _secondaryGids = new List<long>();
        private long? _uid;

        /// <summary>
        /// Gets and sets the property Gid.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long Gid
        {
            get { return this._gid.GetValueOrDefault(); }
            set { this._gid = value; }
        }

        // Check to see if Gid property is set
        internal bool IsSetGid()
        {
            return this._gid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryGids.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<long> SecondaryGids
        {
            get { return this._secondaryGids; }
            set { this._secondaryGids = value; }
        }

        // Check to see if SecondaryGids property is set
        internal bool IsSetSecondaryGids()
        {
            return this._secondaryGids != null && this._secondaryGids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Uid.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=4294967295)]
        public long Uid
        {
            get { return this._uid.GetValueOrDefault(); }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid.HasValue; 
        }

    }
}
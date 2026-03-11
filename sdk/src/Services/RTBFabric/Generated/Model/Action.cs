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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
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
namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes a bid action.
    /// </summary>
    public partial class Action
    {
        private HeaderTagAction _headerTag;
        private NoBidAction _noBid;

        /// <summary>
        /// Gets and sets the property HeaderTag. 
        /// <para>
        /// Describes the header tag for a bid action.
        /// </para>
        /// </summary>
        public HeaderTagAction HeaderTag
        {
            get { return this._headerTag; }
            set { this._headerTag = value; }
        }

        // Check to see if HeaderTag property is set
        internal bool IsSetHeaderTag()
        {
            return this._headerTag != null;
        }

        /// <summary>
        /// Gets and sets the property NoBid. 
        /// <para>
        /// Describes a no bid action.
        /// </para>
        /// </summary>
        public NoBidAction NoBid
        {
            get { return this._noBid; }
            set { this._noBid = value; }
        }

        // Check to see if NoBid property is set
        internal bool IsSetNoBid()
        {
            return this._noBid != null;
        }

    }
}
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
    /// Describes the parameters of a module.
    /// </summary>
    public partial class ModuleParameters
    {
        private NoBidModuleParameters _noBid;
        private OpenRtbAttributeModuleParameters _openRtbAttribute;

        /// <summary>
        /// Gets and sets the property NoBid. 
        /// <para>
        /// Describes the parameters of a no bid module.
        /// </para>
        /// </summary>
        public NoBidModuleParameters NoBid
        {
            get { return this._noBid; }
            set { this._noBid = value; }
        }

        // Check to see if NoBid property is set
        internal bool IsSetNoBid()
        {
            return this._noBid != null;
        }

        /// <summary>
        /// Gets and sets the property OpenRtbAttribute. 
        /// <para>
        /// Describes the parameters of an open RTB attribute module.
        /// </para>
        /// </summary>
        public OpenRtbAttributeModuleParameters OpenRtbAttribute
        {
            get { return this._openRtbAttribute; }
            set { this._openRtbAttribute = value; }
        }

        // Check to see if OpenRtbAttribute property is set
        internal bool IsSetOpenRtbAttribute()
        {
            return this._openRtbAttribute != null;
        }

    }
}
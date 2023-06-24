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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Provides additional filters for specific data sources. Named shadow is the only data
    /// source that currently supports and requires a filter. To add named shadows to your
    /// fleet indexing configuration, set <code>namedShadowIndexingMode</code> to be <code>ON</code>
    /// and specify your shadow names in <code>filter</code>.
    /// </summary>
    public partial class IndexingFilter
    {
        private List<string> _namedShadowNames = new List<string>();

        /// <summary>
        /// Gets and sets the property NamedShadowNames. 
        /// <para>
        /// The shadow names that you select to index. The default maximum number of shadow names
        /// for indexing is 10. To increase the limit, see <a href="https://docs.aws.amazon.com/general/latest/gr/iot_device_management.html#fleet-indexing-limits">Amazon
        /// Web Services IoT Device Management Quotas</a> in the <i>Amazon Web Services General
        /// Reference</i>. 
        /// </para>
        /// </summary>
        public List<string> NamedShadowNames
        {
            get { return this._namedShadowNames; }
            set { this._namedShadowNames = value; }
        }

        // Check to see if NamedShadowNames property is set
        internal bool IsSetNamedShadowNames()
        {
            return this._namedShadowNames != null && this._namedShadowNames.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies a batch of endpoints to create or update and the settings and attributes
    /// to set or change for each endpoint.
    /// </summary>
    public partial class EndpointBatchRequest
    {
        private List<EndpointBatchItem> _item = new List<EndpointBatchItem>();

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// An array that defines the endpoints to create or update and, for each endpoint, the
        /// property values to set or change. An array can contain a maximum of 100 items.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EndpointBatchItem> Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null && this._item.Count > 0; 
        }

    }
}
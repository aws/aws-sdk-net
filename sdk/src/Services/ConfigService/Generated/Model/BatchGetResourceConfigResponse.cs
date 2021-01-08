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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the BatchGetResourceConfig operation.
    /// </summary>
    public partial class BatchGetResourceConfigResponse : AmazonWebServiceResponse
    {
        private List<BaseConfigurationItem> _baseConfigurationItems = new List<BaseConfigurationItem>();
        private List<ResourceKey> _unprocessedResourceKeys = new List<ResourceKey>();

        /// <summary>
        /// Gets and sets the property BaseConfigurationItems. 
        /// <para>
        /// A list that contains the current configuration of one or more resources.
        /// </para>
        /// </summary>
        public List<BaseConfigurationItem> BaseConfigurationItems
        {
            get { return this._baseConfigurationItems; }
            set { this._baseConfigurationItems = value; }
        }

        // Check to see if BaseConfigurationItems property is set
        internal bool IsSetBaseConfigurationItems()
        {
            return this._baseConfigurationItems != null && this._baseConfigurationItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedResourceKeys. 
        /// <para>
        /// A list of resource keys that were not processed with the current response. The unprocessesResourceKeys
        /// value is in the same form as ResourceKeys, so the value can be directly provided to
        /// a subsequent BatchGetResourceConfig operation. If there are no unprocessed resource
        /// keys, the response contains an empty unprocessedResourceKeys list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ResourceKey> UnprocessedResourceKeys
        {
            get { return this._unprocessedResourceKeys; }
            set { this._unprocessedResourceKeys = value; }
        }

        // Check to see if UnprocessedResourceKeys property is set
        internal bool IsSetUnprocessedResourceKeys()
        {
            return this._unprocessedResourceKeys != null && this._unprocessedResourceKeys.Count > 0; 
        }

    }
}
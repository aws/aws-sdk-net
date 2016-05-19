/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTags operation.
    /// Creates one or more tags for a configuration item. Tags are metadata that help you
    /// categorize IT assets.
    /// </summary>
    public partial class CreateTagsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _configurationIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConfigurationIds. 
        /// <para>
        /// A list of configuration items that you want to tag.
        /// </para>
        /// </summary>
        public List<string> ConfigurationIds
        {
            get { return this._configurationIds; }
            set { this._configurationIds = value; }
        }

        // Check to see if ConfigurationIds property is set
        internal bool IsSetConfigurationIds()
        {
            return this._configurationIds != null && this._configurationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that you want to associate with one or more configuration items. Specify the
        /// tags that you want to create in a <i>key</i>,<i>value</i> format. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"key": "serverType", "value": "webServer"}</code> 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
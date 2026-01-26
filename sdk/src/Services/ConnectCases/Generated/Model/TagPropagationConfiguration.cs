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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Defines tag propagation configuration for resources created within a domain. Tags
    /// specified here will be automatically applied to resources being created for the specified
    /// resource type.
    /// </summary>
    public partial class TagPropagationConfiguration
    {
        private TagPropagationResourceType _resourceType;
        private Dictionary<string, string> _tagMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Supported resource types for tag propagation. Determines which resources will receive
        /// automatically propagated tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TagPropagationResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TagMap. 
        /// <para>
        /// The tags that will be applied to the created resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public Dictionary<string, string> TagMap
        {
            get { return this._tagMap; }
            set { this._tagMap = value; }
        }

        // Check to see if TagMap property is set
        internal bool IsSetTagMap()
        {
            return this._tagMap != null && (this._tagMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Specifies resources that lifecycle policy actions should not apply to.
    /// </summary>
    public partial class LifecyclePolicyDetailExclusionRules
    {
        private LifecyclePolicyDetailExclusionRulesAmis _amis;
        private Dictionary<string, string> _tagMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Amis. 
        /// <para>
        /// Lists configuration values that apply to AMIs that Image Builder should exclude from
        /// the lifecycle action.
        /// </para>
        /// </summary>
        public LifecyclePolicyDetailExclusionRulesAmis Amis
        {
            get { return this._amis; }
            set { this._amis = value; }
        }

        // Check to see if Amis property is set
        internal bool IsSetAmis()
        {
            return this._amis != null;
        }

        /// <summary>
        /// Gets and sets the property TagMap. 
        /// <para>
        /// Contains a list of tags that Image Builder uses to skip lifecycle actions for Image
        /// Builder image resources that have them.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
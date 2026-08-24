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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// A type of OutputConfig, used when the output in a feed is for the crop feature.
    /// </summary>
    public partial class CroppingConfig
    {
        private List<TemplateGroup> _templateGroups = AWSConfigs.InitializeCollections ? new List<TemplateGroup>() : null;

        /// <summary>
        /// Gets and sets the property TemplateGroups. 
        /// <para>
        /// An array of template groups for the crop output. Each template group provides the
        /// graphics-compositing templates that Elemental Inference applies to the cropped video.
        /// You can specify from 1 to 4 template groups. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<TemplateGroup> TemplateGroups
        {
            get { return this._templateGroups; }
            set { this._templateGroups = value; }
        }

        // Check to see if TemplateGroups property is set
        internal bool IsSetTemplateGroups()
        {
            return this._templateGroups != null && (this._templateGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
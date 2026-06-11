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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration for tag propagation to managed resources launched by the capacity provider.
    /// </summary>
    public partial class PropagateTags
    {
        private Dictionary<string, string> _explicitTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private PropagateTagsMode _mode;

        /// <summary>
        /// Gets and sets the property ExplicitTags. 
        /// <para>
        /// A list of tags to apply to managed resources when <c>Mode</c> is set to <c>Explicit</c>.
        /// You can specify up to 40 tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public Dictionary<string, string> ExplicitTags
        {
            get { return this._explicitTags; }
            set { this._explicitTags = value; }
        }

        // Check to see if ExplicitTags property is set
        internal bool IsSetExplicitTags()
        {
            return this._explicitTags != null && (this._explicitTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The tag propagation mode. Set to <c>Explicit</c> to propagate the tags specified in
        /// <c>ExplicitTags</c> to managed resources. Set to <c>None</c> to disable tag propagation.
        /// </para>
        /// </summary>
        public PropagateTagsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}
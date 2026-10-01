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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// A label selector that filters the Kubernetes objects discovered from an Amazon EKS
    /// input source. An object must satisfy both matchLabels and matchExpressions to match
    /// the selector. A selector with neither matches every object. The selector must render
    /// to 2,048 characters or fewer in Kubernetes label selector syntax.
    /// </summary>
    public partial class EksLabelSelector
    {
        private List<EksLabelSelectorRequirement> _matchExpressions = AWSConfigs.InitializeCollections ? new List<EksLabelSelectorRequirement>() : null;
        private Dictionary<string, string> _matchLabels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property MatchExpressions. 
        /// <para>
        /// The label requirements that an object must satisfy. All requirements in the list must
        /// match for the object to be selected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public List<EksLabelSelectorRequirement> MatchExpressions
        {
            get { return this._matchExpressions; }
            set { this._matchExpressions = value; }
        }

        // Check to see if MatchExpressions property is set
        internal bool IsSetMatchExpressions()
        {
            return this._matchExpressions != null && (this._matchExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchLabels. 
        /// <para>
        /// The label key-value pairs that an object must have. All pairs must match for the object
        /// to be selected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public Dictionary<string, string> MatchLabels
        {
            get { return this._matchLabels; }
            set { this._matchLabels = value; }
        }

        // Check to see if MatchLabels property is set
        internal bool IsSetMatchLabels()
        {
            return this._matchLabels != null && (this._matchLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
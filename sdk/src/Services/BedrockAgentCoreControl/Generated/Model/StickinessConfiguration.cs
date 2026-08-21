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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for session-sticky routing to a target. Session stickiness routes
    /// requests that share a session identifier to the same target.
    /// </summary>
    public partial class StickinessConfiguration
    {
        private List<string> _compositeIdentifier = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;
        private int? _timeout;

        /// <summary>
        /// Gets and sets the property CompositeIdentifier. 
        /// <para>
        /// Additional headers to include in session affinity routing. When set, requests are
        /// only considered part of the same session if both the <c>identifier</c> and all composite
        /// identifier values match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> CompositeIdentifier
        {
            get { return this._compositeIdentifier; }
            set { this._compositeIdentifier = value; }
        }

        // Check to see if CompositeIdentifier property is set
        internal bool IsSetCompositeIdentifier()
        {
            return this._compositeIdentifier != null && (this._compositeIdentifier.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The expression that identifies where to extract the session identifier from the request
        /// (for example, <c>$context.header.x-session-id</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The session stickiness timeout, in seconds. After this duration of inactivity, the
        /// session affinity expires. Valid values range from 1 to 86400.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

    }
}
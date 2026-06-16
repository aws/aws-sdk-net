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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A session affected by a detected failure pattern, including root cause details.
    /// </summary>
    public partial class AffectedSession
    {
        private string _explanation;
        private List<FailureSpanDetail> _failureSpans = AWSConfigs.InitializeCollections ? new List<FailureSpanDetail>() : null;
        private string _fixType;
        private string _recommendation;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property Explanation. 
        /// <para>
        /// An explanation of how the failure manifested in this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Explanation
        {
            get { return this._explanation; }
            set { this._explanation = value; }
        }

        // Check to see if Explanation property is set
        internal bool IsSetExplanation()
        {
            return this._explanation != null;
        }

        /// <summary>
        /// Gets and sets the property FailureSpans. 
        /// <para>
        /// The list of spans where failures were detected in this session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<FailureSpanDetail> FailureSpans
        {
            get { return this._failureSpans; }
            set { this._failureSpans = value; }
        }

        // Check to see if FailureSpans property is set
        internal bool IsSetFailureSpans()
        {
            return this._failureSpans != null && (this._failureSpans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FixType. 
        /// <para>
        /// The type of fix recommended for this failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FixType
        {
            get { return this._fixType; }
            set { this._fixType = value; }
        }

        // Check to see if FixType property is set
        internal bool IsSetFixType()
        {
            return this._fixType != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The specific fix recommendation for this session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the affected session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}
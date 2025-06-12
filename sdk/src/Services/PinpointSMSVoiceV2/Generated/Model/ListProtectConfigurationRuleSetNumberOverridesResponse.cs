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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the ListProtectConfigurationRuleSetNumberOverrides operation.
    /// </summary>
    public partial class ListProtectConfigurationRuleSetNumberOverridesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private string _protectConfigurationArn;
        private string _protectConfigurationId;
        private List<ProtectConfigurationRuleSetNumberOverride> _ruleSetNumberOverrides = AWSConfigs.InitializeCollections ? new List<ProtectConfigurationRuleSetNumberOverride>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ProtectConfigurationArn
        {
            get { return this._protectConfigurationArn; }
            set { this._protectConfigurationArn = value; }
        }

        // Check to see if ProtectConfigurationArn property is set
        internal bool IsSetProtectConfigurationArn()
        {
            return this._protectConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProtectConfigurationId
        {
            get { return this._protectConfigurationId; }
            set { this._protectConfigurationId = value; }
        }

        // Check to see if ProtectConfigurationId property is set
        internal bool IsSetProtectConfigurationId()
        {
            return this._protectConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetNumberOverrides. 
        /// <para>
        /// An array of RuleSetNumberOverrides objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ProtectConfigurationRuleSetNumberOverride> RuleSetNumberOverrides
        {
            get { return this._ruleSetNumberOverrides; }
            set { this._ruleSetNumberOverrides = value; }
        }

        // Check to see if RuleSetNumberOverrides property is set
        internal bool IsSetRuleSetNumberOverrides()
        {
            return this._ruleSetNumberOverrides != null && (this._ruleSetNumberOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
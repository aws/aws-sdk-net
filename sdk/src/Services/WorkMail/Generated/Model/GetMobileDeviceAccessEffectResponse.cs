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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetMobileDeviceAccessEffect operation.
    /// </summary>
    public partial class GetMobileDeviceAccessEffectResponse : AmazonWebServiceResponse
    {
        private MobileDeviceAccessRuleEffect _effect;
        private List<MobileDeviceAccessMatchedRule> _matchedRules = AWSConfigs.InitializeCollections ? new List<MobileDeviceAccessMatchedRule>() : null;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the simulated access, <c>ALLOW</c> or <c>DENY</c>, after evaluating
        /// mobile device access rules in the WorkMail organization for the simulated user parameters.
        /// </para>
        /// </summary>
        public MobileDeviceAccessRuleEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property MatchedRules. 
        /// <para>
        /// A list of the rules which matched the simulated user input and produced the effect.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<MobileDeviceAccessMatchedRule> MatchedRules
        {
            get { return this._matchedRules; }
            set { this._matchedRules = value; }
        }

        // Check to see if MatchedRules property is set
        internal bool IsSetMatchedRules()
        {
            return this._matchedRules != null && (this._matchedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
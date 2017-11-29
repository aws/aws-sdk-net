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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The event risk type.
    /// </summary>
    public partial class EventRiskType
    {
        private RiskDecisionType _riskDecision;
        private RiskLevelType _riskLevel;

        /// <summary>
        /// Gets and sets the property RiskDecision. 
        /// <para>
        /// The risk decision.
        /// </para>
        /// </summary>
        public RiskDecisionType RiskDecision
        {
            get { return this._riskDecision; }
            set { this._riskDecision = value; }
        }

        // Check to see if RiskDecision property is set
        internal bool IsSetRiskDecision()
        {
            return this._riskDecision != null;
        }

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The risk level.
        /// </para>
        /// </summary>
        public RiskLevelType RiskLevel
        {
            get { return this._riskLevel; }
            set { this._riskLevel = value; }
        }

        // Check to see if RiskLevel property is set
        internal bool IsSetRiskLevel()
        {
            return this._riskLevel != null;
        }

    }
}
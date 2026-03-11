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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetTelemetryRuleForOrganization operation.
    /// </summary>
    public partial class GetTelemetryRuleForOrganizationResponse : AmazonWebServiceResponse
    {
        private long? _createdTimeStamp;
        private long? _lastUpdateTimeStamp;
        private string _ruleArn;
        private string _ruleName;
        private TelemetryRule _telemetryRule;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        ///  The timestamp when the organization telemetry rule was created. 
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp
        {
            get { return this._createdTimeStamp; }
            set { this._createdTimeStamp = value; }
        }

        // Check to see if CreatedTimeStamp property is set
        internal bool IsSetCreatedTimeStamp()
        {
            return this._createdTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        ///  The timestamp when the organization telemetry rule was last updated. 
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp
        {
            get { return this._lastUpdateTimeStamp; }
            set { this._lastUpdateTimeStamp = value; }
        }

        // Check to see if LastUpdateTimeStamp property is set
        internal bool IsSetLastUpdateTimeStamp()
        {
            return this._lastUpdateTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the organization telemetry rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        ///  The name of the organization telemetry rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetryRule. 
        /// <para>
        ///  The configuration details of the organization telemetry rule. 
        /// </para>
        /// </summary>
        public TelemetryRule TelemetryRule
        {
            get { return this._telemetryRule; }
            set { this._telemetryRule = value; }
        }

        // Check to see if TelemetryRule property is set
        internal bool IsSetTelemetryRule()
        {
            return this._telemetryRule != null;
        }

    }
}
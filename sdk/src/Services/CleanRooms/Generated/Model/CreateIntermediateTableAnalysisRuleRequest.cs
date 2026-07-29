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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntermediateTableAnalysisRule operation.
    /// Creates an analysis rule for an intermediate table. Only the CUSTOM analysis rule
    /// type is supported. The service automatically determines whether the rule is first-party
    /// or multi-party restricted based on the intermediate table's inherited constraints.
    /// Only the intermediate table owner can call this operation.
    /// </summary>
    public partial class CreateIntermediateTableAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        private IntermediateTableAnalysisRulePolicy _analysisRulePolicy;
        private IntermediateTableAnalysisRuleType _analysisRuleType;
        private string _intermediateTableIdentifier;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property AnalysisRulePolicy. 
        /// <para>
        /// The analysis rule policy to apply to the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateTableAnalysisRulePolicy AnalysisRulePolicy
        {
            get { return this._analysisRulePolicy; }
            set { this._analysisRulePolicy = value; }
        }

        // Check to see if AnalysisRulePolicy property is set
        internal bool IsSetAnalysisRulePolicy()
        {
            return this._analysisRulePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The type of analysis rule to create. Currently, only <c>CUSTOM</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntermediateTableAnalysisRuleType AnalysisRuleType
        {
            get { return this._analysisRuleType; }
            set { this._analysisRuleType = value; }
        }

        // Check to see if AnalysisRuleType property is set
        internal bool IsSetAnalysisRuleType()
        {
            return this._analysisRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table for which to create the analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IntermediateTableIdentifier
        {
            get { return this._intermediateTableIdentifier; }
            set { this._intermediateTableIdentifier = value; }
        }

        // Check to see if IntermediateTableIdentifier property is set
        internal bool IsSetIntermediateTableIdentifier()
        {
            return this._intermediateTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetIntermediateTableAnalysisRule operation. Retrieves
    /// the analysis rule for an intermediate table.
    /// </summary>
    public partial class GetIntermediateTableAnalysisRuleRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisRuleType. 
        /// <para>
        /// The type of analysis rule to retrieve. Currently, only <c>CUSTOM</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntermediateTableAnalysisRuleType AnalysisRuleType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisRuleType property is set.
        /// </summary>
        internal bool IsSetAnalysisRuleType() => this.AnalysisRuleType != null;

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table for which to retrieve the analysis
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IntermediateTableIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableIdentifier property is set.
        /// </summary>
        internal bool IsSetIntermediateTableIdentifier() => this.IntermediateTableIdentifier != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;
    }
}

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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains a reference to a <c>Statement</c> element in a policy document that determines
    /// the result of the simulation.
    /// 
    ///  
    /// <para>
    /// This data type is used by the <c>MatchedStatements</c> member of the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_EvaluationResult.html">EvaluationResult</a>
    /// </c> type.
    /// </para>
    /// </summary>
    public partial class Statement
    {
        /// <summary>
        /// Gets and sets the property EndPosition. 
        /// <para>
        /// The row and column of the end of a <c>Statement</c> in an IAM policy.
        /// </para>
        /// </summary>
        public Position EndPosition { get; set; }

        /// <summary>
        /// Checks to see if the EndPosition property is set.
        /// </summary>
        internal bool IsSetEndPosition() => this.EndPosition != null;

        /// <summary>
        /// Gets and sets the property SourcePolicyId. 
        /// <para>
        /// The identifier of the policy that was provided as an input.
        /// </para>
        /// </summary>
        public string SourcePolicyId { get; set; }

        /// <summary>
        /// Checks to see if the SourcePolicyId property is set.
        /// </summary>
        internal bool IsSetSourcePolicyId() => this.SourcePolicyId != null;

        /// <summary>
        /// Gets and sets the property SourcePolicyType. 
        /// <para>
        /// The type of the policy.
        /// </para>
        /// </summary>
        public PolicySourceType SourcePolicyType { get; set; }

        /// <summary>
        /// Checks to see if the SourcePolicyType property is set.
        /// </summary>
        internal bool IsSetSourcePolicyType() => this.SourcePolicyType != null;

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// The row and column of the beginning of the <c>Statement</c> in an IAM policy.
        /// </para>
        /// </summary>
        public Position StartPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartPosition property is set.
        /// </summary>
        internal bool IsSetStartPosition() => this.StartPosition != null;
    }
}

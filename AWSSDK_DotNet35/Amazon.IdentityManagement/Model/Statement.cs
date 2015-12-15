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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains a reference to a <code>Statement</code> element in a policy document that
    /// determines the result of the simulation.
    /// 
    ///  
    /// <para>
    /// This data type is used by the <code>MatchedStatements</code> member of the <code><a>EvaluationResult</a></code>
    /// type.
    /// </para>
    /// </summary>
    public partial class Statement
    {
        private Position _endPosition;
        private string _sourcePolicyId;
        private PolicySourceType _sourcePolicyType;
        private Position _startPosition;

        /// <summary>
        /// Gets and sets the property EndPosition. 
        /// <para>
        /// The row and column of the end of a <code>Statement</code> in an IAM policy.
        /// </para>
        /// </summary>
        public Position EndPosition
        {
            get { return this._endPosition; }
            set { this._endPosition = value; }
        }

        // Check to see if EndPosition property is set
        internal bool IsSetEndPosition()
        {
            return this._endPosition != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePolicyId. 
        /// <para>
        /// The identifier of the policy that was provided as an input.
        /// </para>
        /// </summary>
        public string SourcePolicyId
        {
            get { return this._sourcePolicyId; }
            set { this._sourcePolicyId = value; }
        }

        // Check to see if SourcePolicyId property is set
        internal bool IsSetSourcePolicyId()
        {
            return this._sourcePolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePolicyType. 
        /// <para>
        /// The type of the policy.
        /// </para>
        /// </summary>
        public PolicySourceType SourcePolicyType
        {
            get { return this._sourcePolicyType; }
            set { this._sourcePolicyType = value; }
        }

        // Check to see if SourcePolicyType property is set
        internal bool IsSetSourcePolicyType()
        {
            return this._sourcePolicyType != null;
        }

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// The row and column of the beginning of the <code>Statement</code> in an IAM policy.
        /// </para>
        /// </summary>
        public Position StartPosition
        {
            get { return this._startPosition; }
            set { this._startPosition = value; }
        }

        // Check to see if StartPosition property is set
        internal bool IsSetStartPosition()
        {
            return this._startPosition != null;
        }

    }
}
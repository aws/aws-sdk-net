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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// A condition for item enablement.
    /// </summary>
    public partial class EvaluationFormItemEnablementCondition
    {
        private List<EvaluationFormItemEnablementConditionOperand> _operands = AWSConfigs.InitializeCollections ? new List<EvaluationFormItemEnablementConditionOperand>() : null;
        private EvaluationFormItemEnablementOperator _operator;

        /// <summary>
        /// Gets and sets the property Operands. 
        /// <para>
        /// Operands of the enablement condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EvaluationFormItemEnablementConditionOperand> Operands
        {
            get { return this._operands; }
            set { this._operands = value; }
        }

        // Check to see if Operands property is set
        internal bool IsSetOperands()
        {
            return this._operands != null && (this._operands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to be used to be applied to operands if more than one provided. 
        /// </para>
        /// </summary>
        public EvaluationFormItemEnablementOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

    }
}
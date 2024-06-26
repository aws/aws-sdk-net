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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// A boolean expression to evaluate email attribute values.
    /// </summary>
    public partial class ArchiveBooleanExpression
    {
        private ArchiveBooleanToEvaluate _evaluate;
        private ArchiveBooleanOperator _operator;

        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The email attribute value to evaluate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArchiveBooleanToEvaluate Evaluate
        {
            get { return this._evaluate; }
            set { this._evaluate = value; }
        }

        // Check to see if Evaluate property is set
        internal bool IsSetEvaluate()
        {
            return this._evaluate != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The boolean operator to use for evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ArchiveBooleanOperator Operator
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
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
    /// The structure for a TLS related condition matching on the incoming mail.
    /// </summary>
    public partial class IngressTlsProtocolExpression
    {
        private IngressTlsProtocolToEvaluate _evaluate;
        private IngressTlsProtocolOperator _operator;
        private IngressTlsProtocolAttribute _value;

        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The left hand side argument of a TLS condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressTlsProtocolToEvaluate Evaluate
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
        /// The matching operator for a TLS condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressTlsProtocolOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The right hand side argument of a TLS condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressTlsProtocolAttribute Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
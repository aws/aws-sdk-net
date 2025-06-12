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
    /// The union type representing the allowed types for the left hand side of an IPv6 condition.
    /// </summary>
    public partial class IngressIpv6Expression
    {
        private IngressIpv6ToEvaluate _evaluate;
        private IngressIpOperator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The left hand side argument of an IPv6 condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressIpv6ToEvaluate Evaluate
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
        /// The matching operator for an IPv6 condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngressIpOperator Operator
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
        /// Gets and sets the property Values. 
        /// <para>
        /// The right hand side argument of an IPv6 condition expression.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
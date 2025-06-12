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
    /// An IP address expression matching certain IP addresses within a given range of IP
    /// addresses.
    /// </summary>
    public partial class RuleIpExpression
    {
        private RuleIpToEvaluate _evaluate;
        private RuleIpOperator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Evaluate. 
        /// <para>
        /// The IP address to evaluate in this condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleIpToEvaluate Evaluate
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
        /// The operator to evaluate the IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleIpOperator Operator
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
        /// The IP CIDR blocks in format "x.y.z.w/n" (eg 10.0.0.0/8) to match with the email's
        /// IP address. For the operator CIDR_MATCHES, if multiple values are given, they are
        /// evaluated as an OR. That is, if the IP address is contained within any of the given
        /// CIDR ranges, the condition is deemed to match. For NOT_CIDR_MATCHES, if multiple CIDR
        /// ranges are given, the condition is deemed to match if the IP address is not contained
        /// in any of the given CIDR ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
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
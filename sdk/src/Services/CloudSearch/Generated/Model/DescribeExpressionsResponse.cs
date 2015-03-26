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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// The result of a <code>DescribeExpressions</code> request. Contains the expressions
    /// configured for the domain specified in the request.
    /// </summary>
    public partial class DescribeExpressionsResponse : AmazonWebServiceResponse
    {
        private List<ExpressionStatus> _expressions = new List<ExpressionStatus>();

        /// <summary>
        /// Gets and sets the property Expressions. 
        /// <para>
        /// The expressions configured for the domain.
        /// </para>
        /// </summary>
        public List<ExpressionStatus> Expressions
        {
            get { return this._expressions; }
            set { this._expressions = value; }
        }

        // Check to see if Expressions property is set
        internal bool IsSetExpressions()
        {
            return this._expressions != null && this._expressions.Count > 0; 
        }

    }
}
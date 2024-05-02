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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// A named expression that can be evaluated at search time. Can be used to sort the search
    /// results, define other expressions, or return computed information in the search results.
    /// </summary>
    public partial class Expression
    {
        private string _expressionName;
        private string _expressionValue;

        /// <summary>
        /// Gets and sets the property ExpressionName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ExpressionName
        {
            get { return this._expressionName; }
            set { this._expressionName = value; }
        }

        // Check to see if ExpressionName property is set
        internal bool IsSetExpressionName()
        {
            return this._expressionName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionValue.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10240)]
        public string ExpressionValue
        {
            get { return this._expressionValue; }
            set { this._expressionValue = value; }
        }

        // Check to see if ExpressionValue property is set
        internal bool IsSetExpressionValue()
        {
            return this._expressionValue != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The options for customizing a security control parameter that is a string.
    /// </summary>
    public partial class StringConfigurationOptions
    {
        private string _defaultValue;
        private string _expressionDescription;
        private string _re2Expression;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///  The Security Hub default value for a control parameter that is a string. 
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property ExpressionDescription. 
        /// <para>
        ///  The description of the RE2 regular expression. 
        /// </para>
        /// </summary>
        public string ExpressionDescription
        {
            get { return this._expressionDescription; }
            set { this._expressionDescription = value; }
        }

        // Check to see if ExpressionDescription property is set
        internal bool IsSetExpressionDescription()
        {
            return this._expressionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Re2Expression. 
        /// <para>
        ///  An RE2 regular expression that Security Hub uses to validate a user-provided control
        /// parameter string. 
        /// </para>
        /// </summary>
        public string Re2Expression
        {
            get { return this._re2Expression; }
            set { this._re2Expression = value; }
        }

        // Check to see if Re2Expression property is set
        internal bool IsSetRe2Expression()
        {
            return this._re2Expression != null;
        }

    }
}
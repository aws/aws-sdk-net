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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The options for customizing a security control parameter that is a string.
    /// </summary>
    public partial class StringConfigurationOptions
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///  The Security Hub CSPM default value for a control parameter that is a string. 
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property ExpressionDescription. 
        /// <para>
        ///  The description of the RE2 regular expression. 
        /// </para>
        /// </summary>
        public string ExpressionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ExpressionDescription property is set.
        /// </summary>
        internal bool IsSetExpressionDescription() => this.ExpressionDescription != null;

        /// <summary>
        /// Gets and sets the property Re2Expression. 
        /// <para>
        ///  An RE2 regular expression that Security Hub CSPM uses to validate a user-provided
        /// control parameter string. 
        /// </para>
        /// </summary>
        public string Re2Expression { get; set; }

        /// <summary>
        /// Checks to see if the Re2Expression property is set.
        /// </summary>
        internal bool IsSetRe2Expression() => this.Re2Expression != null;
    }
}

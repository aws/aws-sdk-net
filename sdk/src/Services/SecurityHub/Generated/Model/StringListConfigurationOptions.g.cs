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
    /// The options for customizing a security control parameter that is a list of strings.
    /// </summary>
    public partial class StringListConfigurationOptions
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///  The Security Hub CSPM default value for a control parameter that is a list of strings.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DefaultValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null && (this.DefaultValue.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property MaxItems. 
        /// <para>
        ///  The maximum number of list items that a string list control parameter can accept.
        /// 
        /// </para>
        /// </summary>
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property Re2Expression. 
        /// <para>
        ///  An RE2 regular expression that Security Hub CSPM uses to validate a user-provided
        /// list of strings for a control parameter. 
        /// </para>
        /// </summary>
        public string Re2Expression { get; set; }

        /// <summary>
        /// Checks to see if the Re2Expression property is set.
        /// </summary>
        internal bool IsSetRe2Expression() => this.Re2Expression != null;
    }
}

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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// One new credit to create from a split.
    /// </summary>
    public partial class SplitPortion
    {
        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The amount of the new credit, in the currency of the credit that you split. The amount
        /// must be at least 100.00 in that currency. For example, if the credit is in USD, the
        /// amount must be at least USD $100.00.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Amount { get; set; }

        /// <summary>
        /// Checks to see if the Amount property is set.
        /// </summary>
        internal bool IsSetAmount() => this.Amount != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the new credit. If you omit it, the new credit gets the original
        /// credit's description followed by its position in the request, for example <c>MAP credit
        /// - 1/3</c>. If you split that credit again, the name extends, for example <c>MAP credit
        /// - 1/3 - 2/2</c>. A generated name is at most 93 characters. If it would be longer,
        /// the name keeps only the beginning of the original description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}

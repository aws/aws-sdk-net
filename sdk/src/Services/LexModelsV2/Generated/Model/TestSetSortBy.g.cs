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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about the methods by which to sort the test set.
    /// </summary>
    public partial class TestSetSortBy
    {
        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// Specifies whether to sort the test sets by name or by the time they were last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestSetSortAttribute Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Specifies whether to sort in ascending or descending order.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortOrder Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null;
    }
}

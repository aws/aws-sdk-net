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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// A query filter used by <c>ListUsers</c> and <c>ListGroups</c>. This filter object
    /// provides the attribute name and attribute value to search users or groups.
    /// </summary>
    public partial class Filter
    {
        /// <summary>
        /// Gets and sets the property AttributePath. 
        /// <para>
        /// The attribute path that is used to specify which attribute name to search. Length
        /// limit is 255 characters. For example, <c>UserName</c> is a valid attribute path for
        /// the <c> ListUsers</c> API, and <c>DisplayName</c> is a valid attribute path for the
        /// <c> ListGroups</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AttributePath { get; set; }

        /// <summary>
        /// Checks to see if the AttributePath property is set.
        /// </summary>
        internal bool IsSetAttributePath() => this.AttributePath != null;

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// Represents the data for an attribute. Each attribute value is described as a name-value
        /// pair. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValue property is set.
        /// </summary>
        internal bool IsSetAttributeValue() => this.AttributeValue != null;
    }
}

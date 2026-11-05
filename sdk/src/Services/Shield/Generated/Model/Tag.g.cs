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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// A tag associated with an Amazon Web Services resource. Tags are key:value pairs that
    /// you can use to categorize and manage your resources, for purposes like billing or
    /// other management. Typically, the tag key represents a category, such as "environment",
    /// and the tag value represents a specific value within that category, such as "test,"
    /// "development," or "production". Or you might set the tag key to "customer" and the
    /// value to the customer name or ID. You can specify one or more tags to add to each
    /// Amazon Web Services resource, up to 50 tags for a resource.
    /// </summary>
    public partial class Tag
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Part of the key:value pair that defines a tag. You can use a tag key to describe a
        /// category of information, such as "customer." Tag keys are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Part of the key:value pair that defines a tag. You can use a tag value to describe
        /// a specific value within a category, such as "companyA" or "companyB." Tag values are
        /// case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The <c>Tag</c> object represents a label that you can assign to an Amazon Web Services
    /// resource. Each tag consists of a key and an optional value, both of which you define.
    /// 
    ///  
    /// <para>
    /// For more information about tags, and controlling access to resources in Glue, see
    /// <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon Web
    /// Services Tags in Glue</a> and <a href="https://docs.aws.amazon.com/glue/latest/dg/glue-specifying-resource-arns.html">Specifying
    /// Glue Resource ARNs</a> in the developer guide.
    /// </para>
    /// </summary>
    public partial class Tag
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag key. The key is required when you create a tag on an object. The key is case-sensitive,
        /// and must not contain the prefix aws.
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
        /// The tag value. The value is optional when you create a tag on an object. The value
        /// is case-sensitive, and must not contain the prefix aws.
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

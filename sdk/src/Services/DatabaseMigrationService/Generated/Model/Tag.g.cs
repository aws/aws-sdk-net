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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// A user-defined key-value pair that describes metadata added to an DMS resource and
    /// that is used by operations such as the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>AddTagsToResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListTagsForResource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RemoveTagsFromResource</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Tag
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A key is the required name of the tag. The string value can be 1-128 Unicode characters
        /// in length and can't be prefixed with "aws:" or "dms:". The string can only contain
        /// only the set of Unicode letters, digits, white-space, '_', '.', '/', '=', '+', '-'
        /// (Java regular expressions: "^([\\p{L}\\p{Z}\\p{N}_.:/=+\\-]*)$").
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) string that uniquely identifies the resource for which
        /// the tag is created.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value is the optional value of the tag. The string value can be 1-256 Unicode characters
        /// in length and can't be prefixed with "aws:" or "dms:". The string can only contain
        /// only the set of Unicode letters, digits, white-space, '_', '.', '/', '=', '+', '-'
        /// (Java regular expressions: "^([\\p{L}\\p{Z}\\p{N}_.:/=+\\-]*)$").
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

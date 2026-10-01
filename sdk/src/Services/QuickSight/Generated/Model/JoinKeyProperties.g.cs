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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Properties associated with the columns participating in a join.
    /// </summary>
    public partial class JoinKeyProperties
    {
        /// <summary>
        /// Gets and sets the property UniqueKey. 
        /// <para>
        /// A value that indicates that a row in a table is uniquely identified by the columns
        /// in a join key. This is used by Quick Sight to optimize query performance.
        /// </para>
        /// </summary>
        public bool? UniqueKey { get; set; }

        /// <summary>
        /// Checks to see if the UniqueKey property is set.
        /// </summary>
        internal bool IsSetUniqueKey() => this.UniqueKey.HasValue;
    }
}

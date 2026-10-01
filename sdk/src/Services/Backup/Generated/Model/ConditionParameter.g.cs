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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Includes information about tags you define to assign tagged resources to a backup
    /// plan.
    /// 
    ///  
    /// <para>
    /// Include the prefix <c>aws:ResourceTag</c> in your tags. For example, <c>"aws:ResourceTag/TagKey1":
    /// "Value1"</c>.
    /// </para>
    /// </summary>
    public partial class ConditionParameter
    {
        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// The key in a key-value pair. For example, in the tag <c>Department: Accounting</c>,
        /// <c>Department</c> is the key.
        /// </para>
        /// </summary>
        public string ConditionKey { get; set; }

        /// <summary>
        /// Checks to see if the ConditionKey property is set.
        /// </summary>
        internal bool IsSetConditionKey() => this.ConditionKey != null;

        /// <summary>
        /// Gets and sets the property ConditionValue. 
        /// <para>
        /// The value in a key-value pair. For example, in the tag <c>Department: Accounting</c>,
        /// <c>Accounting</c> is the value.
        /// </para>
        /// </summary>
        public string ConditionValue { get; set; }

        /// <summary>
        /// Checks to see if the ConditionValue property is set.
        /// </summary>
        internal bool IsSetConditionValue() => this.ConditionValue != null;
    }
}

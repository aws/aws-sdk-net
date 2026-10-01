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
    /// Contains an array of triplets made up of a condition type (such as <c>StringEquals</c>),
    /// a key, and a value. Used to filter resources using their tags and assign them to a
    /// backup plan. Case sensitive.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// The key in a key-value pair. For example, in the tag <c>Department: Accounting</c>,
        /// <c>Department</c> is the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConditionKey { get; set; }

        /// <summary>
        /// Checks to see if the ConditionKey property is set.
        /// </summary>
        internal bool IsSetConditionKey() => this.ConditionKey != null;

        /// <summary>
        /// Gets and sets the property ConditionType. 
        /// <para>
        /// An operation applied to a key-value pair used to assign resources to your backup plan.
        /// Condition only supports <c>StringEquals</c>. For more flexible assignment options,
        /// including <c>StringLike</c> and the ability to exclude resources from your backup
        /// plan, use <c>Conditions</c> (with an "s" on the end) for your <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_BackupSelection.html">
        /// <c>BackupSelection</c> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConditionType ConditionType { get; set; }

        /// <summary>
        /// Checks to see if the ConditionType property is set.
        /// </summary>
        internal bool IsSetConditionType() => this.ConditionType != null;

        /// <summary>
        /// Gets and sets the property ConditionValue. 
        /// <para>
        /// The value in a key-value pair. For example, in the tag <c>Department: Accounting</c>,
        /// <c>Accounting</c> is the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConditionValue { get; set; }

        /// <summary>
        /// Checks to see if the ConditionValue property is set.
        /// </summary>
        internal bool IsSetConditionValue() => this.ConditionValue != null;
    }
}

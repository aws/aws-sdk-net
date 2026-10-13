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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// A JSON string which you can use to limit the event bus permissions you are granting
    /// to only accounts that fulfill the condition. Currently, the only supported condition
    /// is membership in a certain Amazon Web Services organization. The string must contain
    /// <c>Type</c>, <c>Key</c>, and <c>Value</c> fields. The <c>Value</c> field specifies
    /// the ID of the Amazon Web Services organization. Following is an example value for
    /// <c>Condition</c>:
    /// 
    ///  
    /// <para>
    ///  <c>'{"Type" : "StringEquals", "Key": "aws:PrincipalOrgID", "Value": "o-1234567890"}'</c>
    /// 
    /// </para>
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Specifies the key for the condition. Currently the only supported key is <c>aws:PrincipalOrgID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of condition. Currently the only supported value is <c>StringEquals</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies the value for the key. Currently, this must be the ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

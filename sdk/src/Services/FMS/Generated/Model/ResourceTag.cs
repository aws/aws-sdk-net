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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// The resource tags that Firewall Manager uses to determine if a particular resource
    /// should be included or excluded from the Firewall Manager policy. Tags enable you to
    /// categorize your Amazon Web Services resources in different ways, for example, by purpose,
    /// owner, or environment. Each tag consists of a key and an optional value. If you add
    /// more than one tag to a policy, you can specify whether to combine them using the logical
    /// AND operator or the logical OR operator. For more information, see <a href="https://docs.aws.amazon.com/awsconsolehelpdocs/latest/gsg/tag-editor.html">Working
    /// with Tag Editor</a>.
    /// 
    ///  
    /// <para>
    /// Every resource tag must have a string value, either a non-empty string or an empty
    /// string. If you don't provide a value for a resource tag, Firewall Manager saves the
    /// value as an empty string: "". When Firewall Manager compares tags, it only matches
    /// two tags if they have the same key and the same value. A tag with an empty string
    /// value only matches with tags that also have an empty string value. 
    /// </para>
    /// </summary>
    public partial class ResourceTag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The resource tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The resource tag value. To specify an empty string value, either don't provide this
        /// or specify it as "". 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
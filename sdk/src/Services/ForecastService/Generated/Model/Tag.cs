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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The optional metadata that you apply to a resource to help you categorize and organize
    /// them. Each tag consists of a key and an optional value, both of which you define.
    /// 
    ///  
    /// <para>
    /// The following basic restrictions apply to tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Maximum number of tags per resource - 50.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For each resource, each tag key must be unique, and each tag key can have only one
    /// value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum key length - 128 Unicode characters in UTF-8.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Maximum value length - 256 Unicode characters in UTF-8.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your tagging schema is used across multiple services and resources, remember that
    /// other services may have restrictions on allowed characters. Generally allowed characters
    /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
    /// + - = . _ : / @.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tag keys and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
    /// of such as a prefix for keys as it is reserved for Amazon Web Services use. You cannot
    /// edit or delete tag keys with this prefix. Values can have this prefix. If a tag value
    /// has <code>aws</code> as its prefix but the key does not, then Forecast considers it
    /// to be a user tag and will count against the limit of 50 tags. Tags with only the key
    /// prefix of <code>aws</code> do not count against your tags per resource limit.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// One part of a key-value pair that makes up a tag. A <code>key</code> is a general
        /// label that acts like a category for more specific tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// The optional part of a key-value pair that makes up a tag. A <code>value</code> acts
        /// as a descriptor within a tag category (key).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=256)]
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
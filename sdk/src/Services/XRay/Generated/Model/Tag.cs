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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// A map that contains tag keys and tag values to attach to an Amazon Web Services X-Ray
    /// group or sampling rule. For more information about ways to use tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
    /// 
    ///  
    /// <para>
    /// The following restrictions apply to tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Maximum number of user-applied tags per resource: 50
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tag keys and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Don't use <c>aws:</c> as a prefix for keys; it's reserved for Amazon Web Services
    /// use. You cannot edit or delete system tags.
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
        /// A tag key, such as <c>Stage</c> or <c>Name</c>. A tag key cannot be empty. The key
        /// can be a maximum of 128 characters, and can contain only Unicode letters, numbers,
        /// or separators, or the following special characters: <c>+ - = . _ : /</c> 
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
        /// An optional tag value, such as <c>Production</c> or <c>test-only</c>. The value can
        /// be a maximum of 255 characters, and contain only Unicode letters, numbers, or separators,
        /// or the following special characters: <c>+ - = . _ : /</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
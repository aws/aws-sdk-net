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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// A label that you assign to a resource. In Athena, a resource can be a workgroup or
    /// data catalog. Each tag consists of a key and an optional value, both of which you
    /// define. For example, you can use tags to categorize Athena workgroups or data catalogs
    /// by purpose, owner, or environment. Use a consistent set of tag keys to make it easier
    /// to search and filter workgroups or data catalogs in your account. For best practices,
    /// see <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html">Tagging
    /// Best Practices</a>. Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag
    /// values can be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
    /// representable in UTF-8, and the following characters: + - = . _ : / @. Tag keys and
    /// values are case-sensitive. Tag keys must be unique per resource. If you specify more
    /// than one tag, separate them by commas.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A tag key. The tag key length is from 1 to 128 Unicode characters in UTF-8. You can
        /// use letters and numbers representable in UTF-8, and the following characters: + -
        /// = . _ : / @. Tag keys are case-sensitive and must be unique per resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// A tag value. The tag value length is from 0 to 256 Unicode characters in UTF-8. You
        /// can use letters and numbers representable in UTF-8, and the following characters:
        /// + - = . _ : / @. Tag values are case-sensitive. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
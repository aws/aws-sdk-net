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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Describes a tag. A tag is a key-value pair. You can add up to 50 tags to a single
    /// Amazon Keyspaces resource.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services-assigned tag names and values are automatically assigned the <c>aws:</c>
    /// prefix, which the user cannot assign. Amazon Web Services-assigned tag names do not
    /// count towards the tag limit of 50. User-assigned tag names have the prefix <c>user:</c>
    /// in the Cost Allocation Report. You cannot backdate the application of a tag.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
    /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the tag. Tag keys are case sensitive. Each Amazon Keyspaces resource can
        /// only have up to one tag with the same key. If you try to add an existing tag (same
        /// key), the existing tag value will be updated to the new value.
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
        /// The value of the tag. Tag values are case-sensitive and can be null.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
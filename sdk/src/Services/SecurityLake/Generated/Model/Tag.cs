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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// A <i>tag</i> is a label that you can define and associate with Amazon Web Services
    /// resources, including certain types of Amazon Security Lake resources. Tags can help
    /// you identify, categorize, and manage resources in different ways, such as by owner,
    /// environment, or other criteria. You can associate tags with the following types of
    /// Security Lake resources: subscribers, and the data lake configuration for your Amazon
    /// Web Services account in individual Amazon Web Services Regions.
    /// 
    ///  
    /// <para>
    /// A resource can have up to 50 tags. Each tag consists of a required <i>tag key</i>
    /// and an associated <i>tag value</i>. A <i>tag key</i> is a general label that acts
    /// as a category for a more specific tag value. Each tag key must be unique and it can
    /// have only one tag value. A <i>tag value</i> acts as a descriptor for a tag key. Tag
    /// keys and values are case sensitive. They can contain letters, numbers, spaces, or
    /// the following symbols: _ . : / = + @ -
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/tagging-resources.html">Tagging
    /// Amazon Security Lake resources</a> in the <i>Amazon Security Lake User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the tag. This is a general label that acts as a category for a more specific
        /// tag value (<c>value</c>).
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
        /// The value that’s associated with the specified tag key (<c>key</c>). This value acts
        /// as a descriptor for the tag key. A tag value cannot be null, but it can be an empty
        /// string.
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
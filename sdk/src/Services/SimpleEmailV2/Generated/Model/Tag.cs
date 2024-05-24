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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that defines the tags that are associated with a resource. A <i>tag</i> is
    /// a label that you optionally define and associate with a resource. Tags can help you
    /// categorize and manage resources in different ways, such as by purpose, owner, environment,
    /// or other criteria. A resource can have as many as 50 tags.
    /// 
    ///  
    /// <para>
    /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
    /// both of which you define. A tag key is a general label that acts as a category for
    /// a more specific tag value. A tag value acts as a descriptor within a tag key. A tag
    /// key can contain as many as 128 characters. A tag value can contain as many as 256
    /// characters. The characters can be Unicode letters, digits, white space, or one of
    /// the following symbols: _ . : / = + -. The following additional restrictions apply
    /// to tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tag keys and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For each associated resource, each tag key must be unique and it can have only one
    /// value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>aws:</c> prefix is reserved for use by Amazon Web Services; you can’t use it
    /// in any tag keys or values that you define. In addition, you can't edit or remove tag
    /// keys or values that use this prefix. Tags that use this prefix don’t count against
    /// the limit of 50 tags per resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can associate tags with public or shared resources, but the tags are available
    /// only for your Amazon Web Services account, not any other accounts that share the resource.
    /// In addition, the tags are available only for resources that are located in the specified
    /// Amazon Web Services Region for your Amazon Web Services account.
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
        /// One part of a key-value pair that defines a tag. The maximum length of a tag key is
        /// 128 characters. The minimum length is 1 character.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The optional part of a key-value pair that defines a tag. The maximum length of a
        /// tag value is 256 characters. The minimum length is 0 characters. If you don't want
        /// a resource to have a specific tag value, don't specify a value for this parameter.
        /// If you don't specify a value, Amazon SES sets the value to an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
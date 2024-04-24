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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about a tag that you want to add or edit
    /// for the specified health check or hosted zone.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The value of <c>Key</c> depends on the operation that you want to perform:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Add a tag to a health check or hosted zone</b>: <c>Key</c> is the name that you
        /// want to give the new tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Edit a tag</b>: <c>Key</c> is the name of the tag that you want to change the
        /// <c>Value</c> for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> Delete a key</b>: <c>Key</c> is the name of the tag you want to remove.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Give a name to a health check</b>: Edit the default <c>Name</c> tag. In the Amazon
        /// Route 53 console, the list of your health checks includes a <b>Name</b> column that
        /// lets you see the name that you've given to each health check.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// The value of <c>Value</c> depends on the operation that you want to perform:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Add a tag to a health check or hosted zone</b>: <c>Value</c> is the value that
        /// you want to give the new tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Edit a tag</b>: <c>Value</c> is the new value that you want to assign the tag.
        /// </para>
        ///  </li> </ul>
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
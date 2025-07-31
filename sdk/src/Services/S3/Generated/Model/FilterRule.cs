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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the Amazon S3 object key name to filter on. An object key name is the name
    /// assigned to an object in your Amazon S3 bucket. You specify whether to filter on the
    /// suffix or prefix of the object key name. A prefix is a specific string of characters
    /// at the beginning of an object key name, which you can use to organize objects. For
    /// example, you can start the key names of related objects with a prefix, such as <c>2023-</c>
    /// or <c>engineering/</c>. Then, you can use <c>FilterRule</c> to find objects in a bucket
    /// with key names that have the same prefix. A suffix is similar to a prefix, but it
    /// is at the end of the object key name instead of at the beginning.
    /// </summary>
    public partial class FilterRule
    {
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The object key name prefix or suffix identifying one or more objects to which the
        /// filtering rule applies. The maximum length is 1,024 characters. Overlapping prefixes
        /// and suffixes are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Event Notifications</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value that the filter searches for in object key names.
        /// </para>
        /// </summary>
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
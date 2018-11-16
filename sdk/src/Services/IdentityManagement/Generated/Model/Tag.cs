/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// A structure that represents user-provided metadata that can be associated with a resource
    /// such as an IAM user or role. For more information about tagging, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
    /// IAM Identities</a> in the <i>IAM User Guide</i>.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key name that can be used to look up or retrieve the associated value. For example,
        /// <code>Department</code> or <code>Cost Center</code> are common choices.
        /// </para>
        /// </summary>
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
        /// The value associated with this tag. For example, tags with a key name of <code>Department</code>
        /// could have values such as <code>Human Resources</code>, <code>Accounting</code>, and
        /// <code>Support</code>. Tags with a key name of <code>Cost Center</code> might have
        /// values that consist of the number associated with the different cost centers in your
        /// company. Typically, many resources have tags with the same key name but with different
        /// values.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS always interprets the tag <code>Value</code> as a single string. If you need to
        /// store an array, you can store comma-separated values in the string. However, you must
        /// interpret the value in your code.
        /// </para>
        ///  </note>
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
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Represents an app's environment variable.
    /// </summary>
    public partial class EnvironmentVariable
    {
        private string _key;
        private bool? _secure;
        private string _value;


        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// (Required) The environment variable's name, which can consist of up to 64 characters
        /// and must be specified. The name can contain upper- and lowercase letters, numbers,
        /// and underscores (_), but it must start with a letter or underscore.
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
        /// Gets and sets the property Secure. 
        /// <para>
        /// (Optional) Whether the variable's value will be returned by the <a>DescribeApps</a>
        /// action. To conceal an environment variable's value, set <code>Secure</code> to <code>true</code>.
        /// <code>DescribeApps</code> then returns <code>**Filtered**</code> instead of the actual
        /// value. The default value for <code>Secure</code> is <code>false</code>. 
        /// </para>
        /// </summary>
        public bool Secure
        {
            get { return this._secure.GetValueOrDefault(); }
            set { this._secure = value; }
        }

        // Check to see if Secure property is set
        internal bool IsSetSecure()
        {
            return this._secure.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// (Optional) The environment variable's value, which can be left empty. If you specify
        /// a value, it can contain up to 256 characters, which must all be printable.
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
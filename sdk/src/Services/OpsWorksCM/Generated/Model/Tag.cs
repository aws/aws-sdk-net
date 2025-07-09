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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// A map that contains tag keys and tag values to attach to an OpsWorks for Chef Automate
    /// or OpsWorks for Puppet Enterprise server. Leading and trailing spaces are trimmed
    /// from both the key and value. A maximum of 50 user-applied tags is allowed for tag-supported
    /// OpsWorks CM resources.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A tag key, such as <c>Stage</c> or <c>Name</c>. A tag key cannot be empty. The key
        /// can be a maximum of 127 characters, and can contain only Unicode letters, numbers,
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
        /// An optional tag value, such as <c>Production</c> or <c>test-owcm-server</c>. The value
        /// can be a maximum of 255 characters, and contain only Unicode letters, numbers, or
        /// separators, or the following special characters: <c>+ - = . _ : /</c> 
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
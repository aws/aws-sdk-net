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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains the value of the <code>Value</code> element for the current
    /// resource record set.
    /// </summary>
    public partial class ResourceRecord
    {
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResourceRecord() { }

        /// <summary>
        /// Instantiates ResourceRecord with the parameterized properties
        /// </summary>
        /// <param name="value">The current or new DNS record value, not to exceed 4,000 characters. In the case of a <code>DELETE</code> action, if the current value does not match the actual value, an error is returned. For descriptions about how to format <code>Value</code> for different record types, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>. You can specify more than one value for all record types except <code>CNAME</code> and <code>SOA</code>. </param>
        public ResourceRecord(string value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current or new DNS record value, not to exceed 4,000 characters. In the case of
        /// a <code>DELETE</code> action, if the current value does not match the actual value,
        /// an error is returned. For descriptions about how to format <code>Value</code> for
        /// different record types, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported
        /// DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one value for all record types except <code>CNAME</code>
        /// and <code>SOA</code>. 
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
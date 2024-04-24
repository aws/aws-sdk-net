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
    /// Information specific to the resource record.
    /// 
    ///  <note> 
    /// <para>
    /// If you're creating an alias resource record set, omit <c>ResourceRecord</c>.
    /// </para>
    ///  </note>
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
        /// <param name="value">The current or new DNS record value, not to exceed 4,000 characters. In the case of a <c>DELETE</c> action, if the current value does not match the actual value, an error is returned. For descriptions about how to format <c>Value</c> for different record types, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>. You can specify more than one value for all record types except <c>CNAME</c> and <c>SOA</c>.  <note> If you're creating an alias resource record set, omit <c>Value</c>. </note></param>
        public ResourceRecord(string value)
        {
            _value = value;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current or new DNS record value, not to exceed 4,000 characters. In the case of
        /// a <c>DELETE</c> action, if the current value does not match the actual value, an error
        /// is returned. For descriptions about how to format <c>Value</c> for different record
        /// types, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/ResourceRecordTypes.html">Supported
        /// DNS Resource Record Types</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify more than one value for all record types except <c>CNAME</c> and <c>SOA</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're creating an alias resource record set, omit <c>Value</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=4000)]
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
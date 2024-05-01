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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A tag associated with an Amazon Web Services resource. Tags are key:value pairs that
    /// you can use to categorize and manage your resources, for purposes like billing or
    /// other management. Typically, the tag key represents a category, such as "environment",
    /// and the tag value represents a specific value within that category, such as "test,"
    /// "development," or "production". Or you might set the tag key to "customer" and the
    /// value to the customer name or ID. You can specify one or more tags to add to each
    /// Amazon Web Services resource, up to 50 tags for a resource.
    /// 
    ///  
    /// <para>
    /// You can tag the Amazon Web Services resources that you manage through WAF: web ACLs,
    /// rule groups, IP sets, and regex pattern sets. You can't manage or view tags through
    /// the WAF console. 
    /// </para>
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Part of the key:value pair that defines a tag. You can use a tag key to describe a
        /// category of information, such as "customer." Tag keys are case-sensitive.
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
        /// Part of the key:value pair that defines a tag. You can use a tag value to describe
        /// a specific value within a category, such as "companyA" or "companyB." Tag values are
        /// case-sensitive.
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
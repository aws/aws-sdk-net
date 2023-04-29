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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// The constraints that you want all returned products to match.
    /// </summary>
    public partial class Filter
    {
        private string _field;
        private FilterType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The product metadata field that you want to filter on. You can filter by just the
        /// service code to see all products for a specific service, filter by just the attribute
        /// name to see a specific attribute for multiple services, or use both a service code
        /// and an attribute name to retrieve only products that match both fields.
        /// </para>
        ///  
        /// <para>
        /// Valid values include: <code>ServiceCode</code>, and all attribute names
        /// </para>
        ///  
        /// <para>
        /// For example, you can filter by the <code>AmazonEC2</code> service code and the <code>volumeType</code>
        /// attribute name to get the prices for only Amazon EC2 volumes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of filter that you want to use.
        /// </para>
        ///  
        /// <para>
        /// Valid values are: <code>TERM_MATCH</code>. <code>TERM_MATCH</code> returns only products
        /// that match both the given filter field and the given value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The service code or attribute value that you want to filter by. If you're filtering
        /// by service code this is the actual service code, such as <code>AmazonEC2</code>. If
        /// you're filtering by attribute name, this is the attribute value that you want the
        /// returned products to match, such as a <code>Provisioned IOPS</code> volume.
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
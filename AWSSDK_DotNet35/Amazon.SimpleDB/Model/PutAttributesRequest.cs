/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the PutAttributes operation.
    /// <para> The PutAttributes operation creates or replaces attributes in an item. The client may specify new attributes using a combination of
    /// the <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> parameters. The client specifies the first attribute by the parameters
    /// <c>Attribute.0.Name</c> and <c>Attribute.0.Value</c> ,
    /// the second attribute by the parameters <c>Attribute.1.Name</c> and <c>Attribute.1.Value</c> , and so on. </para> <para> Attributes are
    /// uniquely identified in an item by their name/value combination. For example, a single item can have the attributes <c>{ "first_name",
    /// "first_value" }</c> and <c>{ "first_name", second_value" }</c> . However, it cannot have two attribute instances where both the
    /// <c>Attribute.X.Name</c> and <c>Attribute.X.Value</c> are the same. </para> <para> Optionally, the requestor can supply the <c>Replace</c>
    /// parameter for each individual attribute. Setting this value to <c>true</c> causes the new attribute value to replace the existing attribute
    /// value(s). For example, if an item has the attributes <c>{ 'a', '1' }</c> ,
    /// 
    /// <c>{ 'b', '2'}</c> and <c>{ 'b', '3' }</c> and the requestor calls <c>PutAttributes</c> using the attributes <c>{ 'b',
    /// '4' }</c> with the <c>Replace</c> parameter set to true, the final attributes of the item are changed to <c>{ 'a', '1' }</c> and <c>{ 'b',
    /// '4' }</c> , which replaces the previous values of the 'b' attribute with the new value. </para> <para><b>NOTE:</b> Using PutAttributes to
    /// replace attribute values that do not exist will not result in an error response. </para> <para> You cannot specify an empty string as an
    /// attribute name. </para> <para> Because Amazon SimpleDB makes multiple copies of client data and uses an eventual consistency update model,
    /// an immediate GetAttributes or Select operation (read) immediately after a PutAttributes or DeleteAttributes operation (write) might not
    /// return the updated data. </para> <para> The following limitations are enforced for this operation:
    /// <ul>
    /// <li>256 total attribute name-value pairs per item</li>
    /// <li>One billion attributes per domain</li>
    /// <li>10 GB of total user data storage per domain</li>
    /// 
    /// </ul>
    /// </para>
    /// </summary>
    public partial class PutAttributesRequest : AmazonWebServiceRequest
    {
        private string domainName;
        private string itemName;
        private List<ReplaceableAttribute> attributes = new List<ReplaceableAttribute>();
        private UpdateCondition expected;

        /// <summary>
        /// The name of the domain in which to perform the operation.
        ///  
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// The name of the item.
        ///  
        /// </summary>
        public string ItemName
        {
            get { return this.itemName; }
            set { this.itemName = value; }
        }

        // Check to see if ItemName property is set
        internal bool IsSetItemName()
        {
            return this.itemName != null;
        }

        /// <summary>
        /// The list of attributes.
        ///  
        /// </summary>
        public List<ReplaceableAttribute> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes.Count > 0;
        }

        /// <summary>
        /// The update condition which, if specified, determines whether the specified attributes will be updated or not. The update condition must be
        /// satisfied in order for this request to be processed and the attributes to be updated.
        ///  
        /// </summary>
        public UpdateCondition Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;
        }

    }
}
    

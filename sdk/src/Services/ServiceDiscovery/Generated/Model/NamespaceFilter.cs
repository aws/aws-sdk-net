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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that identifies the namespaces that you want to list. You can choose
    /// to list public or private namespaces.
    /// </summary>
    public partial class NamespaceFilter
    {
        private FilterCondition _condition;
        private NamespaceFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Specify the operator that you want to use to determine whether a namespace matches
        /// the specified value. Valid values for <code>Condition</code> are one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>EQ</code>: When you specify <code>EQ</code> for <code>Condition</code>, you
        /// can specify only one value. <code>EQ</code> is supported for <code>TYPE</code>, <code>NAME</code>,
        /// and <code>HTTP_NAME</code>. <code>EQ</code> is the default condition and can be omitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BEGINS_WITH</code>: When you specify <code>BEGINS_WITH</code> for <code>Condition</code>,
        /// you can specify only one value. <code>BEGINS_WITH</code> is supported for <code>TYPE</code>,
        /// <code>NAME</code>, and <code>HTTP_NAME</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FilterCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specify the namespaces that you want to get using one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TYPE</code>: Gets the namespaces of the specified type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NAME</code>: Gets the namespaces with the specified name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HTTP_NAME</code>: Gets the namespaces with the specified HTTP name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public NamespaceFilterName Name
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
        /// Gets and sets the property Values. 
        /// <para>
        /// Specify the values that are applicable to the value that you specify for <code>Name</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TYPE</code>: Specify <code>HTTP</code>, <code>DNS_PUBLIC</code>, or <code>DNS_PRIVATE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NAME</code>: Specify the name of the namespace, which is found in <code>Namespace.Name</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HTTP_NAME</code>: Specify the HTTP name of the namespace, which is found in
        /// <code>Namespace.Properties.HttpProperties.HttpName</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
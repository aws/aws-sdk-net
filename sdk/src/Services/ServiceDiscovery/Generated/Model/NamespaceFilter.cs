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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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
        /// The operator that you want to use to determine whether <code>ListNamespaces</code>
        /// returns a namespace. Valid values for <code>condition</code> include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>EQ</code>: When you specify <code>EQ</code> for the condition, you can choose
        /// to list only public namespaces or private namespaces, but not both. <code>EQ</code>
        /// is the default condition and can be omitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN</code>: When you specify <code>IN</code> for the condition, you can choose
        /// to list public namespaces, private namespaces, or both. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BETWEEN</code>: Not applicable
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
        /// Specify <code>TYPE</code>.
        /// </para>
        /// </summary>
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
        /// If you specify <code>EQ</code> for <code>Condition</code>, specify either <code>DNS_PUBLIC</code>
        /// or <code>DNS_PRIVATE</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>IN</code> for <code>Condition</code>, you can specify <code>DNS_PUBLIC</code>,
        /// <code>DNS_PRIVATE</code>, or both.
        /// </para>
        /// </summary>
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
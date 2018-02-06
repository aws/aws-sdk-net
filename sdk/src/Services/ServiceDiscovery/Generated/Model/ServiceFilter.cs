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
    /// A complex type that lets you specify the namespaces that you want to list services
    /// for.
    /// </summary>
    public partial class ServiceFilter
    {
        private FilterCondition _condition;
        private ServiceFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The operator that you want to use to determine whether a service is returned by <code>ListServices</code>.
        /// Valid values for <code>Condition</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>EQ</code>: When you specify <code>EQ</code>, specify one namespace ID for <code>Values</code>.
        /// <code>EQ</code> is the default condition and can be omitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN</code>: When you specify <code>IN</code>, specify a list of the IDs for
        /// the namespaces that you want <code>ListServices</code> to return a list of services
        /// for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BETWEEN</code>: Not applicable.
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
        /// Specify <code>NAMESPACE_ID</code>.
        /// </para>
        /// </summary>
        public ServiceFilterName Name
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
        /// The values that are applicable to the value that you specify for <code>Condition</code>
        /// to filter the list of services.
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
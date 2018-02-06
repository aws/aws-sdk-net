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
    /// A complex type that lets you select the operations that you want to list.
    /// </summary>
    public partial class OperationFilter
    {
        private FilterCondition _condition;
        private OperationFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The operator that you want to use to determine whether an operation matches the specified
        /// value. Valid values for condition include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>EQ</code>: When you specify <code>EQ</code> for the condition, you can specify
        /// only one value. <code>EQ</code> is supported for <code>NAMESPACE_ID</code>, <code>SERVICE_ID</code>,
        /// <code>STATUS</code>, and <code>TYPE</code>. <code>EQ</code> is the default condition
        /// and can be omitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN</code>: When you specify <code>IN</code> for the condition, you can specify
        /// a list of one or more values. <code>IN</code> is supported for <code>STATUS</code>
        /// and <code>TYPE</code>. An operation must match one of the specified values to be returned
        /// in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BETWEEN</code>: Specify a start date and an end date in Unix date/time format
        /// and Coordinated Universal Time (UTC). The start date must be the first value. <code>BETWEEN</code>
        /// is supported for <code>UPDATE_DATE</code>. 
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
        /// Specify the operations that you want to get:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NAMESPACE_ID</b>: Gets operations related to specified namespaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SERVICE_ID</b>: Gets operations related to specified services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STATUS</b>: Gets operations based on the status of the operations: <code>SUBMITTED</code>,
        /// <code>PENDING</code>, <code>SUCCEED</code>, or <code>FAIL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TYPE</b>: Gets specified types of operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATE_DATE</b>: Gets operations that changed status during a specified date/time
        /// range. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OperationFilterName Name
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
        /// Specify values that are applicable to the value that you specify for <code>Name</code>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NAMESPACE_ID</b>: Specify one namespace ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SERVICE_ID</b>: Specify one service ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STATUS</b>: Specify one or more statuses: <code>SUBMITTED</code>, <code>PENDING</code>,
        /// <code>SUCCEED</code>, or <code>FAIL</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TYPE</b>: Specify one or more of the following types: <code>CREATE_NAMESPACE</code>,
        /// <code>DELETE_NAMESPACE</code>, <code>UPDATE_SERVICE</code>, <code>REGISTER_INSTANCE</code>,
        /// or <code>DEREGISTER_INSTANCE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>UPDATE_DATE</b>: Specify a start date and an end date in Unix date/time format
        /// and Coordinated Universal Time (UTC). The start date must be the first value.
        /// </para>
        ///  </li> </ul>
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
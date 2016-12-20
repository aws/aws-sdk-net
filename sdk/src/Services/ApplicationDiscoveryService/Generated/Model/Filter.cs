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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A filter that can use conditional operators.
    /// 
    ///  
    /// <para>
    /// for a complete list of filters and guidance for using them with the Application Discovery
    /// Service, see <a href="http://docs.aws.amazon.com/application-discovery/latest/APIReference/querying-configuration-items.html">Querying
    /// Discovered Configuration Items</a>.
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _condition;
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A conditional operator. The following operators are valid: EQUALS, NOT_EQUALS, CONTAINS,
        /// NOT_CONTAINS. If you specify multiple filters, the system utilizes all filters as
        /// though concatenated by <i>AND</i>. If you specify multiple values for a particular
        /// filter, the system differentiates the values using <i>OR</i>. Calling either <i>DescribeConfigurations</i>
        /// or <i>ListConfigurations</i> returns attributes of matching configuration items.
        /// </para>
        /// </summary>
        public string Condition
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
        /// The name of the filter.
        /// </para>
        /// </summary>
        public string Name
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
        /// A string value that you want to filter on. For example, if you choose the <code>destinationServer.osVersion</code>
        /// filter name, you could specify <code>Ubuntu</code> for the value.
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
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Filter for the DescribeActivation API.
    /// </summary>
    public partial class DescribeActivationsFilter
    {
        private DescribeActivationsFilterKeys _filterKey;
        private List<string> _filterValues = new List<string>();

        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        public DescribeActivationsFilterKeys FilterKey
        {
            get { return this._filterKey; }
            set { this._filterKey = value; }
        }

        // Check to see if FilterKey property is set
        internal bool IsSetFilterKey()
        {
            return this._filterKey != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The filter values.
        /// </para>
        /// </summary>
        public List<string> FilterValues
        {
            get { return this._filterValues; }
            set { this._filterValues = value; }
        }

        // Check to see if FilterValues property is set
        internal bool IsSetFilterValues()
        {
            return this._filterValues != null && this._filterValues.Count > 0; 
        }

    }
}
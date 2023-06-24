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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The default values of the <code>IntegerParameterDeclaration</code>.
    /// </summary>
    public partial class IntegerDefaultValues
    {
        private DynamicDefaultValue _dynamicValue;
        private List<long> _staticValues = new List<long>();

        /// <summary>
        /// Gets and sets the property DynamicValue. 
        /// <para>
        /// The dynamic value of the <code>IntegerDefaultValues</code>. Different defaults are
        /// displayed according to users, groups, and values mapping.
        /// </para>
        /// </summary>
        public DynamicDefaultValue DynamicValue
        {
            get { return this._dynamicValue; }
            set { this._dynamicValue = value; }
        }

        // Check to see if DynamicValue property is set
        internal bool IsSetDynamicValue()
        {
            return this._dynamicValue != null;
        }

        /// <summary>
        /// Gets and sets the property StaticValues. 
        /// <para>
        /// The static values of the <code>IntegerDefaultValues</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50000)]
        public List<long> StaticValues
        {
            get { return this._staticValues; }
            set { this._staticValues = value; }
        }

        // Check to see if StaticValues property is set
        internal bool IsSetStaticValues()
        {
            return this._staticValues != null && this._staticValues.Count > 0; 
        }

    }
}
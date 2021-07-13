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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines a filter used in <a>DescribeInstancePatchStatesForPatchGroup</a> to scope
    /// down the information returned by the API.
    /// 
    ///  
    /// <para>
    ///  <b>Example</b>: To filter for all instances in a patch group having more than three
    /// patches with a <code>FailedCount</code> status, use the following for the filter:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Value for <code>Key</code>: <code>FailedCount</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value for <code>Type</code>: <code>GreaterThan</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value for <code>Values</code>: <code>3</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InstancePatchStateFilter
    {
        private string _key;
        private InstancePatchStateOperatorType _type;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the filter. Supported values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>InstalledCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstalledOtherCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstalledPendingRebootCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InstalledRejectedCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MissingCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FailedCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UnreportedNotApplicableCount</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NotApplicableCount</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of comparison that should be performed for the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstancePatchStateOperatorType Type
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
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter. Must be an integer greater than or equal to 0.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details for a match predicate. A predicate might look for characteristics such as
    /// specific IP addresses, geographic locations, or sizes.
    /// </summary>
    public partial class AwsWafRegionalRateBasedRuleMatchPredicate
    {
        private string _dataId;
        private bool? _negated;
        private string _type;

        /// <summary>
        /// Gets and sets the property DataId. 
        /// <para>
        /// The unique identifier for the predicate.
        /// </para>
        /// </summary>
        public string DataId
        {
            get { return this._dataId; }
            set { this._dataId = value; }
        }

        // Check to see if DataId property is set
        internal bool IsSetDataId()
        {
            return this._dataId != null;
        }

        /// <summary>
        /// Gets and sets the property Negated. 
        /// <para>
        /// If set to <code>true</code>, then the rule actions are performed on requests that
        /// match the predicate settings.
        /// </para>
        ///  
        /// <para>
        /// If set to <code>false</code>, then the rule actions are performed on all requests
        /// except those that match the predicate settings.
        /// </para>
        /// </summary>
        public bool Negated
        {
            get { return this._negated.GetValueOrDefault(); }
            set { this._negated = value; }
        }

        // Check to see if Negated property is set
        internal bool IsSetNegated()
        {
            return this._negated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of predicate. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ByteMatch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GeoMatch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IPMatch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RegexMatch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SizeConstraint</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SqlInjectionMatch</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>XssMatch</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
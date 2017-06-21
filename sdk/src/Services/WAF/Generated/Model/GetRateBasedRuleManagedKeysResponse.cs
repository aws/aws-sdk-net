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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// This is the response object from the GetRateBasedRuleManagedKeys operation.
    /// </summary>
    public partial class GetRateBasedRuleManagedKeysResponse : AmazonWebServiceResponse
    {
        private List<string> _managedKeys = new List<string>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property ManagedKeys. 
        /// <para>
        /// An array of IP addresses that currently are blocked by the specified <a>RateBasedRule</a>.
        /// 
        /// </para>
        /// </summary>
        public List<string> ManagedKeys
        {
            get { return this._managedKeys; }
            set { this._managedKeys = value; }
        }

        // Check to see if ManagedKeys property is set
        internal bool IsSetManagedKeys()
        {
            return this._managedKeys != null && this._managedKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A null value and not currently used.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}
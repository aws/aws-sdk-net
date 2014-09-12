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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The ListenerDescription data type.
    /// </summary>
    public partial class ListenerDescription
    {
        private Listener _listener;
        private List<string> _policyNames = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListenerDescription() { }

        /// <summary>
        /// Gets and sets the property Listener.
        /// </summary>
        public Listener Listener
        {
            get { return this._listener; }
            set { this._listener = value; }
        }

        // Check to see if Listener property is set
        internal bool IsSetListener()
        {
            return this._listener != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyNames. 
        /// <para>
        ///  A list of policies enabled for this listener. An empty list indicates that no policies
        /// are enabled. 
        /// </para>
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this._policyNames; }
            set { this._policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this._policyNames != null && this._policyNames.Count > 0; 
        }

    }
}
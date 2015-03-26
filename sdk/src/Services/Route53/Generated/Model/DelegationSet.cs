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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains name server information.
    /// </summary>
    public partial class DelegationSet
    {
        private string _id;
        private string _callerReference;
        private List<string> _nameServers = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DelegationSet() { }

        /// <summary>
        /// Instantiates DelegationSet with the parameterized properties
        /// </summary>
        /// <param name="nameServers">A complex type that contains the authoritative name servers for the hosted zone. Use the method provided by your domain registrar to add an NS record to your domain for each <code>NameServer</code> that is assigned to your hosted zone.</param>
        public DelegationSet(List<string> nameServers)
        {
            _nameServers = nameServers;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReference.
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property NameServers. 
        /// <para>
        /// A complex type that contains the authoritative name servers for the hosted zone. Use
        /// the method provided by your domain registrar to add an NS record to your domain for
        /// each <code>NameServer</code> that is assigned to your hosted zone.
        /// </para>
        /// </summary>
        public List<string> NameServers
        {
            get { return this._nameServers; }
            set { this._nameServers = value; }
        }

        // Check to see if NameServers property is set
        internal bool IsSetNameServers()
        {
            return this._nameServers != null && this._nameServers.Count > 0; 
        }

    }
}
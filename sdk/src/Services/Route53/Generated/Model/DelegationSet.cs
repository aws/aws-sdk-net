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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that lists the name servers in a delegation set, as well as the <c>CallerReference</c>
    /// and the <c>ID</c> for the delegation set.
    /// </summary>
    public partial class DelegationSet
    {
        private string _id;
        private string _callerReference;
        private List<string> _nameServers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DelegationSet() { }

        /// <summary>
        /// Instantiates DelegationSet with the parameterized properties
        /// </summary>
        /// <param name="nameServers">A complex type that contains a list of the authoritative name servers for a hosted zone or for a reusable delegation set.</param>
        public DelegationSet(List<string> nameServers)
        {
            _nameServers = nameServers;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Route 53 assigns to a reusable delegation set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
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
        /// <para>
        /// The value that you specified for <c>CallerReference</c> when you created the reusable
        /// delegation set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// A complex type that contains a list of the authoritative name servers for a hosted
        /// zone or for a reusable delegation set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> NameServers
        {
            get { return this._nameServers; }
            set { this._nameServers = value; }
        }

        // Check to see if NameServers property is set
        internal bool IsSetNameServers()
        {
            return this._nameServers != null && (this._nameServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
    /// Container for the parameters to the DeleteTrafficPolicy operation.
    /// Deletes a traffic policy.
    /// 
    ///  
    /// <para>
    /// When you delete a traffic policy, Route 53 sets a flag on the policy to indicate that
    /// it has been deleted. However, Route 53 never fully deletes the traffic policy. Note
    /// the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Deleted traffic policies aren't listed if you run <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListTrafficPolicies.html">ListTrafficPolicies</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  There's no way to get a list of deleted policies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you retain the ID of the policy, you can get information about the policy, including
    /// the traffic policy document, by running <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetTrafficPolicy.html">GetTrafficPolicy</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteTrafficPolicyRequest : AmazonRoute53Request
    {
        private string _id;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the traffic policy that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the traffic policy that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}
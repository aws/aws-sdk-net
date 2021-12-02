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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIpamScope operation.
    /// Delete the scope for an IPAM. You cannot delete the default scopes.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="/vpc/latest/ipam/delete-scope-ipam.html">Delete
    /// a scope</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteIpamScopeRequest : AmazonEC2Request
    {
        private string _ipamScopeId;

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

    }
}
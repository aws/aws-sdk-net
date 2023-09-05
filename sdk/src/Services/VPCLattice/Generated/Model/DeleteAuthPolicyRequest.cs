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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAuthPolicy operation.
    /// Deletes the specified auth policy. If an auth is set to <code>Amazon Web Services_IAM</code>
    /// and the auth policy is deleted, all requests will be denied by default. If you are
    /// trying to remove the auth policy completely, you must set the auth_type to <code>NONE</code>.
    /// If auth is enabled on the resource, but no auth policy is set, all requests will be
    /// denied.
    /// </summary>
    public partial class DeleteAuthPolicyRequest : AmazonVPCLatticeRequest
    {
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=200)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}
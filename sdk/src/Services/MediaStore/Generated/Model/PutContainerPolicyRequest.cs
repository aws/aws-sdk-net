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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the PutContainerPolicy operation.
    /// Creates an access policy for the specified container to restrict the users and clients
    /// that can access it. For information about the data that is included in an access policy,
    /// see the <a href="https://aws.amazon.com/documentation/iam/">AWS Identity and Access
    /// Management User Guide</a>.
    /// 
    ///  
    /// <para>
    /// For this release of the REST API, you can create only one policy for a container.
    /// If you enter <c>PutContainerPolicy</c> twice, the second command modifies the existing
    /// policy. 
    /// </para>
    /// </summary>
    public partial class PutContainerPolicyRequest : AmazonMediaStoreRequest
    {
        private string _containerName;
        private string _policy;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The contents of the policy, which includes the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One <c>Version</c> tag
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One <c>Statement</c> tag that contains the standard tags for the policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
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
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// This is the response object from the CreateEnvironmentMembership operation.
    /// </summary>
    public partial class CreateEnvironmentMembershipResponse : AmazonWebServiceResponse
    {
        private EnvironmentMember _membership;

        /// <summary>
        /// Gets and sets the property Membership. 
        /// <para>
        /// Information about the environment member that was added.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentMember Membership
        {
            get { return this._membership; }
            set { this._membership = value; }
        }

        // Check to see if Membership property is set
        internal bool IsSetMembership()
        {
            return this._membership != null;
        }

    }
}
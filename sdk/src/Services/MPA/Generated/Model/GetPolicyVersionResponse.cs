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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyVersion operation.
    /// </summary>
    public partial class GetPolicyVersionResponse : AmazonWebServiceResponse
    {
        private PolicyVersion _policyVersion;

        /// <summary>
        /// Gets and sets the property PolicyVersion. 
        /// <para>
        /// A <c>PolicyVersion</c> object. Contains details for the version of the policy. Policies
        /// define the permissions for team resources.
        /// </para>
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyVersion PolicyVersion
        {
            get { return this._policyVersion; }
            set { this._policyVersion = value; }
        }

        // Check to see if PolicyVersion property is set
        internal bool IsSetPolicyVersion()
        {
            return this._policyVersion != null;
        }

    }
}
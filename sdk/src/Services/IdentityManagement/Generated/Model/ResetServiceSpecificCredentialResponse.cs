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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the ResetServiceSpecificCredential operation.
    /// </summary>
    public partial class ResetServiceSpecificCredentialResponse : AmazonWebServiceResponse
    {
        private ServiceSpecificCredential _serviceSpecificCredential;

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredential. 
        /// <para>
        /// A structure with details about the updated service-specific credential, including
        /// the new password.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is the <b>only</b> time that you can access the password. You cannot recover
        /// the password later, but you can reset it again.
        /// </para>
        ///  </important>
        /// </summary>
        public ServiceSpecificCredential ServiceSpecificCredential
        {
            get { return this._serviceSpecificCredential; }
            set { this._serviceSpecificCredential = value; }
        }

        // Check to see if ServiceSpecificCredential property is set
        internal bool IsSetServiceSpecificCredential()
        {
            return this._serviceSpecificCredential != null;
        }

    }
}
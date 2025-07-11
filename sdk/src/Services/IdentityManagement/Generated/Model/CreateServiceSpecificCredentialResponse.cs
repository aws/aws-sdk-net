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
    /// This is the response object from the CreateServiceSpecificCredential operation.
    /// </summary>
    public partial class CreateServiceSpecificCredentialResponse : AmazonWebServiceResponse
    {
        private ServiceSpecificCredential _serviceSpecificCredential;

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredential. 
        /// <para>
        /// A structure that contains information about the newly created service-specific credential.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is the only time that the password for this credential set is available. It cannot
        /// be recovered later. Instead, you must reset the password with <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ResetServiceSpecificCredential.html">ResetServiceSpecificCredential</a>.
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
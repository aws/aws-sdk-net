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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the ListServiceSpecificCredentials operation.
    /// </summary>
    public partial class ListServiceSpecificCredentialsResponse : AmazonWebServiceResponse
    {
        private List<ServiceSpecificCredentialMetadata> _serviceSpecificCredentials = new List<ServiceSpecificCredentialMetadata>();

        /// <summary>
        /// Gets and sets the property ServiceSpecificCredentials. 
        /// <para>
        /// A list of structures that each contain details about a service-specific credential.
        /// </para>
        /// </summary>
        public List<ServiceSpecificCredentialMetadata> ServiceSpecificCredentials
        {
            get { return this._serviceSpecificCredentials; }
            set { this._serviceSpecificCredentials = value; }
        }

        // Check to see if ServiceSpecificCredentials property is set
        internal bool IsSetServiceSpecificCredentials()
        {
            return this._serviceSpecificCredentials != null && this._serviceSpecificCredentials.Count > 0; 
        }

    }
}
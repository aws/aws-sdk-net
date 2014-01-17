/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIdentity operation.
    /// <para>Deletes the specified identity (email address or domain) from the list of verified identities.</para> <para>This action is throttled
    /// at one request per second.</para>
    /// </summary>
    public partial class DeleteIdentityRequest : AmazonSimpleEmailServiceRequest
    {
        private string identity;


        /// <summary>
        /// The identity to be removed from the list of identities for the AWS Account.
        ///  
        /// </summary>
        public string Identity
        {
            get { return this.identity; }
            set { this.identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this.identity != null;
        }

    }
}
    

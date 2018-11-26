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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServer operation.
    /// Instantiates an autoscaling virtual server based on Secure File Transfer Protocol
    /// (SFTP) in AWS. The call returns the <code>ServerId</code> property assigned by the
    /// service to the newly created server. Reference this <code>ServerId</code> property
    /// when you make updates to your server, or work with users.
    /// 
    ///  
    /// <para>
    /// The response returns the <code>ServerId</code> value for the newly created server.
    /// </para>
    /// </summary>
    public partial class CreateServerRequest : AmazonTransferRequest
    {
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        ///  An array containing all of the information required to call a customer-supplied authentication
        /// API. This parameter is not required when the <code>IdentityProviderType</code> value
        /// of server that is created uses the <code>SERVICE_MANAGED</code> authentication method.
        /// </para>
        /// </summary>
        public IdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// The mode of authentication enabled for this service. The default value is <code>SERVICE_MANAGED</code>,
        /// which allows you to store and access SFTP user credentials within the service. An
        /// <code>IdentityProviderType</code> value of <code>API_GATEWAY</code> indicates that
        /// user authentication requires a call to an API Gateway endpoint URL provided by you
        /// to integrate an identity provider of your choice.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// A value that allows the service to write your SFTP users’ activity to your Amazon
        /// CloudWatch logs for monitoring and auditing purposes.
        /// </para>
        /// </summary>
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for servers.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
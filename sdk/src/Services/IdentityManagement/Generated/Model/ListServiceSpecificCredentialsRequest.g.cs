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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListServiceSpecificCredentials operation. Returns
    /// information about the service-specific credentials associated with the specified IAM
    /// user. If none exists, the operation returns an empty list. The service-specific credentials
    /// returned by this operation are used only for authenticating the IAM user to a specific
    /// service. For more information about using service-specific credentials to authenticate
    /// to an Amazon Web Services service, refer to the following docs: <ul> <li> <para> For
    /// service-specific credentials with CodeCommit, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">IAM
    /// credentials for CodeCommit: Git credentials, SSH keys, and Amazon Web Services access
    /// keys</a> in the <i>IAM User Guide</i>. </para> </li> <li> <para> For service-specific
    /// credentials with Amazon Keyspaces (for Apache Cassandra), refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_keyspaces.html">Use
    /// IAM with Amazon Keyspaces (for Apache Cassandra)</a> in the <i>IAM User Guide</i>.
    /// </para> </li> <li> <para> For services that support long-term API keys, refer to <a
    /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_api_keys_for_aws_services.html">API
    /// keys for Amazon Web Services services</a> in the <i>IAM User Guide</i>. </para> </li>
    /// </ul>
    /// </summary>
    public partial class ListServiceSpecificCredentialsRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AllUsers. 
        /// <para>
        /// A flag indicating whether to list service specific credentials for all users. This
        /// parameter cannot be specified together with UserName. When true, returns all credentials
        /// associated with the specified service.
        /// </para>
        /// </summary>
        public bool? AllUsers { get; set; }

        /// <summary>
        /// Checks to see if the AllUsers property is set.
        /// </summary>
        internal bool IsSetAllUsers() => this.AllUsers.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the Marker from
        /// the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 320)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If additional items exist beyond the maximum you specify, the
        /// IsTruncated response element is true.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Filters the returned results to only those for the specified Amazon Web Services service.
        /// If not specified, then Amazon Web Services returns service-specific credentials for
        /// all services.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose service-specific credentials you want information about.
        /// If this value is not specified, then the operation assumes the user whose credentials
        /// are used to call the operation.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}

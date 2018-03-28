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
    /// Container for the parameters to the ListServiceSpecificCredentials operation.
    /// Returns information about the service-specific credentials associated with the specified
    /// IAM user. If there are none, the operation returns an empty list. The service-specific
    /// credentials returned by this operation are used only for authenticating the IAM user
    /// to a specific service. For more information about using service-specific credentials
    /// to authenticate to an AWS service, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html">Set
    /// Up service-specific credentials</a> in the AWS CodeCommit User Guide.
    /// </summary>
    public partial class ListServiceSpecificCredentialsRequest : AmazonIdentityManagementServiceRequest
    {
        private string _serviceName;
        private string _userName;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Filters the returned results to only those for the specified AWS service. If not specified,
        /// then AWS returns service-specific credentials for all services.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user whose service-specific credentials you want information about.
        /// If this value is not specified, then the operation assumes the user whose credentials
        /// are used to call the operation.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}
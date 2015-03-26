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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment error.
    /// </summary>
    public partial class ErrorInformation
    {
        private ErrorCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code:
        /// </para>
        ///  <ul> <li>APPLICATION_MISSING: The application was missing. Note that this error code
        /// will most likely be raised if the application is deleted after the deployment is created
        /// but before it starts.</li> <li>DEPLOYMENT_GROUP_MISSING: The deployment group was
        /// missing. Note that this error code will most likely be raised if the deployment group
        /// is deleted after the deployment is created but before it starts.</li> <li>REVISION_MISSING:
        /// The revision ID was missing. Note that this error code will most likely be raised
        /// if the revision is deleted after the deployment is created but before it starts.</li>
        /// <li>IAM_ROLE_MISSING: The service role cannot be accessed.</li> <li>IAM_ROLE_PERMISSIONS:
        /// The service role does not have the correct permissions.</li> <li>OVER_MAX_INSTANCES:
        /// The maximum number of instances was exceeded.</li> <li>NO_INSTANCES: No instances
        /// were specified, or no instances can be found.</li> <li>TIMEOUT: The deployment has
        /// timed out.</li> <li>HEALTH_CONSTRAINTS_INVALID: The revision can never successfully
        /// deploy under the instance health constraints as specified.</li> <li>HEALTH_CONSTRAINTS:
        /// The deployment failed on too many instances to be able to successfully deploy under
        /// the specified instance health constraints.</li> <li>INTERNAL_ERROR: There was an internal
        /// error.</li> </ul>
        /// </summary>
        public ErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An accompanying error message.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}
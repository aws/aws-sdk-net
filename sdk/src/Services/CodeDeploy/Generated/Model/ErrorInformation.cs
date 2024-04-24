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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
        /// For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/error-codes.html">Error
        /// Codes for CodeDeploy</a> in the <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide">CodeDeploy
        /// User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// The error code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// APPLICATION_MISSING: The application was missing. This error code is most likely raised
        /// if the application is deleted after the deployment is created, but before it is started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_GROUP_MISSING: The deployment group was missing. This error code is most
        /// likely raised if the deployment group is deleted after the deployment is created,
        /// but before it is started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HEALTH_CONSTRAINTS: The deployment failed on too many instances to be successfully
        /// deployed within the instance health constraints specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HEALTH_CONSTRAINTS_INVALID: The revision cannot be successfully deployed within the
        /// instance health constraints specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM_ROLE_MISSING: The service role cannot be accessed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM_ROLE_PERMISSIONS: The service role does not have the correct permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INTERNAL_ERROR: There was an internal error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NO_EC2_SUBSCRIPTION: The calling account is not subscribed to Amazon EC2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NO_INSTANCES: No instances were specified, or no instances can be found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OVER_MAX_INSTANCES: The maximum number of instances was exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// THROTTLED: The operation was throttled because the calling account exceeded the throttling
        /// limits of one or more Amazon Web Services services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TIMEOUT: The deployment has timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REVISION_MISSING: The revision ID was missing. This error code is most likely raised
        /// if the revision is deleted after the deployment is created, but before it is started.
        /// </para>
        ///  </li> </ul>
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
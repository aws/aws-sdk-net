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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the current state of a container service.
    /// </summary>
    public partial class ContainerServiceStateDetail
    {
        private ContainerServiceStateDetailCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The state code of the container service.
        /// </para>
        ///  
        /// <para>
        /// The following state codes are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following state codes are possible if your container service is in a <c>DEPLOYING</c>
        /// or <c>UPDATING</c> state:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING_SYSTEM_RESOURCES</c> - The system resources for your container service
        /// are being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING_NETWORK_INFRASTRUCTURE</c> - The network infrastructure for your container
        /// service are being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONING_CERTIFICATE</c> - The SSL/TLS certificate for your container service
        /// is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONING_SERVICE</c> - Your container service is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING_DEPLOYMENT</c> - Your deployment is being created on your container service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EVALUATING_HEALTH_CHECK</c> - The health of your deployment is being evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATING_DEPLOYMENT</c> - Your deployment is being activated.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The following state codes are possible if your container service is in a <c>PENDING</c>
        /// state:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CERTIFICATE_LIMIT_EXCEEDED</c> - The SSL/TLS certificate required for your container
        /// service exceeds the maximum number of certificates allowed for your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN_ERROR</c> - An error was experienced when your container service was being
        /// created.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ContainerServiceStateDetailCode Code
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
        /// A message that provides more information for the state code.
        /// </para>
        ///  <note> 
        /// <para>
        /// The state detail is populated only when a container service is in a <c>PENDING</c>,
        /// <c>DEPLOYING</c>, or <c>UPDATING</c> state.
        /// </para>
        ///  </note>
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
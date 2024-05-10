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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the deployment controller type that the service uses.
    /// </summary>
    public partial class AwsEcsServiceDeploymentControllerDetails
    {
        private string _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The rolling update (<c>ECS</c>) deployment type replaces the current running version
        /// of the container with the latest version.
        /// </para>
        ///  
        /// <para>
        /// The blue/green (<c>CODE_DEPLOY</c>) deployment type uses the blue/green deployment
        /// model that is powered by CodeDeploy. This deployment model a new deployment of a service
        /// can be verified before production traffic is sent to it.
        /// </para>
        ///  
        /// <para>
        /// The external (<c>EXTERNAL</c>) deployment type allows the use of any third-party deployment
        /// controller for full control over the deployment process for an Amazon ECS service.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ECS</c> | <c>CODE_DEPLOY</c> | <c>EXTERNAL</c> 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
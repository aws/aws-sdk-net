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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// <zonbook></zonbook><xhtml></xhtml>
    /// </summary>
    public partial class CreateServiceResponse : AmazonWebServiceResponse
    {
        private Service _service;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The full description of your service following the create call.
        /// </para>
        ///  
        /// <para>
        /// A service will return either a <c>capacityProviderStrategy</c> or <c>launchType</c>
        /// parameter, but not both, depending where one was specified when it was created.
        /// </para>
        ///  
        /// <para>
        /// If a service is using the <c>ECS</c> deployment controller, the <c>deploymentController</c>
        /// and <c>taskSets</c> parameters will not be returned.
        /// </para>
        ///  
        /// <para>
        /// if the service uses the <c>CODE_DEPLOY</c> deployment controller, the <c>deploymentController</c>,
        /// <c>taskSets</c> and <c>deployments</c> parameters will be returned, however the <c>deployments</c>
        /// parameter will be an empty list.
        /// </para>
        ///  
        /// <para>
        /// The response includes a <c>lifecycleHookDetails</c> field, which is an empty array
        /// when the service is created or updated. The values are populated when a lifecycle
        /// hook executes and are available as part of the service deployment details (<a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServiceDeployments.html">DescribeServiceDeployments</a>).
        /// </para>
        /// </summary>
        public Service Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}
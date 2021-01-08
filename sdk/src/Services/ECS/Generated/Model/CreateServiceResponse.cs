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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// This is the response object from the CreateService operation.
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
        /// If a service is using the <code>ECS</code> deployment controller, the <code>deploymentController</code>
        /// and <code>taskSets</code> parameters will not be returned.
        /// </para>
        ///  
        /// <para>
        /// If the service is using the <code>CODE_DEPLOY</code> deployment controller, the <code>deploymentController</code>,
        /// <code>taskSets</code> and <code>deployments</code> parameters will be returned, however
        /// the <code>deployments</code> parameter will be an empty list.
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
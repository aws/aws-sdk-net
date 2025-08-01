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
    /// The test traffic routing configuration for Amazon ECS blue/green deployments. This
    /// configuration allows you to define rules for routing specific traffic to the new service
    /// revision during the deployment process, allowing for safe testing before full production
    /// traffic shift.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect-blue-green.html">Service
    /// Connect for Amazon ECS blue/green deployments</a> in the <i> Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServiceConnectTestTrafficRules
    {
        private ServiceConnectTestTrafficHeaderRules _header;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The HTTP header-based routing rules that determine which requests should be routed
        /// to the new service version during blue/green deployment testing. These rules provide
        /// fine-grained control over test traffic routing based on request headers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceConnectTestTrafficHeaderRules Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

    }
}
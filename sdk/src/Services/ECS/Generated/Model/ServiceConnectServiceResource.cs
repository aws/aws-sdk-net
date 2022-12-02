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
    /// The Service Connect resource. Each configuration maps a discovery name to a Cloud
    /// Map service name. The data is stored in Cloud Map as part of the Service Connect configuration
    /// for each discovery name of this Amazon ECS service.
    /// 
    ///  
    /// <para>
    /// A task can resolve the <code>dnsName</code> for each of the <code>clientAliases</code>
    /// of a service. However a task can't resolve the discovery names. If you want to connect
    /// to a service, refer to the <code>ServiceConnectConfiguration</code> of that service
    /// for the list of <code>clientAliases</code> that you can use.
    /// </para>
    /// </summary>
    public partial class ServiceConnectServiceResource
    {
        private string _discoveryArn;
        private string _discoveryName;

        /// <summary>
        /// Gets and sets the property DiscoveryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the namespace in Cloud Map that matches the discovery
        /// name for this Service Connect resource. You can use this ARN in other integrations
        /// with Cloud Map. However, Service Connect can't ensure connectivity outside of Amazon
        /// ECS.
        /// </para>
        /// </summary>
        public string DiscoveryArn
        {
            get { return this._discoveryArn; }
            set { this._discoveryArn = value; }
        }

        // Check to see if DiscoveryArn property is set
        internal bool IsSetDiscoveryArn()
        {
            return this._discoveryArn != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryName. 
        /// <para>
        /// The discovery name of this Service Connect resource.
        /// </para>
        ///  
        /// <para>
        /// The <code>discoveryName</code> is the name of the new Cloud Map service that Amazon
        /// ECS creates for this Amazon ECS service. This must be unique within the Cloud Map
        /// namespace. The name can contain up to 64 characters. The name can include lowercase
        /// letters, numbers, underscores (_), and hyphens (-). The name can't start with a hyphen.
        /// </para>
        ///  
        /// <para>
        /// If this parameter isn't specified, the default value of <code>discoveryName.namespace</code>
        /// is used. If the <code>discoveryName</code> isn't specified, the port mapping name
        /// from the task definition is used in <code>portName.namespace</code>.
        /// </para>
        /// </summary>
        public string DiscoveryName
        {
            get { return this._discoveryName; }
            set { this._discoveryName = value; }
        }

        // Check to see if DiscoveryName property is set
        internal bool IsSetDiscoveryName()
        {
            return this._discoveryName != null;
        }

    }
}
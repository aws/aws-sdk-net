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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about a service discovery registry to assign to the service.
    /// </summary>
    public partial class AwsEcsServiceServiceRegistriesDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The container name value to use for the service discovery service.
        /// </para>
        ///  
        /// <para>
        /// If the task definition uses the <c>bridge</c> or <c>host</c> network mode, you must
        /// specify <c>ContainerName</c> and <c>ContainerPort</c>.
        /// </para>
        ///  
        /// <para>
        /// If the task definition uses the <c>awsvpc</c> network mode and a type SRV DNS record,
        /// you must specify either <c>ContainerName</c> and <c>ContainerPort</c>, or <c>Port</c>
        /// , but not both.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port value to use for the service discovery service.
        /// </para>
        ///  
        /// <para>
        /// If the task definition uses the <c>bridge</c> or <c>host</c> network mode, you must
        /// specify <c>ContainerName</c> and <c>ContainerPort</c>.
        /// </para>
        ///  
        /// <para>
        /// If the task definition uses the <c>awsvpc</c> network mode and a type SRV DNS record,
        /// you must specify either <c>ContainerName</c> and <c>ContainerPort</c>, or <c>Port</c>
        /// , but not both.
        /// </para>
        /// </summary>
        public int? ContainerPort { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPort property is set.
        /// </summary>
        internal bool IsSetContainerPort() => this.ContainerPort.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port value to use for a service discovery service that specifies an SRV record.
        /// This field can be used if both the <c>awsvpc</c>awsvpc network mode and SRV records
        /// are used.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryArn. 
        /// <para>
        /// The ARN of the service registry.
        /// </para>
        /// </summary>
        public string RegistryArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistryArn property is set.
        /// </summary>
        internal bool IsSetRegistryArn() => this.RegistryArn != null;
    }
}

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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// If a health check or hosted zone was created by another service, <c>LinkedService</c>
    /// is a complex type that describes the service that created the resource. When a resource
    /// is created by another service, you can't edit or delete it using Amazon Route 53.
    /// </summary>
    public partial class LinkedService
    {
        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// If the health check or hosted zone was created by another service, the service that
        /// created the resource. When a resource is created by another service, you can't edit
        /// or delete it using Amazon Route 53. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ServicePrincipal property is set.
        /// </summary>
        internal bool IsSetServicePrincipal() => this.ServicePrincipal != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// If the health check or hosted zone was created by another service, an optional description
        /// that can be provided by the other service. When a resource is created by another service,
        /// you can't edit or delete it using Amazon Route 53. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}

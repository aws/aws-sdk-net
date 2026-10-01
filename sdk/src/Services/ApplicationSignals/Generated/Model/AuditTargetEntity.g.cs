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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A union structure that contains the specific entity information for different types
    /// of audit targets.
    /// </summary>
    public partial class AuditTargetEntity
    {
        /// <summary>
        /// Gets and sets the property Canary. 
        /// <para>
        /// Canary entity information when the audit target is a CloudWatch Synthetics canary.
        /// </para>
        /// </summary>
        public CanaryEntity Canary { get; set; }

        /// <summary>
        /// Checks to see if the Canary property is set.
        /// </summary>
        internal bool IsSetCanary() => this.Canary != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// Service entity information when the audit target is a service.
        /// </para>
        /// </summary>
        public ServiceEntity Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceOperation. 
        /// <para>
        /// Service operation entity information when the audit target is a specific service operation.
        /// </para>
        /// </summary>
        public ServiceOperationEntity ServiceOperation { get; set; }

        /// <summary>
        /// Checks to see if the ServiceOperation property is set.
        /// </summary>
        internal bool IsSetServiceOperation() => this.ServiceOperation != null;

        /// <summary>
        /// Gets and sets the property Slo. 
        /// <para>
        /// SLO entity information when the audit target is a service level objective.
        /// </para>
        /// </summary>
        public ServiceLevelObjectiveEntity Slo { get; set; }

        /// <summary>
        /// Checks to see if the Slo property is set.
        /// </summary>
        internal bool IsSetSlo() => this.Slo != null;
    }
}

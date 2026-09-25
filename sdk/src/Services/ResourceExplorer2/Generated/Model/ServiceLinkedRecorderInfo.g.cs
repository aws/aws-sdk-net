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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Contains information about the service-linked recorder paired with a service view.
    /// </summary>
    public partial class ServiceLinkedRecorderInfo
    {
        /// <summary>
        /// Gets and sets the property RecorderName. 
        /// <para>
        /// The name of the service-linked recorder, such as <c>AWSConfigurationRecorderForObservabilityAdmin</c>.
        /// </para>
        /// </summary>
        public string RecorderName { get; set; }

        /// <summary>
        /// Checks to see if the RecorderName property is set.
        /// </summary>
        internal bool IsSetRecorderName() => this.RecorderName != null;

        /// <summary>
        /// Gets and sets the property RecorderType. 
        /// <para>
        /// The type of the recorder. Valid values are <c>AWS</c> and <c>THIRD_PARTY</c>.
        /// </para>
        /// </summary>
        public RecorderType RecorderType { get; set; }

        /// <summary>
        /// Checks to see if the RecorderType property is set.
        /// </summary>
        internal bool IsSetRecorderType() => this.RecorderType != null;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal of the Amazon Web Services service that owns the service-linked
        /// recorder, such as <c>observabilityadmin.amazonaws.com</c>.
        /// </para>
        /// </summary>
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ServicePrincipal property is set.
        /// </summary>
        internal bool IsSetServicePrincipal() => this.ServicePrincipal != null;
    }
}

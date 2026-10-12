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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// The detailed data about the current state of the component.
    /// </summary>
    public partial class ComponentState
    {
        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that this component is attached to. Provided when
        /// a component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <c>serviceInstanceName</c> is associated with. Provided
        /// when a component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that the component uses to access service inputs. Provided when a
        /// component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpec property is set.
        /// </summary>
        internal bool IsSetServiceSpec() => this.ServiceSpec != null;

        /// <summary>
        /// Gets and sets the property TemplateFile. 
        /// <para>
        /// The template file used.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string TemplateFile { get; set; }

        /// <summary>
        /// Checks to see if the TemplateFile property is set.
        /// </summary>
        internal bool IsSetTemplateFile() => this.TemplateFile != null;
    }
}

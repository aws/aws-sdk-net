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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configuration to use to enable the different types of interactive use cases in
    /// an application.
    /// </summary>
    public partial class InteractiveConfiguration
    {
        /// <summary>
        /// Gets and sets the property LivyEndpointEnabled. 
        /// <para>
        /// Enables an Apache Livy endpoint that you can connect to and run interactive jobs.
        /// </para>
        /// </summary>
        public bool? LivyEndpointEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LivyEndpointEnabled property is set.
        /// </summary>
        internal bool IsSetLivyEndpointEnabled() => this.LivyEndpointEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SessionEnabled. 
        /// <para>
        /// Enables interactive sessions on the application. When set to <c>true</c>, you can
        /// start interactive sessions using the <c>StartSession</c> operation.
        /// </para>
        /// </summary>
        public bool? SessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionEnabled property is set.
        /// </summary>
        internal bool IsSetSessionEnabled() => this.SessionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property StudioEnabled. 
        /// <para>
        /// Enables you to connect an application to Amazon EMR Studio to run interactive workloads
        /// in a notebook.
        /// </para>
        /// </summary>
        public bool? StudioEnabled { get; set; }

        /// <summary>
        /// Checks to see if the StudioEnabled property is set.
        /// </summary>
        internal bool IsSetStudioEnabled() => this.StudioEnabled.HasValue;
    }
}

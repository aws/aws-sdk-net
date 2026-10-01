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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The system attributes that are used with the message template.
    /// </summary>
    public partial class SystemAttributes
    {
        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The CustomerEndpoint attribute.
        /// </para>
        /// </summary>
        public SystemEndpointAttributes CustomerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomerEndpoint() => this.CustomerEndpoint != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// The SystemEndpoint attribute.
        /// </para>
        /// </summary>
        public SystemEndpointAttributes SystemEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SystemEndpoint property is set.
        /// </summary>
        internal bool IsSetSystemEndpoint() => this.SystemEndpoint != null;
    }
}

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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A section of the network that a network flow has traveled through.
    /// </summary>
    public partial class TraversedComponent
    {
        /// <summary>
        /// Gets and sets the property ComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a traversed component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ComponentArn { get; set; }

        /// <summary>
        /// Checks to see if the ComponentArn property is set.
        /// </summary>
        internal bool IsSetComponentArn() => this.ComponentArn != null;

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The identifier for the traversed component.
        /// </para>
        /// </summary>
        public string ComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentId property is set.
        /// </summary>
        internal bool IsSetComponentId() => this.ComponentId != null;

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of component that was traversed.
        /// </para>
        /// </summary>
        public string ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The service name for the traversed component.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}

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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// The result of a successful Resource request, with status for an individual resource.
    /// </summary>
    public partial class ResourceResult
    {
        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The component id of the resource.
        /// </para>
        /// </summary>
        public string ComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentId property is set.
        /// </summary>
        internal bool IsSetComponentId() => this.ComponentId != null;

        /// <summary>
        /// Gets and sets the property LastCheckedTimestamp. 
        /// <para>
        /// The time (UTC) that the resource was last checked for readiness, in ISO-8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastCheckedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastCheckedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastCheckedTimestamp() => this.LastCheckedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness of a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Readiness Readiness { get; set; }

        /// <summary>
        /// Checks to see if the Readiness property is set.
        /// </summary>
        internal bool IsSetReadiness() => this.Readiness != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}

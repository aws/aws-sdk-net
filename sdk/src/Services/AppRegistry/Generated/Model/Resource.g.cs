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

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// The information about the resource.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon resource name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// The time the resource was associated with the application.
        /// </para>
        /// </summary>
        public DateTime? AssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the AssociationTime property is set.
        /// </summary>
        internal bool IsSetAssociationTime() => this.AssociationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Integrations. 
        /// <para>
        /// The service integration information about the resource. 
        /// </para>
        /// </summary>
        public ResourceIntegrations Integrations { get; set; }

        /// <summary>
        /// Checks to see if the Integrations property is set.
        /// </summary>
        internal bool IsSetIntegrations() => this.Integrations != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}

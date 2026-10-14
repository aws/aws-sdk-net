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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEndpoint operation. Updates information
    /// about the specified endpoint. For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
    /// endpoints</a>.
    /// </summary>
    public partial class UpdateEndpointRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property DesiredDataAccessRoleArn. 
        /// <para>
        /// Data access role ARN to use in case the new model is encrypted with a customer CMK.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DesiredDataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DesiredDataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDesiredDataAccessRoleArn() => this.DesiredDataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DesiredInferenceUnits. 
        /// <para>
        ///  The desired number of inference units to be used by the model using this endpoint.
        /// Each inference unit represents of a throughput of 100 characters per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? DesiredInferenceUnits { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInferenceUnits property is set.
        /// </summary>
        internal bool IsSetDesiredInferenceUnits() => this.DesiredInferenceUnits.HasValue;

        /// <summary>
        /// Gets and sets the property DesiredModelArn. 
        /// <para>
        /// The ARN of the new model to use when updating an existing endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DesiredModelArn { get; set; }

        /// <summary>
        /// Checks to see if the DesiredModelArn property is set.
        /// </summary>
        internal bool IsSetDesiredModelArn() => this.DesiredModelArn != null;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the endpoint being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;
    }
}

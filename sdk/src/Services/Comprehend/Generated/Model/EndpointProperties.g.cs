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
    /// Specifies information about the specified endpoint. For information about endpoints,
    /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
    /// endpoints</a>.
    /// </summary>
    public partial class EndpointProperties
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation date and time of the endpoint.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentInferenceUnits. 
        /// <para>
        /// The number of inference units currently used by the model using this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? CurrentInferenceUnits { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInferenceUnits property is set.
        /// </summary>
        internal bool IsSetCurrentInferenceUnits() => this.CurrentInferenceUnits.HasValue;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend read
        /// access to trained custom models encrypted with a customer managed key (ModelKmsKeyId).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DesiredDataAccessRoleArn. 
        /// <para>
        /// Data access role ARN to use in case the new model is encrypted with a customer KMS
        /// key.
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
        /// The desired number of inference units to be used by the model using this endpoint.
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
        /// ARN of the new model to use for updating an existing endpoint. This ARN is going to
        /// be different from the model ARN when the update is in progress
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
        /// The Amazon Resource Number (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
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

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the endpoint was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies a reason for failure in cases of <c>Failed</c> status.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model to which the endpoint is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the endpoint. Because the endpoint updates and creation are
        /// asynchronous, so customers will need to wait for the endpoint to be <c>Ready</c> status
        /// before making inference requests.
        /// </para>
        /// </summary>
        public EndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

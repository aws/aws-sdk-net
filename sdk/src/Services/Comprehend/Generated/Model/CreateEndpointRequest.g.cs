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
    /// Container for the parameters to the CreateEndpoint operation. Creates a model-specific
    /// endpoint for synchronous inference for a previously trained custom model For information
    /// about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
    /// endpoints</a>.
    /// </summary>
    public partial class CreateEndpointRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// An idempotency token provided by the customer. If this token matches a previous endpoint
        /// creation request, Amazon Comprehend will not return a <c>ResourceInUseException</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

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
        /// Gets and sets the property DesiredInferenceUnits. 
        /// <para>
        ///  The desired number of inference units to be used by the model using this endpoint.
        /// Each inference unit represents of a throughput of 100 characters per second.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? DesiredInferenceUnits { get; set; }

        /// <summary>
        /// Checks to see if the DesiredInferenceUnits property is set.
        /// </summary>
        internal bool IsSetDesiredInferenceUnits() => this.DesiredInferenceUnits.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// This is the descriptive suffix that becomes part of the <c>EndpointArn</c> used for
        /// all subsequent requests to this resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 40)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel to which the endpoint will be attached.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the model to which the endpoint will be attached.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the endpoint. A tag is a key-value pair that adds metadata
        /// to the endpoint. For example, a tag with "Sales" as the key might be added to an endpoint
        /// to indicate its use by the sales department. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

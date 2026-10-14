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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the PutExternalModel operation. Creates or updates
    /// an Amazon SageMaker model endpoint. You can also use this action to update the configuration
    /// of the model endpoint, including the IAM role and/or the mapped variables.
    /// </summary>
    public partial class PutExternalModelRequest : AmazonFraudDetectorRequest
    {
        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The model endpoint input configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelInputConfiguration InputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputConfiguration property is set.
        /// </summary>
        internal bool IsSetInputConfiguration() => this.InputConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvokeModelEndpointRoleArn. 
        /// <para>
        /// The IAM role used to invoke the model endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvokeModelEndpointRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InvokeModelEndpointRoleArn property is set.
        /// </summary>
        internal bool IsSetInvokeModelEndpointRoleArn() => this.InvokeModelEndpointRoleArn != null;

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        /// The model endpoints name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ModelEndpoint property is set.
        /// </summary>
        internal bool IsSetModelEndpoint() => this.ModelEndpoint != null;

        /// <summary>
        /// Gets and sets the property ModelEndpointStatus. 
        /// <para>
        /// The model endpoint’s status in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelEndpointStatus ModelEndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelEndpointStatus property is set.
        /// </summary>
        internal bool IsSetModelEndpointStatus() => this.ModelEndpointStatus != null;

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The source of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelSource ModelSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelSource property is set.
        /// </summary>
        internal bool IsSetModelSource() => this.ModelSource != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The model endpoint output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of key and value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

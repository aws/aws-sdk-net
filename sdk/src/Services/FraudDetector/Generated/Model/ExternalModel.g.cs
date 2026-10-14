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
    /// The Amazon SageMaker model.
    /// </summary>
    public partial class ExternalModel
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The model ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// Timestamp of when the model was last created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property InputConfiguration. 
        /// <para>
        /// The input configuration.
        /// </para>
        /// </summary>
        public ModelInputConfiguration InputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputConfiguration property is set.
        /// </summary>
        internal bool IsSetInputConfiguration() => this.InputConfiguration != null;

        /// <summary>
        /// Gets and sets the property InvokeModelEndpointRoleArn. 
        /// <para>
        /// The role used to invoke the model. 
        /// </para>
        /// </summary>
        public string InvokeModelEndpointRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InvokeModelEndpointRoleArn property is set.
        /// </summary>
        internal bool IsSetInvokeModelEndpointRoleArn() => this.InvokeModelEndpointRoleArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Timestamp of when the model was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 30)]
        public string LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime != null;

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        /// The Amazon SageMaker model endpoints.
        /// </para>
        /// </summary>
        public string ModelEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ModelEndpoint property is set.
        /// </summary>
        internal bool IsSetModelEndpoint() => this.ModelEndpoint != null;

        /// <summary>
        /// Gets and sets the property ModelEndpointStatus. 
        /// <para>
        /// The Amazon Fraud Detector status for the external model endpoint
        /// </para>
        /// </summary>
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
        public ModelSource ModelSource { get; set; }

        /// <summary>
        /// Checks to see if the ModelSource property is set.
        /// </summary>
        internal bool IsSetModelSource() => this.ModelSource != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The output configuration.
        /// </para>
        /// </summary>
        public ModelOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;
    }
}

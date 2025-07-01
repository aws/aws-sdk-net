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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides configuration information for the dockerized container where the model algorithm
    /// is stored.
    /// </summary>
    public partial class ContainerConfig
    {
        private List<string> _arguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entrypoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _imageUri;
        private List<MetricDefinition> _metricDefinitions = AWSConfigs.InitializeCollections ? new List<MetricDefinition>() : null;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The arguments for a container used to run a training job. See How Amazon SageMaker
        /// Runs Your Training Image for additional information. For more information, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-training-algo-dockerfile.html">How
        /// Sagemaker runs your training image</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && (this._arguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Entrypoint. 
        /// <para>
        /// The entrypoint script for a Docker container used to run a training job. This script
        /// takes precedence over the default train processing instructions. See How Amazon SageMaker
        /// Runs Your Training Image for additional information. For more information, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-training-algo-dockerfile.html">How
        /// Sagemaker runs your training image</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Entrypoint
        {
            get { return this._entrypoint; }
            set { this._entrypoint = value; }
        }

        // Check to see if Entrypoint property is set
        internal bool IsSetEntrypoint()
        {
            return this._entrypoint != null && (this._entrypoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The registry path of the docker image that contains the algorithm. Clean Rooms ML
        /// currently only supports the <c>registry/repository[:tag]</c> image path format. For
        /// more information about using images in Clean Rooms ML, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AlgorithmSpecification.html#sagemaker-Type-AlgorithmSpecification-TrainingImage">Sagemaker
        /// API reference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

        /// <summary>
        /// Gets and sets the property MetricDefinitions. 
        /// <para>
        /// A list of metric definition objects. Each object specifies the metric name and regular
        /// expressions used to parse algorithm logs. Amazon Web Services Clean Rooms ML publishes
        /// each metric to all members' Amazon CloudWatch using IAM role configured in <a>PutMLConfiguration</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<MetricDefinition> MetricDefinitions
        {
            get { return this._metricDefinitions; }
            set { this._metricDefinitions = value; }
        }

        // Check to see if MetricDefinitions property is set
        internal bool IsSetMetricDefinitions()
        {
            return this._metricDefinitions != null && (this._metricDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container image configuration object for the monitoring job.
    /// </summary>
    public partial class ModelQualityAppSpecification
    {
        private List<string> _containerArguments = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _containerEntrypoint = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _imageUri;
        private string _postAnalyticsProcessorSourceUri;
        private MonitoringProblemType _problemType;
        private string _recordPreprocessorSourceUri;

        /// <summary>
        /// Gets and sets the property ContainerArguments. 
        /// <para>
        /// An array of arguments for the container used to run the monitoring job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ContainerArguments
        {
            get { return this._containerArguments; }
            set { this._containerArguments = value; }
        }

        // Check to see if ContainerArguments property is set
        internal bool IsSetContainerArguments()
        {
            return this._containerArguments != null && (this._containerArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerEntrypoint. 
        /// <para>
        /// Specifies the entrypoint for a container that the monitoring job runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ContainerEntrypoint
        {
            get { return this._containerEntrypoint; }
            set { this._containerEntrypoint = value; }
        }

        // Check to see if ContainerEntrypoint property is set
        internal bool IsSetContainerEntrypoint()
        {
            return this._containerEntrypoint != null && (this._containerEntrypoint.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Sets the environment variables in the container that the monitoring job runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The address of the container image that the monitoring job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
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
        /// Gets and sets the property PostAnalyticsProcessorSourceUri. 
        /// <para>
        /// An Amazon S3 URI to a script that is called after analysis has been performed. Applicable
        /// only for the built-in (first party) containers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PostAnalyticsProcessorSourceUri
        {
            get { return this._postAnalyticsProcessorSourceUri; }
            set { this._postAnalyticsProcessorSourceUri = value; }
        }

        // Check to see if PostAnalyticsProcessorSourceUri property is set
        internal bool IsSetPostAnalyticsProcessorSourceUri()
        {
            return this._postAnalyticsProcessorSourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// The machine learning problem type of the model that the monitoring job monitors.
        /// </para>
        /// </summary>
        public MonitoringProblemType ProblemType
        {
            get { return this._problemType; }
            set { this._problemType = value; }
        }

        // Check to see if ProblemType property is set
        internal bool IsSetProblemType()
        {
            return this._problemType != null;
        }

        /// <summary>
        /// Gets and sets the property RecordPreprocessorSourceUri. 
        /// <para>
        /// An Amazon S3 URI to a script that is called per row prior to running analysis. It
        /// can base64 decode the payload and convert it into a flattened JSON so that the built-in
        /// container can use the converted data. Applicable only for the built-in (first party)
        /// containers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string RecordPreprocessorSourceUri
        {
            get { return this._recordPreprocessorSourceUri; }
            set { this._recordPreprocessorSourceUri = value; }
        }

        // Check to see if RecordPreprocessorSourceUri property is set
        internal bool IsSetRecordPreprocessorSourceUri()
        {
            return this._recordPreprocessorSourceUri != null;
        }

    }
}
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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about the container that a data quality monitoring job runs.
    /// </summary>
    public partial class DataQualityAppSpecification
    {
        /// <summary>
        /// Gets and sets the property ContainerArguments. 
        /// <para>
        /// The arguments to send to the container that the monitoring job runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> ContainerArguments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContainerArguments property is set.
        /// </summary>
        internal bool IsSetContainerArguments() => this.ContainerArguments != null && (this.ContainerArguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContainerEntrypoint. 
        /// <para>
        /// The entrypoint for a container used to run a monitoring job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> ContainerEntrypoint { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContainerEntrypoint property is set.
        /// </summary>
        internal bool IsSetContainerEntrypoint() => this.ContainerEntrypoint != null && (this.ContainerEntrypoint.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Sets the environment variables in the container that the monitoring job runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The container image that the data quality monitoring job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string ImageUri { get; set; }

        /// <summary>
        /// Checks to see if the ImageUri property is set.
        /// </summary>
        internal bool IsSetImageUri() => this.ImageUri != null;

        /// <summary>
        /// Gets and sets the property PostAnalyticsProcessorSourceUri. 
        /// <para>
        /// An Amazon S3 URI to a script that is called after analysis has been performed. Applicable
        /// only for the built-in (first party) containers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PostAnalyticsProcessorSourceUri { get; set; }

        /// <summary>
        /// Checks to see if the PostAnalyticsProcessorSourceUri property is set.
        /// </summary>
        internal bool IsSetPostAnalyticsProcessorSourceUri() => this.PostAnalyticsProcessorSourceUri != null;

        /// <summary>
        /// Gets and sets the property RecordPreprocessorSourceUri. 
        /// <para>
        /// An Amazon S3 URI to a script that is called per row prior to running analysis. It
        /// can base64 decode the payload and convert it into a flattened JSON so that the built-in
        /// container can use the converted data. Applicable only for the built-in (first party)
        /// containers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecordPreprocessorSourceUri { get; set; }

        /// <summary>
        /// Checks to see if the RecordPreprocessorSourceUri property is set.
        /// </summary>
        internal bool IsSetRecordPreprocessorSourceUri() => this.RecordPreprocessorSourceUri != null;
    }
}

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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the StartNotebookRun operation. Starts a notebook
    /// run in Amazon SageMaker Unified Studio. A notebook run represents the execution of
    /// an <a href="https://docs.aws.amazon.com/sagemaker-unified-studio/latest/userguide/notebooks.html">Amazon
    /// SageMaker notebook</a> within a project. You can configure compute, network, timeout,
    /// and environment settings for the run.
    /// </summary>
    public partial class StartNotebookRunRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the notebook run, including instance type and environment
        /// version.
        /// </para>
        /// </summary>
        public ComputeConfig ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain in which the notebook
        /// run is started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the notebook run, specified as key-value pairs. You can specify up
        /// to 50 entries, with keys up to 128 characters and values up to 1024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the notebook run, including network access type and
        /// optional VPC settings.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property NotebookIdentifier. 
        /// <para>
        /// The identifier of the notebook to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NotebookIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NotebookIdentifier property is set.
        /// </summary>
        internal bool IsSetNotebookIdentifier() => this.NotebookIdentifier != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the project that owns the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The sensitive parameters for the notebook run, specified as key-value pairs. You can
        /// specify up to 50 entries, with keys up to 128 characters and values up to 1024 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// The identifier of the schedule associated with the notebook run.
        /// </para>
        /// </summary>
        public string ScheduleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleIdentifier property is set.
        /// </summary>
        internal bool IsSetScheduleIdentifier() => this.ScheduleIdentifier != null;

        /// <summary>
        /// Gets and sets the property TimeoutConfiguration. 
        /// <para>
        /// The timeout configuration for the notebook run. The default timeout is 720 minutes
        /// (12 hours) and the maximum is 1440 minutes (24 hours).
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfiguration property is set.
        /// </summary>
        internal bool IsSetTimeoutConfiguration() => this.TimeoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property TriggerSource. 
        /// <para>
        /// The source that triggered the notebook run.
        /// </para>
        /// </summary>
        public TriggerSource TriggerSource { get; set; }

        /// <summary>
        /// Checks to see if the TriggerSource property is set.
        /// </summary>
        internal bool IsSetTriggerSource() => this.TriggerSource != null;
    }
}

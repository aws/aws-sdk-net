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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFlow operation. Enables your application
    /// to create a new flow using Amazon AppFlow. You must create a connector profile before
    /// calling this API. Please note that the Request Syntax below shows syntax for multiple
    /// destinations, however, you can only transfer data to one item in this list at a time.
    /// Amazon AppFlow does not currently support flows to multiple destinations at once.
    /// </summary>
    public partial class CreateFlowRequest : AmazonAppflowRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The <c>clientToken</c> parameter is an idempotency token. It ensures that your <c>CreateFlow</c>
        /// request completes only once. You choose the value to pass. For example, if you don't
        /// receive a response from your request, you can safely retry the request with the same
        /// <c>clientToken</c> parameter value.
        /// </para>
        ///  
        /// <para>
        /// If you omit a <c>clientToken</c> value, the Amazon Web Services SDK that you are using
        /// inserts a value for you. This way, the SDK can safely retry requests multiple times
        /// after a network error. You must provide your own value for other use cases.
        /// </para>
        ///  
        /// <para>
        /// If you specify input parameters that differ from your first request, an error occurs.
        /// If you use a different value for <c>clientToken</c>, Amazon AppFlow considers it a
        /// new call to <c>CreateFlow</c>. The token is active for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow you want to create. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationFlowConfigList. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow places data in the destination
        /// connector. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DestinationFlowConfig> DestinationFlowConfigList { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationFlowConfig>() : null;

        /// <summary>
        /// Checks to see if the DestinationFlowConfigList property is set.
        /// </summary>
        internal bool IsSetDestinationFlowConfigList() => this.DestinationFlowConfigList != null && (this.DestinationFlowConfigList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        ///  The specified name of the flow. Spaces are not allowed. Use underscores (_) or hyphens
        /// (-) only. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        ///  The ARN (Amazon Resource Name) of the Key Management Service (KMS) key you provide
        /// for encryption. This is required if you do not want to use the Amazon AppFlow-managed
        /// KMS key. If you don't provide anything here, Amazon AppFlow uses the Amazon AppFlow-managed
        /// KMS key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsArn property is set.
        /// </summary>
        internal bool IsSetKmsArn() => this.KmsArn != null;

        /// <summary>
        /// Gets and sets the property MetadataCatalogConfig. 
        /// <para>
        /// Specifies the configuration that Amazon AppFlow uses when it catalogs the data that's
        /// transferred by the associated flow. When Amazon AppFlow catalogs the data from a flow,
        /// it stores metadata in a data catalog.
        /// </para>
        /// </summary>
        public MetadataCatalogConfig MetadataCatalogConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetadataCatalogConfig property is set.
        /// </summary>
        internal bool IsSetMetadataCatalogConfig() => this.MetadataCatalogConfig != null;

        /// <summary>
        /// Gets and sets the property SourceFlowConfig. 
        /// <para>
        ///  The configuration that controls how Amazon AppFlow retrieves data from the source
        /// connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFlowConfig SourceFlowConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFlowConfig property is set.
        /// </summary>
        internal bool IsSetSourceFlowConfig() => this.SourceFlowConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags used to organize, track, or control access for your flow. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        ///  A list of tasks that Amazon AppFlow performs while transferring the data in the flow
        /// run. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Task> Tasks { get; set; } = AWSConfigs.InitializeCollections ? new List<Task>() : null;

        /// <summary>
        /// Checks to see if the Tasks property is set.
        /// </summary>
        internal bool IsSetTasks() => this.Tasks != null && (this.Tasks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggerConfig. 
        /// <para>
        ///  The trigger settings that determine how and when the flow runs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerConfig TriggerConfig { get; set; }

        /// <summary>
        /// Checks to see if the TriggerConfig property is set.
        /// </summary>
        internal bool IsSetTriggerConfig() => this.TriggerConfig != null;
    }
}

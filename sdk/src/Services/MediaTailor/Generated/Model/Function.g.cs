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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Defines reusable logic that MediaTailor executes at lifecycle hooks during ad insertion.
    /// The <c>FunctionType</c> determines the function's runtime behavior. For more information
    /// about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
    /// with functions</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class Function
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the function.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsServiceRequestConfiguration. 
        /// <para>
        /// The configuration for an <c>AWS_SERVICE_REQUEST</c> function. Specifies the target
        /// service, target Region, and request parameters.
        /// </para>
        /// </summary>
        public AwsServiceRequestConfiguration AwsServiceRequestConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AwsServiceRequestConfiguration property is set.
        /// </summary>
        internal bool IsSetAwsServiceRequestConfiguration() => this.AwsServiceRequestConfiguration != null;

        /// <summary>
        /// Gets and sets the property ConcurrentExecutorConfiguration. 
        /// <para>
        /// The configuration for a <c>CONCURRENT_EXECUTOR</c> function.
        /// </para>
        /// </summary>
        public ConcurrentExecutorConfiguration ConcurrentExecutorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentExecutorConfiguration property is set.
        /// </summary>
        internal bool IsSetConcurrentExecutorConfiguration() => this.ConcurrentExecutorConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomOutputConfiguration. 
        /// <para>
        /// The configuration for a <c>CUSTOM_OUTPUT</c> function.
        /// </para>
        /// </summary>
        public CustomOutputConfiguration CustomOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomOutputConfiguration() => this.CustomOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the function.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FunctionId { get; set; }

        /// <summary>
        /// Checks to see if the FunctionId property is set.
        /// </summary>
        internal bool IsSetFunctionId() => this.FunctionId != null;

        /// <summary>
        /// Gets and sets the property FunctionType. 
        /// <para>
        /// The type of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionType FunctionType { get; set; }

        /// <summary>
        /// Checks to see if the FunctionType property is set.
        /// </summary>
        internal bool IsSetFunctionType() => this.FunctionType != null;

        /// <summary>
        /// Gets and sets the property HttpRequestConfiguration. 
        /// <para>
        /// The configuration for an <c>HTTP_REQUEST</c> function.
        /// </para>
        /// </summary>
        public HttpRequestConfiguration HttpRequestConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HttpRequestConfiguration property is set.
        /// </summary>
        internal bool IsSetHttpRequestConfiguration() => this.HttpRequestConfiguration != null;

        /// <summary>
        /// Gets and sets the property SequentialExecutorConfiguration. 
        /// <para>
        /// The configuration for a <c>SEQUENTIAL_EXECUTOR</c> function.
        /// </para>
        /// </summary>
        public SequentialExecutorConfiguration SequentialExecutorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SequentialExecutorConfiguration property is set.
        /// </summary>
        internal bool IsSetSequentialExecutorConfiguration() => this.SequentialExecutorConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the function. Tags are key-value pairs that you can associate
        /// with Amazon resources to help with organization, access control, and cost tracking.
        /// For more information, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/tagging.html">Tagging
        /// AWS Elemental MediaTailor Resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VastRequestConfiguration. 
        /// <para>
        /// The configuration for a <c>VAST_REQUEST</c> function.
        /// </para>
        /// </summary>
        public VastRequestConfiguration VastRequestConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VastRequestConfiguration property is set.
        /// </summary>
        internal bool IsSetVastRequestConfiguration() => this.VastRequestConfiguration != null;
    }
}

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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// This is the response object from the GetFunction operation.
    /// </summary>
    public partial class GetFunctionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ContextTypes. 
        /// <para>
        /// The kinds of media context that this function uses. Elemental Inference derives this
        /// field from the media paths that the request expression references; you can't set it.
        /// An empty list means that the expression references no media, so Elemental Inference
        /// supplies none at run time. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> ContextTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContextTypes property is set.
        /// </summary>
        internal bool IsSetContextTypes() => this.ContextTypes != null && (this.ContextTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBridgeDelivery. 
        /// <para>
        /// Indicates whether Elemental Inference also sends this function's results to Amazon
        /// EventBridge. With ENABLED, each result that is a JSON object with a top-level <c>eventBridge</c>
        /// field set to <c>true</c> is also sent as a Function Metadata Generated event to the
        /// default event bus in your account. 
        /// </para>
        /// </summary>
        public EventBridgeDeliveryMode EventBridgeDelivery { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeDelivery property is set.
        /// </summary>
        internal bool IsSetEventBridgeDelivery() => this.EventBridgeDelivery != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// The IDs of the feeds that have a function output, enabled or disabled, that references
        /// this function. While this list isn't empty, the function can't be deleted, and its
        /// name and target can't be changed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> References { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the References property is set.
        /// </summary>
        internal bool IsSetReferences() => this.References != null && (this.References.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestExpression. 
        /// <para>
        /// The JSONata expression that builds the request. Elemental Inference evaluates it against
        /// the media object of the feed, which holds the media and metadata that the function
        /// asked for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 5120)]
        public string RequestExpression { get; set; }

        /// <summary>
        /// Checks to see if the RequestExpression property is set.
        /// </summary>
        internal bool IsSetRequestExpression() => this.RequestExpression != null;

        /// <summary>
        /// Gets and sets the property ResponseExpression. 
        /// <para>
        /// The JSONata expression that selects what to store. Elemental Inference evaluates it
        /// against the result as its root: the model response for a Bedrock target, or the output
        /// of the request expression for a passthrough target. If a function has no response
        /// expression, Elemental Inference stores the entire result. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 5120)]
        public string ResponseExpression { get; set; }

        /// <summary>
        /// Checks to see if the ResponseExpression property is set.
        /// </summary>
        internal bool IsSetResponseExpression() => this.ResponseExpression != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the function.
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The destination for the request that the function builds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}

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
    /// Container for the parameters to the CreateFunction operation. Creates a function.
    /// A function analyzes a feed by building a request from the feed's media and metadata,
    /// optionally sending that request to an Amazon Bedrock model in your account, and publishing
    /// the result to the feed's metadata timeline. <para> A function runs only after you
    /// attach it to a feed as a function output. For more information, see <a href="https://docs.aws.amazon.com/elemental-inference/latest/userguide/functions.html">Using
    /// functions</a> in the <i>AWS Elemental Inference User Guide</i>. </para>
    /// </summary>
    public partial class CreateFunctionRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the function. Maximum length: 1,024 characters.
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
        /// Specifies whether Elemental Inference also sends this function's results to Amazon
        /// EventBridge. Elemental Inference sends a result only when the result is a JSON object
        /// with a top-level <c>eventBridge</c> field set to <c>true</c>. It sends the result,
        /// unchanged, as a Function Metadata Generated event to the default event bus in your
        /// account, after the result is available from GetMetadata. If the result is larger than
        /// 64 KB, the event has <c>resultOmitted</c> set to <c>true</c> in place of the result.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ENABLED – Elemental Inference sends each marked result as an event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLED (default) – Elemental Inference doesn't send events.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a Bedrock target, ENABLED requires a response expression, because the model response
        /// itself never has a top-level <c>eventBridge</c> field. A feed output that runs a function
        /// with ENABLED can't use a fixedInterval trigger shorter than 4 seconds. 
        /// </para>
        /// </summary>
        public EventBridgeDeliveryMode EventBridgeDelivery { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeDelivery property is set.
        /// </summary>
        internal bool IsSetEventBridgeDelivery() => this.EventBridgeDelivery != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for this function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestExpression. 
        /// <para>
        /// The JSONata expression that builds the request. Elemental Inference evaluates it against
        /// the media object of the feed, which holds the media and metadata that the function
        /// asked for. Maximum length: 5,120 characters. 
        /// </para>
        ///  
        /// <para>
        /// When you save the function, Elemental Inference evaluates the expression against sample
        /// media and rejects it if the evaluation fails. For a Bedrock target, the result must
        /// be a JSON object; Elemental Inference doesn't check that the object is a valid request
        /// body for the model. The expression can reference at most one of media.transcript,
        /// media.contextual, and media.clip. For a passthrough target, it can't reference media.frames.
        /// 
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
        /// expression, Elemental Inference stores the entire result. Maximum length: 5,120 characters.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you save the function, Elemental Inference checks that the expression is valid
        /// JSONata. For a passthrough target, it also evaluates the request and response expressions
        /// together against sample media, and rejects them if they produce no value. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 5120)]
        public string ResponseExpression { get; set; }

        /// <summary>
        /// Checks to see if the ResponseExpression property is set.
        /// </summary>
        internal bool IsSetResponseExpression() => this.ResponseExpression != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with this function.
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

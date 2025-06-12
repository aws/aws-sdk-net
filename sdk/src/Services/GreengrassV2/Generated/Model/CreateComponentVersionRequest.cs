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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComponentVersion operation.
    /// Creates a component. Components are software that run on Greengrass core devices.
    /// After you develop and test a component on your core device, you can use this operation
    /// to upload your component to IoT Greengrass. Then, you can deploy the component to
    /// other core devices.
    /// 
    ///  
    /// <para>
    /// You can use this operation to do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Create components from recipes</b> 
    /// </para>
    ///  
    /// <para>
    /// Create a component from a recipe, which is a file that defines the component's metadata,
    /// parameters, dependencies, lifecycle, artifacts, and platform capability. For more
    /// information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/component-recipe-reference.html">IoT
    /// Greengrass component recipe reference</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create a component from a recipe, specify <c>inlineRecipe</c> when you call this
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Create components from Lambda functions</b> 
    /// </para>
    ///  
    /// <para>
    /// Create a component from an Lambda function that runs on IoT Greengrass. This creates
    /// a recipe and artifacts from the Lambda function's deployment package. You can use
    /// this operation to migrate Lambda functions from IoT Greengrass V1 to IoT Greengrass
    /// V2.
    /// </para>
    ///  
    /// <para>
    /// This function accepts Lambda functions in all supported versions of Python, Node.js,
    /// and Java runtimes. IoT Greengrass doesn't apply any additional restrictions on deprecated
    /// Lambda runtime versions.
    /// </para>
    ///  
    /// <para>
    /// To create a component from a Lambda function, specify <c>lambdaFunction</c> when you
    /// call this operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// IoT Greengrass currently supports Lambda functions on only Linux core devices.
    /// </para>
    ///  </note> </li> </ul>
    /// </summary>
    public partial class CreateComponentVersionRequest : AmazonGreengrassV2Request
    {
        private string _clientToken;
        private MemoryStream _inlineRecipe;
        private LambdaFunctionRecipeSource _lambdaFunction;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you can provide to ensure that the request
        /// is idempotent. Idempotency means that the request is successfully processed only once,
        /// even if you send the request multiple times. When a request succeeds, and you specify
        /// the same client token for subsequent successful requests, the IoT Greengrass V2 service
        /// returns the successful response that it caches from the previous request. IoT Greengrass
        /// V2 caches successful responses for idempotent requests for up to 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InlineRecipe. 
        /// <para>
        /// The recipe to use to create the component. The recipe defines the component's metadata,
        /// parameters, dependencies, lifecycle, artifacts, and platform compatibility.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>inlineRecipe</c> or <c>lambdaFunction</c>.
        /// </para>
        /// </summary>
        public MemoryStream InlineRecipe
        {
            get { return this._inlineRecipe; }
            set { this._inlineRecipe = value; }
        }

        // Check to see if InlineRecipe property is set
        internal bool IsSetInlineRecipe()
        {
            return this._inlineRecipe != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// The parameters to create a component from a Lambda function.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <c>inlineRecipe</c> or <c>lambdaFunction</c>.
        /// </para>
        /// </summary>
        public LambdaFunctionRecipeSource LambdaFunction
        {
            get { return this._lambdaFunction; }
            set { this._lambdaFunction = value; }
        }

        // Check to see if LambdaFunction property is set
        internal bool IsSetLambdaFunction()
        {
            return this._lambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/tag-resources.html">Tag
        /// your resources</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComponentVersion operation.
    /// Creates a component. Components are software that run on AWS IoT Greengrass core devices.
    /// After you develop and test a component on your core device, you can use this operation
    /// to upload your component to AWS IoT Greengrass. Then, you can deploy the component
    /// to other core devices.
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
    /// information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/component-recipe-reference.html">AWS
    /// IoT Greengrass component recipe reference</a> in the <i>AWS IoT Greengrass V2 Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create a component from a recipe, specify <code>inlineRecipe</code> when you call
    /// this operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Create components from Lambda functions</b> 
    /// </para>
    ///  
    /// <para>
    /// Create a component from an AWS Lambda function that runs on AWS IoT Greengrass. This
    /// creates a recipe and artifacts from the Lambda function's deployment package. You
    /// can use this operation to migrate Lambda functions from AWS IoT Greengrass V1 to AWS
    /// IoT Greengrass V2.
    /// </para>
    ///  
    /// <para>
    /// This function only accepts Lambda functions that use the following runtimes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Python 2.7 – <code>python2.7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Python 3.7 – <code>python3.7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Python 3.8 – <code>python3.8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Java 8 – <code>java8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Node.js 10 – <code>nodejs10.x</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Node.js 12 – <code>nodejs12.x</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create a component from a Lambda function, specify <code>lambdaFunction</code>
    /// when you call this operation.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateComponentVersionRequest : AmazonGreengrassV2Request
    {
        private MemoryStream _inlineRecipe;
        private LambdaFunctionRecipeSource _lambdaFunction;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property InlineRecipe. 
        /// <para>
        /// The recipe to use to create the component. The recipe defines the component's metadata,
        /// parameters, dependencies, lifecycle, artifacts, and platform compatibility.
        /// </para>
        ///  
        /// <para>
        /// You must specify either <code>inlineRecipe</code> or <code>lambdaFunction</code>.
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
        /// You must specify either <code>inlineRecipe</code> or <code>lambdaFunction</code>.
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
        /// see <a href="https://docs.aws.amazon.com/greengrass/v2/tag-resources.html">Tag your
        /// resources</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
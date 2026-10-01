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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about an Lambda function to import to create a component.
    /// </summary>
    public partial class LambdaFunctionRecipeSource
    {
        /// <summary>
        /// Gets and sets the property ComponentDependencies. 
        /// <para>
        /// The component versions on which this Lambda function component depends.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComponentDependencyRequirement> ComponentDependencies { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComponentDependencyRequirement>() : null;

        /// <summary>
        /// Checks to see if the ComponentDependencies property is set.
        /// </summary>
        internal bool IsSetComponentDependencies() => this.ComponentDependencies != null && (this.ComponentDependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComponentLambdaParameters. 
        /// <para>
        /// The system and runtime parameters for the Lambda function as it runs on the Greengrass
        /// core device.
        /// </para>
        /// </summary>
        public LambdaExecutionParameters ComponentLambdaParameters { get; set; }

        /// <summary>
        /// Checks to see if the ComponentLambdaParameters property is set.
        /// </summary>
        internal bool IsSetComponentLambdaParameters() => this.ComponentLambdaParameters != null;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        ///  
        /// <para>
        /// Defaults to the name of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property ComponentPlatforms. 
        /// <para>
        /// The platforms that the component version supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComponentPlatform> ComponentPlatforms { get; set; } = AWSConfigs.InitializeCollections ? new List<ComponentPlatform>() : null;

        /// <summary>
        /// Checks to see if the ComponentPlatforms property is set.
        /// </summary>
        internal bool IsSetComponentPlatforms() => this.ComponentPlatforms != null && (this.ComponentPlatforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        ///  
        /// <para>
        /// Defaults to the version of the Lambda function as a semantic version. For example,
        /// if your function version is <c>3</c>, the component version becomes <c>3.0.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// Checks to see if the ComponentVersion property is set.
        /// </summary>
        internal bool IsSetComponentVersion() => this.ComponentVersion != null;

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the Lambda function. The ARN must include the version of the function to import.
        /// You can't use version aliases like <c>$LATEST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string LambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the LambdaArn property is set.
        /// </summary>
        internal bool IsSetLambdaArn() => this.LambdaArn != null;
    }
}

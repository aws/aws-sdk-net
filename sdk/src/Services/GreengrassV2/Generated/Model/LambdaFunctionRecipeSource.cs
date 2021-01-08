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
    /// Contains information about an AWS Lambda function to import to create a component.
    /// </summary>
    public partial class LambdaFunctionRecipeSource
    {
        private Dictionary<string, ComponentDependencyRequirement> _componentDependencies = new Dictionary<string, ComponentDependencyRequirement>();
        private LambdaExecutionParameters _componentLambdaParameters;
        private string _componentName;
        private List<ComponentPlatform> _componentPlatforms = new List<ComponentPlatform>();
        private string _componentVersion;
        private string _lambdaArn;

        /// <summary>
        /// Gets and sets the property ComponentDependencies. 
        /// <para>
        /// The component versions on which this Lambda function component depends.
        /// </para>
        /// </summary>
        public Dictionary<string, ComponentDependencyRequirement> ComponentDependencies
        {
            get { return this._componentDependencies; }
            set { this._componentDependencies = value; }
        }

        // Check to see if ComponentDependencies property is set
        internal bool IsSetComponentDependencies()
        {
            return this._componentDependencies != null && this._componentDependencies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComponentLambdaParameters. 
        /// <para>
        /// The system and runtime parameters for the Lambda function as it runs on the AWS IoT
        /// Greengrass core device.
        /// </para>
        /// </summary>
        public LambdaExecutionParameters ComponentLambdaParameters
        {
            get { return this._componentLambdaParameters; }
            set { this._componentLambdaParameters = value; }
        }

        // Check to see if ComponentLambdaParameters property is set
        internal bool IsSetComponentLambdaParameters()
        {
            return this._componentLambdaParameters != null;
        }

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
        [AWSProperty(Min=1, Max=128)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentPlatforms. 
        /// <para>
        /// The platforms that the component version supports.
        /// </para>
        /// </summary>
        public List<ComponentPlatform> ComponentPlatforms
        {
            get { return this._componentPlatforms; }
            set { this._componentPlatforms = value; }
        }

        // Check to see if ComponentPlatforms property is set
        internal bool IsSetComponentPlatforms()
        {
            return this._componentPlatforms != null && this._componentPlatforms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComponentVersion. 
        /// <para>
        /// The version of the component.
        /// </para>
        ///  
        /// <para>
        /// Defaults to the version of the Lambda function as a semantic version. For example,
        /// if your function version is <code>3</code>, the component version becomes <code>3.0.0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ComponentVersion
        {
            get { return this._componentVersion; }
            set { this._componentVersion = value; }
        }

        // Check to see if ComponentVersion property is set
        internal bool IsSetComponentVersion()
        {
            return this._componentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the Lambda function. The ARN must include the version of the function to import.
        /// You can't use version aliases like <code>$LATEST</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LambdaArn
        {
            get { return this._lambdaArn; }
            set { this._lambdaArn = value; }
        }

        // Check to see if LambdaArn property is set
        internal bool IsSetLambdaArn()
        {
            return this._lambdaArn != null;
        }

    }
}
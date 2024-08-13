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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a Lambda function specified in a deployment.
    /// </summary>
    public partial class LambdaFunctionInfo
    {
        private string _currentVersion;
        private string _functionAlias;
        private string _functionName;
        private string _targetVersion;
        private double? _targetVersionWeight;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        ///  The version of a Lambda function that production traffic points to. 
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionAlias. 
        /// <para>
        ///  The alias of a Lambda function. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/aliases-intro.html">Lambda
        /// Function Aliases</a> in the <i>Lambda Developer Guide</i>.
        /// </para>
        /// </summary>
        public string FunctionAlias
        {
            get { return this._functionAlias; }
            set { this._functionAlias = value; }
        }

        // Check to see if FunctionAlias property is set
        internal bool IsSetFunctionAlias()
        {
            return this._functionAlias != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        ///  The name of a Lambda function. 
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        ///  The version of a Lambda function that production traffic points to after the Lambda
        /// function is deployed. 
        /// </para>
        /// </summary>
        public string TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVersionWeight. 
        /// <para>
        ///  The percentage of production traffic that the target version of a Lambda function
        /// receives. 
        /// </para>
        /// </summary>
        public double? TargetVersionWeight
        {
            get { return this._targetVersionWeight; }
            set { this._targetVersionWeight = value; }
        }

        // Check to see if TargetVersionWeight property is set
        internal bool IsSetTargetVersionWeight()
        {
            return this._targetVersionWeight.HasValue; 
        }

    }
}
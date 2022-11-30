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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Any dependencies related to hub content, such as scripts, model artifacts, datasets,
    /// or notebooks.
    /// </summary>
    public partial class HubContentDependency
    {
        private string _dependencyCopyPath;
        private string _dependencyOriginPath;

        /// <summary>
        /// Gets and sets the property DependencyCopyPath. 
        /// <para>
        /// The hub content dependency copy path.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1023)]
        public string DependencyCopyPath
        {
            get { return this._dependencyCopyPath; }
            set { this._dependencyCopyPath = value; }
        }

        // Check to see if DependencyCopyPath property is set
        internal bool IsSetDependencyCopyPath()
        {
            return this._dependencyCopyPath != null;
        }

        /// <summary>
        /// Gets and sets the property DependencyOriginPath. 
        /// <para>
        /// The hub content dependency origin path.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1023)]
        public string DependencyOriginPath
        {
            get { return this._dependencyOriginPath; }
            set { this._dependencyOriginPath = value; }
        }

        // Check to see if DependencyOriginPath property is set
        internal bool IsSetDependencyOriginPath()
        {
            return this._dependencyOriginPath != null;
        }

    }
}
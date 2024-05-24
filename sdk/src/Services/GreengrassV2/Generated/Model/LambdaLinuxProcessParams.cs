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
    /// Contains parameters for a Linux process that contains an Lambda function.
    /// </summary>
    public partial class LambdaLinuxProcessParams
    {
        private LambdaContainerParams _containerParams;
        private LambdaIsolationMode _isolationMode;

        /// <summary>
        /// Gets and sets the property ContainerParams. 
        /// <para>
        /// The parameters for the container in which the Lambda function runs.
        /// </para>
        /// </summary>
        public LambdaContainerParams ContainerParams
        {
            get { return this._containerParams; }
            set { this._containerParams = value; }
        }

        // Check to see if ContainerParams property is set
        internal bool IsSetContainerParams()
        {
            return this._containerParams != null;
        }

        /// <summary>
        /// Gets and sets the property IsolationMode. 
        /// <para>
        /// The isolation mode for the process that contains the Lambda function. The process
        /// can run in an isolated runtime environment inside the IoT Greengrass container, or
        /// as a regular process outside any container.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>GreengrassContainer</c> 
        /// </para>
        /// </summary>
        public LambdaIsolationMode IsolationMode
        {
            get { return this._isolationMode; }
            set { this._isolationMode = value; }
        }

        // Check to see if IsolationMode property is set
        internal bool IsSetIsolationMode()
        {
            return this._isolationMode != null;
        }

    }
}
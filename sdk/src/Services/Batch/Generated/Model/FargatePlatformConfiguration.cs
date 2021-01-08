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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The platform configuration for jobs running on Fargate resources. Jobs running on
    /// EC2 resources must not specify this parameter.
    /// </summary>
    public partial class FargatePlatformConfiguration
    {
        private string _platformVersion;

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The AWS Fargate platform version on which the jobs are running. A platform version
        /// is specified only for jobs running on Fargate resources. If one isn't specified, the
        /// <code>LATEST</code> platform version is used by default. This will use a recent, approved
        /// version of the AWS Fargate platform for compute resources. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">AWS
        /// Fargate platform versions</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

    }
}
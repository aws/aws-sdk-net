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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about the configuration of a deployment.
    /// </summary>
    public partial class EdgeDeploymentConfig
    {
        private FailureHandlingPolicy _failureHandlingPolicy;

        /// <summary>
        /// Gets and sets the property FailureHandlingPolicy. 
        /// <para>
        /// Toggle that determines whether to rollback to previous configuration if the current
        /// deployment fails. By default this is turned on. You may turn this off if you want
        /// to investigate the errors yourself.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FailureHandlingPolicy FailureHandlingPolicy
        {
            get { return this._failureHandlingPolicy; }
            set { this._failureHandlingPolicy = value; }
        }

        // Check to see if FailureHandlingPolicy property is set
        internal bool IsSetFailureHandlingPolicy()
        {
            return this._failureHandlingPolicy != null;
        }

    }
}
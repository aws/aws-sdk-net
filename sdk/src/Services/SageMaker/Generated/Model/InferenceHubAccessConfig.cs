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
    /// Configuration information specifying which hub contents have accessible deployment
    /// options.
    /// </summary>
    public partial class InferenceHubAccessConfig
    {
        private string _hubContentArn;

        /// <summary>
        /// Gets and sets the property HubContentArn. 
        /// <para>
        /// The ARN of the hub content for which deployment access is allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string HubContentArn
        {
            get { return this._hubContentArn; }
            set { this._hubContentArn = value; }
        }

        // Check to see if HubContentArn property is set
        internal bool IsSetHubContentArn()
        {
            return this._hubContentArn != null;
        }

    }
}
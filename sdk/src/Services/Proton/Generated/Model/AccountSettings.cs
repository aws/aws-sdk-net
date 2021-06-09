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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// The AWS Proton pipeline service role data.
    /// </summary>
    public partial class AccountSettings
    {
        private string _pipelineServiceRoleArn;

        /// <summary>
        /// Gets and sets the property PipelineServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Proton pipeline service role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string PipelineServiceRoleArn
        {
            get { return this._pipelineServiceRoleArn; }
            set { this._pipelineServiceRoleArn = value; }
        }

        // Check to see if PipelineServiceRoleArn property is set
        internal bool IsSetPipelineServiceRoleArn()
        {
            return this._pipelineServiceRoleArn != null;
        }

    }
}
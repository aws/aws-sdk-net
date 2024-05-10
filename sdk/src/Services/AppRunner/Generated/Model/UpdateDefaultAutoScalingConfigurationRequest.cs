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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDefaultAutoScalingConfiguration operation.
    /// Update an auto scaling configuration to be the default. The existing default auto
    /// scaling configuration will be set to non-default automatically.
    /// </summary>
    public partial class UpdateDefaultAutoScalingConfigurationRequest : AmazonAppRunnerRequest
    {
        private string _autoScalingConfigurationArn;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner auto scaling configuration that you
        /// want to set as the default.
        /// </para>
        ///  
        /// <para>
        /// The ARN can be a full auto scaling configuration ARN, or a partial ARN ending with
        /// either <c>.../<i>name</i> </c> or <c>.../<i>name</i>/<i>revision</i> </c>. If a revision
        /// isn't specified, the latest active revision is set as the default.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AutoScalingConfigurationArn
        {
            get { return this._autoScalingConfigurationArn; }
            set { this._autoScalingConfigurationArn = value; }
        }

        // Check to see if AutoScalingConfigurationArn property is set
        internal bool IsSetAutoScalingConfigurationArn()
        {
            return this._autoScalingConfigurationArn != null;
        }

    }
}
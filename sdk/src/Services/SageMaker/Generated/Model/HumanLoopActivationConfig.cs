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
    /// Provides information about how and under what conditions SageMaker creates a human
    /// loop. If <c>HumanLoopActivationConfig</c> is not given, then all requests go to humans.
    /// </summary>
    public partial class HumanLoopActivationConfig
    {
        private HumanLoopActivationConditionsConfig _humanLoopActivationConditionsConfig;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationConditionsConfig. 
        /// <para>
        /// Container structure for defining under what conditions SageMaker creates a human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HumanLoopActivationConditionsConfig HumanLoopActivationConditionsConfig
        {
            get { return this._humanLoopActivationConditionsConfig; }
            set { this._humanLoopActivationConditionsConfig = value; }
        }

        // Check to see if HumanLoopActivationConditionsConfig property is set
        internal bool IsSetHumanLoopActivationConditionsConfig()
        {
            return this._humanLoopActivationConditionsConfig != null;
        }

    }
}
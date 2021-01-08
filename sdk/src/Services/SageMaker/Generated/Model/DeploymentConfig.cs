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
    /// Currently, the <code>DeploymentConfig</code> API is not supported.
    /// </summary>
    public partial class DeploymentConfig
    {
        private AutoRollbackConfig _autoRollbackConfiguration;
        private BlueGreenUpdatePolicy _blueGreenUpdatePolicy;

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration.
        /// </summary>
        public AutoRollbackConfig AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BlueGreenUpdatePolicy.
        /// </summary>
        [AWSProperty(Required=true)]
        public BlueGreenUpdatePolicy BlueGreenUpdatePolicy
        {
            get { return this._blueGreenUpdatePolicy; }
            set { this._blueGreenUpdatePolicy = value; }
        }

        // Check to see if BlueGreenUpdatePolicy property is set
        internal bool IsSetBlueGreenUpdatePolicy()
        {
            return this._blueGreenUpdatePolicy != null;
        }

    }
}
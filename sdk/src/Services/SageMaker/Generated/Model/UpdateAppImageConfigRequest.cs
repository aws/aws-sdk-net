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
    /// Container for the parameters to the UpdateAppImageConfig operation.
    /// Updates the properties of an AppImageConfig.
    /// </summary>
    public partial class UpdateAppImageConfigRequest : AmazonSageMakerRequest
    {
        private string _appImageConfigName;
        private KernelGatewayImageConfig _kernelGatewayImageConfig;

        /// <summary>
        /// Gets and sets the property AppImageConfigName. 
        /// <para>
        /// The name of the AppImageConfig to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string AppImageConfigName
        {
            get { return this._appImageConfigName; }
            set { this._appImageConfigName = value; }
        }

        // Check to see if AppImageConfigName property is set
        internal bool IsSetAppImageConfigName()
        {
            return this._appImageConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property KernelGatewayImageConfig. 
        /// <para>
        /// The new KernelGateway app to run on the image.
        /// </para>
        /// </summary>
        public KernelGatewayImageConfig KernelGatewayImageConfig
        {
            get { return this._kernelGatewayImageConfig; }
            set { this._kernelGatewayImageConfig = value; }
        }

        // Check to see if KernelGatewayImageConfig property is set
        internal bool IsSetKernelGatewayImageConfig()
        {
            return this._kernelGatewayImageConfig != null;
        }

    }
}
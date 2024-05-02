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
    /// Configuration information for the infrastructure health check of a training job. A
    /// SageMaker-provided health check tests the health of instance hardware and cluster
    /// network connectivity.
    /// </summary>
    public partial class InfraCheckConfig
    {
        private bool? _enableInfraCheck;

        /// <summary>
        /// Gets and sets the property EnableInfraCheck. 
        /// <para>
        /// Enables an infrastructure health check.
        /// </para>
        /// </summary>
        public bool? EnableInfraCheck
        {
            get { return this._enableInfraCheck; }
            set { this._enableInfraCheck = value; }
        }

        // Check to see if EnableInfraCheck property is set
        internal bool IsSetEnableInfraCheck()
        {
            return this._enableInfraCheck.HasValue; 
        }

    }
}
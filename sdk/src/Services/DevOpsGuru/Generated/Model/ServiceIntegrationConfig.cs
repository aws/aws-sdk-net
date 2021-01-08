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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the integration of DevOps Guru with another AWS service, such as
    /// AWS Systems Manager.
    /// </summary>
    public partial class ServiceIntegrationConfig
    {
        private OpsCenterIntegration _opsCenter;

        /// <summary>
        /// Gets and sets the property OpsCenter. 
        /// <para>
        ///  Information about whether DevOps Guru is configured to create an OpsItem in AWS Systems
        /// Manager OpsCenter for each created insight. 
        /// </para>
        /// </summary>
        public OpsCenterIntegration OpsCenter
        {
            get { return this._opsCenter; }
            set { this._opsCenter = value; }
        }

        // Check to see if OpsCenter property is set
        internal bool IsSetOpsCenter()
        {
            return this._opsCenter != null;
        }

    }
}
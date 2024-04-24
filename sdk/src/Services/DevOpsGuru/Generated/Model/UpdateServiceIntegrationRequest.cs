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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServiceIntegration operation.
    /// Enables or disables integration with a service that can be integrated with DevOps
    /// Guru. The one service that can be integrated with DevOps Guru is Amazon Web Services
    /// Systems Manager, which can be used to create an OpsItem for each generated insight.
    /// </summary>
    public partial class UpdateServiceIntegrationRequest : AmazonDevOpsGuruRequest
    {
        private UpdateServiceIntegrationConfig _serviceIntegration;

        /// <summary>
        /// Gets and sets the property ServiceIntegration. 
        /// <para>
        ///  An <c>IntegratedServiceConfig</c> object used to specify the integrated service you
        /// want to update, and whether you want to update it to enabled or disabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateServiceIntegrationConfig ServiceIntegration
        {
            get { return this._serviceIntegration; }
            set { this._serviceIntegration = value; }
        }

        // Check to see if ServiceIntegration property is set
        internal bool IsSetServiceIntegration()
        {
            return this._serviceIntegration != null;
        }

    }
}
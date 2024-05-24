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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePackageConfiguration operation.
    /// Updates the software package configuration.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdatePackageConfiguration</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">iam:PassRole</a>
    /// actions.
    /// </para>
    /// </summary>
    public partial class UpdatePackageConfigurationRequest : AmazonIoTRequest
    {
        private string _clientToken;
        private VersionUpdateByJobsConfig _versionUpdateByJobsConfig;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property VersionUpdateByJobsConfig. 
        /// <para>
        /// Configuration to manage job's package version reporting. This updates the thing's
        /// reserved named shadow that the job targets.
        /// </para>
        /// </summary>
        public VersionUpdateByJobsConfig VersionUpdateByJobsConfig
        {
            get { return this._versionUpdateByJobsConfig; }
            set { this._versionUpdateByJobsConfig = value; }
        }

        // Check to see if VersionUpdateByJobsConfig property is set
        internal bool IsSetVersionUpdateByJobsConfig()
        {
            return this._versionUpdateByJobsConfig != null;
        }

    }
}
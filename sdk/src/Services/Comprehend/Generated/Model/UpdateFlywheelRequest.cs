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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlywheel operation.
    /// Update the configuration information for an existing flywheel.
    /// </summary>
    public partial class UpdateFlywheelRequest : AmazonComprehendRequest
    {
        private string _activeModelArn;
        private string _dataAccessRoleArn;
        private UpdateDataSecurityConfig _dataSecurityConfig;
        private string _flywheelArn;

        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ActiveModelArn
        {
            get { return this._activeModelArn; }
            set { this._activeModelArn = value; }
        }

        // Check to see if ActiveModelArn property is set
        internal bool IsSetActiveModelArn()
        {
            return this._activeModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend permission to access the flywheel data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSecurityConfig. 
        /// <para>
        /// Flywheel data security configuration.
        /// </para>
        /// </summary>
        public UpdateDataSecurityConfig DataSecurityConfig
        {
            get { return this._dataSecurityConfig; }
            set { this._dataSecurityConfig = value; }
        }

        // Check to see if DataSecurityConfig property is set
        internal bool IsSetDataSecurityConfig()
        {
            return this._dataSecurityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlywheelArn
        {
            get { return this._flywheelArn; }
            set { this._flywheelArn = value; }
        }

        // Check to see if FlywheelArn property is set
        internal bool IsSetFlywheelArn()
        {
            return this._flywheelArn != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlywheel operation. Update the configuration
    /// information for an existing flywheel.
    /// </summary>
    public partial class UpdateFlywheelRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ActiveModelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ActiveModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ActiveModelArn property is set.
        /// </summary>
        internal bool IsSetActiveModelArn() => this.ActiveModelArn != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend permission
        /// to access the flywheel data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DataSecurityConfig. 
        /// <para>
        /// Flywheel data security configuration.
        /// </para>
        /// </summary>
        public UpdateDataSecurityConfig DataSecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataSecurityConfig property is set.
        /// </summary>
        internal bool IsSetDataSecurityConfig() => this.DataSecurityConfig != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;
    }
}

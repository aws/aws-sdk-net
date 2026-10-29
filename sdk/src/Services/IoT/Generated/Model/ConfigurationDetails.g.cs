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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The encryption configuration details that include the status information of the Key
    /// Management Service (KMS) key and the KMS access role.
    /// </summary>
    public partial class ConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property ConfigurationStatus. 
        /// <para>
        /// The health status of KMS key and KMS access role. If either KMS key or KMS access
        /// role is <c>UNHEALTHY</c>, the return value will be <c>UNHEALTHY</c>. To use a customer
        /// managed KMS key, the value of <c>configurationStatus</c> must be <c>HEALTHY</c>. 
        /// </para>
        /// </summary>
        public ConfigurationStatus ConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationStatus() => this.ConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that indicates either the KMS key or the KMS access role is <c>UNHEALTHY</c>.
        /// Valid values: <c>KMS_KEY_VALIDATION_ERROR</c> and <c>ROLE_VALIDATION_ERROR</c>. 
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The detailed error message that corresponds to the <c>errorCode</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}

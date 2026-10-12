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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about registering an Identity and Access Management (IAM) resource so
    /// Amazon Web Services IoT FleetWise edge agent software can transfer your vehicle data
    /// to Amazon Timestream.
    /// </summary>
    public partial class IamRegistrationResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A message associated with a registration error.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The status of registering your IAM resource. The status can be one of <c>REGISTRATION_SUCCESS</c>,
        /// <c>REGISTRATION_PENDING</c>, <c>REGISTRATION_FAILURE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationStatus RegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationStatus property is set.
        /// </summary>
        internal bool IsSetRegistrationStatus() => this.RegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}

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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the PutEmailMonitoringConfiguration operation. Creates
    /// or updates the email monitoring configuration for a specified organization.
    /// </summary>
    public partial class PutEmailMonitoringConfigurationRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CloudWatch Log group associated with the email
        /// monitoring configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 47, Max = 562)]
        public string LogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupArn property is set.
        /// </summary>
        internal bool IsSetLogGroupArn() => this.LogGroupArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization for which the email monitoring configuration is set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Role associated with the email monitoring
        /// configuration. If absent, the IAM Role Arn of AWSServiceRoleForAmazonWorkMailEvents
        /// will be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}

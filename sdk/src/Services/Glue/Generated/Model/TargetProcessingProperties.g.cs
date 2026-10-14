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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The resource properties associated with the integration target.
    /// </summary>
    public partial class TargetProcessingProperties
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The Glue network connection to configure the Glue job running in the customer VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The ARN of an Eventbridge event bus to receive the integration status notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        /// The ARN of the KMS key used for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsArn property is set.
        /// </summary>
        internal bool IsSetKmsArn() => this.KmsArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role to access the Glue database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}

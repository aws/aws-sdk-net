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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about an update to a custom model deployment, including the new custom model
    /// resource ARN and current update status.
    /// </summary>
    public partial class CustomModelDeploymentUpdateDetails
    {
        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        ///  ARN of the new custom model being deployed as part of the update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        ///  Current status of the deployment update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomModelDeploymentUpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}

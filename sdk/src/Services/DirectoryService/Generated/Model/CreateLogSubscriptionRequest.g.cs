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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLogSubscription operation. Creates a subscription
    /// to forward real-time Directory Service domain controller security logs to the specified
    /// Amazon CloudWatch log group in your Amazon Web Services account.
    /// </summary>
    public partial class CreateLogSubscriptionRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the directory to which you want to subscribe and receive real-time logs
        /// to your specified CloudWatch log group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group where the real-time domain controller logs are
        /// forwarded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;
    }
}

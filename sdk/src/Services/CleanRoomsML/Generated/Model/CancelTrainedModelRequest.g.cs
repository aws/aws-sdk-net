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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the CancelTrainedModel operation. Submits a request
    /// to cancel the trained model job.
    /// </summary>
    public partial class CancelTrainedModelRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the trained model job that you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model job that you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelArn() => this.TrainedModelArn != null;

        /// <summary>
        /// Gets and sets the property VersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model to cancel. This parameter allows you to
        /// specify which version of the trained model you want to cancel when multiple versions
        /// exist.
        /// </para>
        ///  
        /// <para>
        /// If <c>versionIdentifier</c> is not specified, the base model will be cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string VersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VersionIdentifier property is set.
        /// </summary>
        internal bool IsSetVersionIdentifier() => this.VersionIdentifier != null;
    }
}

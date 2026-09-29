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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateVPCConnection operation.
    /// </summary>
    public partial class UpdateVPCConnectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC connection.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityStatus. 
        /// <para>
        /// The availability status of the VPC connection.
        /// </para>
        /// </summary>
        public VPCConnectionAvailabilityStatus AvailabilityStatus { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityStatus property is set.
        /// </summary>
        internal bool IsSetAvailabilityStatus() => this.AvailabilityStatus != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The update status of the VPC connection's last update.
        /// </para>
        /// </summary>
        public VPCConnectionResourceStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;

        /// <summary>
        /// Gets and sets the property VPCConnectionId. 
        /// <para>
        /// The ID of the VPC connection that you are updating. This ID is a unique identifier
        /// for each Amazon Web Services Region in anAmazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string VPCConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VPCConnectionId property is set.
        /// </summary>
        internal bool IsSetVPCConnectionId() => this.VPCConnectionId != null;
    }
}

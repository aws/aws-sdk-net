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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes an error associated with a peering request.
    /// </summary>
    public partial class PeeringError
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code for the peering request.
        /// </para>
        /// </summary>
        public PeeringErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with the error <c>code</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MissingPermissionsContext. 
        /// <para>
        /// Provides additional information about missing permissions for the peering error.
        /// </para>
        /// </summary>
        public PermissionsErrorContext MissingPermissionsContext { get; set; }

        /// <summary>
        /// Checks to see if the MissingPermissionsContext property is set.
        /// </summary>
        internal bool IsSetMissingPermissionsContext() => this.MissingPermissionsContext != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the Peering request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the requested peering resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}

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

namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// A permit request from an AWS support operator.
    /// </summary>
    public partial class SupportPermitRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition requested by the operator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permit Permit { get; set; }

        /// <summary>
        /// Checks to see if the Permit property is set.
        /// </summary>
        internal bool IsSetPermit() => this.Permit != null;

        /// <summary>
        /// Gets and sets the property RequestArn. 
        /// <para>
        /// The ARN of the permit request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RequestArn { get; set; }

        /// <summary>
        /// Checks to see if the RequestArn property is set.
        /// </summary>
        internal bool IsSetRequestArn() => this.RequestArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the permit request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SupportPermitRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SupportCaseDisplayId. 
        /// <para>
        /// The display identifier of the support case associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SupportCaseDisplayId { get; set; }

        /// <summary>
        /// Checks to see if the SupportCaseDisplayId property is set.
        /// </summary>
        internal bool IsSetSupportCaseDisplayId() => this.SupportCaseDisplayId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the request was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}

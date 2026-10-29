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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetEffectiveHoursOfOperations operation. Get the
    /// hours of operations with the effective override applied.
    /// </summary>
    public partial class GetEffectiveHoursOfOperationsRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property FromDate. 
        /// <para>
        /// The date from when the hours of operation are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FromDate { get; set; }

        /// <summary>
        /// Checks to see if the FromDate property is set.
        /// </summary>
        internal bool IsSetFromDate() => this.FromDate != null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ToDate. 
        /// <para>
        /// The date until when the hours of operation are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ToDate { get; set; }

        /// <summary>
        /// Checks to see if the ToDate property is set.
        /// </summary>
        internal bool IsSetToDate() => this.ToDate != null;
    }
}

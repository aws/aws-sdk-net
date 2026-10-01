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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the provisioned throughput for the table or for a global secondary
    /// index.
    /// </summary>
    public partial class AwsDynamoDbTableProvisionedThroughput
    {
        /// <summary>
        /// Gets and sets the property LastDecreaseDateTime. 
        /// <para>
        /// Indicates when the provisioned throughput was last decreased.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastDecreaseDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastDecreaseDateTime property is set.
        /// </summary>
        internal bool IsSetLastDecreaseDateTime() => this.LastDecreaseDateTime != null;

        /// <summary>
        /// Gets and sets the property LastIncreaseDateTime. 
        /// <para>
        /// Indicates when the provisioned throughput was last increased.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastIncreaseDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastIncreaseDateTime property is set.
        /// </summary>
        internal bool IsSetLastIncreaseDateTime() => this.LastIncreaseDateTime != null;

        /// <summary>
        /// Gets and sets the property NumberOfDecreasesToday. 
        /// <para>
        /// The number of times during the current UTC calendar day that the provisioned throughput
        /// was decreased.
        /// </para>
        /// </summary>
        public int? NumberOfDecreasesToday { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDecreasesToday property is set.
        /// </summary>
        internal bool IsSetNumberOfDecreasesToday() => this.NumberOfDecreasesToday.HasValue;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The maximum number of strongly consistent reads consumed per second before DynamoDB
        /// returns a <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        public int? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        public int? WriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the WriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetWriteCapacityUnits() => this.WriteCapacityUnits.HasValue;
    }
}

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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes integration options for Amazon Athena.
    /// </summary>
    public partial class AthenaIntegration
    {
        /// <summary>
        /// Gets and sets the property IntegrationResultS3DestinationArn. 
        /// <para>
        /// The location in Amazon S3 to store the generated CloudFormation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationResultS3DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationResultS3DestinationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationResultS3DestinationArn() => this.IntegrationResultS3DestinationArn != null;

        /// <summary>
        /// Gets and sets the property PartitionEndDate. 
        /// <para>
        /// The end date for the partition.
        /// </para>
        /// </summary>
        public DateTime? PartitionEndDate { get; set; }

        /// <summary>
        /// Checks to see if the PartitionEndDate property is set.
        /// </summary>
        internal bool IsSetPartitionEndDate() => this.PartitionEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionLoadFrequency. 
        /// <para>
        /// The schedule for adding new partitions to the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PartitionLoadFrequency PartitionLoadFrequency { get; set; }

        /// <summary>
        /// Checks to see if the PartitionLoadFrequency property is set.
        /// </summary>
        internal bool IsSetPartitionLoadFrequency() => this.PartitionLoadFrequency != null;

        /// <summary>
        /// Gets and sets the property PartitionStartDate. 
        /// <para>
        /// The start date for the partition.
        /// </para>
        /// </summary>
        public DateTime? PartitionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the PartitionStartDate property is set.
        /// </summary>
        internal bool IsSetPartitionStartDate() => this.PartitionStartDate.HasValue;
    }
}

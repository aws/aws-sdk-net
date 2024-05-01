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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _integrationResultS3DestinationArn;
        private DateTime? _partitionEndDate;
        private PartitionLoadFrequency _partitionLoadFrequency;
        private DateTime? _partitionStartDate;

        /// <summary>
        /// Gets and sets the property IntegrationResultS3DestinationArn. 
        /// <para>
        /// The location in Amazon S3 to store the generated CloudFormation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationResultS3DestinationArn
        {
            get { return this._integrationResultS3DestinationArn; }
            set { this._integrationResultS3DestinationArn = value; }
        }

        // Check to see if IntegrationResultS3DestinationArn property is set
        internal bool IsSetIntegrationResultS3DestinationArn()
        {
            return this._integrationResultS3DestinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionEndDate. 
        /// <para>
        /// The end date for the partition.
        /// </para>
        /// </summary>
        public DateTime? PartitionEndDate
        {
            get { return this._partitionEndDate; }
            set { this._partitionEndDate = value; }
        }

        // Check to see if PartitionEndDate property is set
        internal bool IsSetPartitionEndDate()
        {
            return this._partitionEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionLoadFrequency. 
        /// <para>
        /// The schedule for adding new partitions to the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartitionLoadFrequency PartitionLoadFrequency
        {
            get { return this._partitionLoadFrequency; }
            set { this._partitionLoadFrequency = value; }
        }

        // Check to see if PartitionLoadFrequency property is set
        internal bool IsSetPartitionLoadFrequency()
        {
            return this._partitionLoadFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionStartDate. 
        /// <para>
        /// The start date for the partition.
        /// </para>
        /// </summary>
        public DateTime? PartitionStartDate
        {
            get { return this._partitionStartDate; }
            set { this._partitionStartDate = value; }
        }

        // Check to see if PartitionStartDate property is set
        internal bool IsSetPartitionStartDate()
        {
            return this._partitionStartDate.HasValue; 
        }

    }
}
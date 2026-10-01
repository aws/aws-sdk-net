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
    /// Container for the parameters to the CreateIngestion operation. Creates and starts
    /// a new SPICE ingestion for a dataset. You can manually refresh datasets in an Enterprise
    /// edition account 32 times in a 24-hour period. You can manually refresh datasets in
    /// a Standard edition account 8 times in a 24-hour period. Each 24-hour period is measured
    /// starting 24 hours before the current date and time. <para> Any ingestions operating
    /// on tagged datasets inherit the same tags automatically for use in access control.
    /// For an example, see <a href="http://aws.amazon.com/premiumsupport/knowledge-center/iam-ec2-resource-tags/">How
    /// do I create an IAM policy to control access to Amazon EC2 resources using tags?</a>
    /// in the Amazon Web Services Knowledge Center. Tags are visible on the tagged dataset,
    /// but not on the ingestion resource. </para>
    /// </summary>
    public partial class CreateIngestionRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the dataset used in the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// An ID for the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string IngestionId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionId property is set.
        /// </summary>
        internal bool IsSetIngestionId() => this.IngestionId != null;

        /// <summary>
        /// Gets and sets the property IngestionType. 
        /// <para>
        /// The type of ingestion that you want to create.
        /// </para>
        /// </summary>
        public IngestionType IngestionType { get; set; }

        /// <summary>
        /// Checks to see if the IngestionType property is set.
        /// </summary>
        internal bool IsSetIngestionType() => this.IngestionType != null;
    }
}

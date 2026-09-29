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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the UpdateDataset operation.
    /// </summary>
    public partial class UpdateDatasetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">ARN</a>
        /// of the dataset. The format is <c>arn:${Partition}:iotsitewise:${Region}:${Account}:dataset/${DatasetId}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetStatus. 
        /// <para>
        /// The status of the dataset. This contains the state and any error messages. State is
        /// <c>UPDATING</c> after a successfull call to this API, and any associated error message.
        /// The state is <c>ACTIVE</c> when ready to use.
        /// </para>
        /// </summary>
        public DatasetStatus DatasetStatus { get; set; }

        /// <summary>
        /// Checks to see if the DatasetStatus property is set.
        /// </summary>
        internal bool IsSetDatasetStatus() => this.DatasetStatus != null;
    }
}

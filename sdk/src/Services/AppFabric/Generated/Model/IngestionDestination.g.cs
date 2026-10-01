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

namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Contains information about an ingestion destination.
    /// </summary>
    public partial class IngestionDestination
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingestion destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the ingestion destination was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// Contains information about the destination of ingested data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngestionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string IngestionArn { get; set; }

        /// <summary>
        /// Checks to see if the IngestionArn property is set.
        /// </summary>
        internal bool IsSetIngestionArn() => this.IngestionArn != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// Contains information about how ingested data is processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the ingestion destination.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c>: The ingestion destination is active and is ready to be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The ingestion destination has failed. If the ingestion destination
        /// is in this state, you should verify the ingestion destination configuration and try
        /// again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IngestionDestinationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the ingestion destination.
        /// </para>
        ///  
        /// <para>
        /// Only present when the <c>status</c> of ingestion destination is <c>Failed</c>.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the ingestion destination was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}

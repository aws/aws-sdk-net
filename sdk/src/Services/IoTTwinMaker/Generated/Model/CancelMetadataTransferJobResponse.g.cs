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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the CancelMetadataTransferJob operation.
    /// </summary>
    public partial class CancelMetadataTransferJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The metadata transfer job ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property MetadataTransferJobId. 
        /// <para>
        /// The metadata transfer job Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string MetadataTransferJobId { get; set; }

        /// <summary>
        /// Checks to see if the MetadataTransferJobId property is set.
        /// </summary>
        internal bool IsSetMetadataTransferJobId() => this.MetadataTransferJobId != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The metadata transfer job's progress.
        /// </para>
        /// </summary>
        public MetadataTransferJobProgress Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The metadata transfer job's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetadataTransferJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// Used to update the DateTime property.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;
    }
}

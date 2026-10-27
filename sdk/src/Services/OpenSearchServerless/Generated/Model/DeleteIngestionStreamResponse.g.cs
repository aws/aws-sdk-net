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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the DeleteIngestionStream operation.
    /// </summary>
    public partial class DeleteIngestionStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The unique identifier of the collection that the ingestion stream belonged to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 40)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property IngestionStreamId. 
        /// <para>
        /// The unique identifier of the deleted ingestion stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 64)]
        public string IngestionStreamId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStreamId property is set.
        /// </summary>
        internal bool IsSetIngestionStreamId() => this.IngestionStreamId != null;

        /// <summary>
        /// Gets and sets the property IngestionStreamName. 
        /// <para>
        /// The name of the deleted ingestion stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string IngestionStreamName { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStreamName property is set.
        /// </summary>
        internal bool IsSetIngestionStreamName() => this.IngestionStreamName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the ingestion stream.
        /// </para>
        /// </summary>
        public IngestionStreamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

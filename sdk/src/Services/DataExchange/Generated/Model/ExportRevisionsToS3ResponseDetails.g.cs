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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the export revisions to Amazon S3 response.
    /// </summary>
    public partial class ExportRevisionsToS3ResponseDetails
    {
        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// Encryption configuration of the export job.
        /// </para>
        /// </summary>
        public ExportServerSideEncryption Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property EventActionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event action.
        /// </para>
        /// </summary>
        public string EventActionArn { get; set; }

        /// <summary>
        /// Checks to see if the EventActionArn property is set.
        /// </summary>
        internal bool IsSetEventActionArn() => this.EventActionArn != null;

        /// <summary>
        /// Gets and sets the property RevisionDestinations. 
        /// <para>
        /// The destination in Amazon S3 where the revision is exported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RevisionDestinationEntry> RevisionDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<RevisionDestinationEntry>() : null;

        /// <summary>
        /// Checks to see if the RevisionDestinations property is set.
        /// </summary>
        internal bool IsSetRevisionDestinations() => this.RevisionDestinations != null && (this.RevisionDestinations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

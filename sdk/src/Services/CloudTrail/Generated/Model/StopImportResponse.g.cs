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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the StopImport operation.
    /// </summary>
    public partial class StopImportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp of the import's creation. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        ///  The ARN of the destination event data store. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndEventTime. 
        /// <para>
        ///  Used with <c>StartEventTime</c> to bound a <c>StartImport</c> request, and limit
        /// imported trail events to only those events logged within a specified time period.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndEventTime { get; set; }

        /// <summary>
        /// Checks to see if the EndEventTime property is set.
        /// </summary>
        internal bool IsSetEndEventTime() => this.EndEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        ///  The ID for the import. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ImportId { get; set; }

        /// <summary>
        /// Checks to see if the ImportId property is set.
        /// </summary>
        internal bool IsSetImportId() => this.ImportId != null;

        /// <summary>
        /// Gets and sets the property ImportSource. 
        /// <para>
        ///  The source S3 bucket for the import. 
        /// </para>
        /// </summary>
        public ImportSource ImportSource { get; set; }

        /// <summary>
        /// Checks to see if the ImportSource property is set.
        /// </summary>
        internal bool IsSetImportSource() => this.ImportSource != null;

        /// <summary>
        /// Gets and sets the property ImportStatistics. 
        /// <para>
        ///  Returns information on the stopped import. 
        /// </para>
        /// </summary>
        public ImportStatistics ImportStatistics { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatistics property is set.
        /// </summary>
        internal bool IsSetImportStatistics() => this.ImportStatistics != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import. 
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property StartEventTime. 
        /// <para>
        ///  Used with <c>EndEventTime</c> to bound a <c>StartImport</c> request, and limit imported
        /// trail events to only those events logged within a specified time period. 
        /// </para>
        /// </summary>
        public DateTime? StartEventTime { get; set; }

        /// <summary>
        /// Checks to see if the StartEventTime property is set.
        /// </summary>
        internal bool IsSetStartEventTime() => this.StartEventTime.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        ///  The timestamp of the import's last update. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;
    }
}

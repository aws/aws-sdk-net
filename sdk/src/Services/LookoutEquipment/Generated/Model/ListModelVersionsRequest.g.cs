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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the ListModelVersions operation. Generates a list
    /// of all model versions for a given model, including the model version, model version
    /// ARN, and status. To list a subset of versions, use the <c>MaxModelVersion</c> and
    /// <c>MinModelVersion</c> fields.
    /// </summary>
    public partial class ListModelVersionsRequest : AmazonLookoutEquipmentRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAtEndTime. 
        /// <para>
        /// Filter results to return all the model versions created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtEndTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAtEndTime property is set.
        /// </summary>
        internal bool IsSetCreatedAtEndTime() => this.CreatedAtEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAtStartTime. 
        /// <para>
        /// Filter results to return all the model versions created after this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAtStartTime property is set.
        /// </summary>
        internal bool IsSetCreatedAtStartTime() => this.CreatedAtStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxModelVersion. 
        /// <para>
        /// Specifies the highest version of the model to return in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? MaxModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the MaxModelVersion property is set.
        /// </summary>
        internal bool IsSetMaxModelVersion() => this.MaxModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of machine learning model versions to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MinModelVersion. 
        /// <para>
        /// Specifies the lowest version of the model to return in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? MinModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinModelVersion property is set.
        /// </summary>
        internal bool IsSetMinModelVersion() => this.MinModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Then name of the machine learning model for which the model versions are to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results exceeds the limit that the response can display, the
        /// response returns an opaque pagination token indicating where to continue the listing
        /// of machine learning model versions. Use this token in the <c>NextToken</c> field in
        /// the request to list the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Filter the results based on the way the model version was generated.
        /// </para>
        /// </summary>
        public ModelVersionSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter the results based on the current status of the model version.
        /// </para>
        /// </summary>
        public ModelVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}

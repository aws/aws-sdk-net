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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
    /// Container for the parameters to the ListModelVersions operation.
    /// Generates a list of all model versions for a given model, including the model version,
    /// model version ARN, and status. To list a subset of versions, use the <c>MaxModelVersion</c>
    /// and <c>MinModelVersion</c> fields.
    /// </summary>
    public partial class ListModelVersionsRequest : AmazonLookoutEquipmentRequest
    {
        private DateTime? _createdAtEndTime;
        private DateTime? _createdAtStartTime;
        private long? _maxModelVersion;
        private int? _maxResults;
        private long? _minModelVersion;
        private string _modelName;
        private string _nextToken;
        private ModelVersionSourceType _sourceType;
        private ModelVersionStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAtEndTime. 
        /// <para>
        /// Filter results to return all the model versions created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtEndTime
        {
            get { return this._createdAtEndTime; }
            set { this._createdAtEndTime = value; }
        }

        // Check to see if CreatedAtEndTime property is set
        internal bool IsSetCreatedAtEndTime()
        {
            return this._createdAtEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAtStartTime. 
        /// <para>
        /// Filter results to return all the model versions created after this time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAtStartTime
        {
            get { return this._createdAtStartTime; }
            set { this._createdAtStartTime = value; }
        }

        // Check to see if CreatedAtStartTime property is set
        internal bool IsSetCreatedAtStartTime()
        {
            return this._createdAtStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxModelVersion. 
        /// <para>
        /// Specifies the highest version of the model to return in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MaxModelVersion
        {
            get { return this._maxModelVersion; }
            set { this._maxModelVersion = value; }
        }

        // Check to see if MaxModelVersion property is set
        internal bool IsSetMaxModelVersion()
        {
            return this._maxModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of machine learning model versions to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinModelVersion. 
        /// <para>
        /// Specifies the lowest version of the model to return in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MinModelVersion
        {
            get { return this._minModelVersion; }
            set { this._minModelVersion = value; }
        }

        // Check to see if MinModelVersion property is set
        internal bool IsSetMinModelVersion()
        {
            return this._minModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Then name of the machine learning model for which the model versions are to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results exceeds the limit that the response can display, the
        /// response returns an opaque pagination token indicating where to continue the listing
        /// of machine learning model versions. Use this token in the <c>NextToken</c> field in
        /// the request to list the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Filter the results based on the way the model version was generated.
        /// </para>
        /// </summary>
        public ModelVersionSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter the results based on the current status of the model version.
        /// </para>
        /// </summary>
        public ModelVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the GetFindingV2 operation.
    /// </summary>
    public partial class GetFindingV2Response : AmazonWebServiceResponse
    {
        private DateTime? _analyzedAt;
        private DateTime? _createdAt;
        private string _error;
        private List<FindingDetails> _findingDetails = AWSConfigs.InitializeCollections ? new List<FindingDetails>() : null;
        private FindingType _findingType;
        private string _id;
        private string _nextToken;
        private string _resource;
        private string _resourceOwnerAccount;
        private ResourceType _resourceType;
        private FindingStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AnalyzedAt. 
        /// <para>
        /// The time at which the resource-based policy or IAM entity that generated the finding
        /// was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? AnalyzedAt
        {
            get { return this._analyzedAt; }
            set { this._analyzedAt = value; }
        }

        // Check to see if AnalyzedAt property is set
        internal bool IsSetAnalyzedAt()
        {
            return this._analyzedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the finding was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property FindingDetails. 
        /// <para>
        /// A localized message that explains the finding and provides guidance on how to address
        /// it.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FindingDetails> FindingDetails
        {
            get { return this._findingDetails; }
            set { this._findingDetails = value; }
        }

        // Check to see if FindingDetails property is set
        internal bool IsSetFindingDetails()
        {
            return this._findingDetails != null && (this._findingDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The type of the finding. For external access analyzers, the type is <c>ExternalAccess</c>.
        /// For unused access analyzers, the type can be <c>UnusedIAMRole</c>, <c>UnusedIAMUserAccessKey</c>,
        /// <c>UnusedIAMUserPassword</c>, or <c>UnusedPermission</c>. For internal access analyzers,
        /// the type is <c>InternalAccess</c>.
        /// </para>
        /// </summary>
        public FindingType FindingType
        {
            get { return this._findingType; }
            set { this._findingType = value; }
        }

        // Check to see if FindingType property is set
        internal bool IsSetFindingType()
        {
            return this._findingType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the finding to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination of results returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that generated the finding.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccount. 
        /// <para>
        /// Tye Amazon Web Services account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceOwnerAccount
        {
            get { return this._resourceOwnerAccount; }
            set { this._resourceOwnerAccount = value; }
        }

        // Check to see if ResourceOwnerAccount property is set
        internal bool IsSetResourceOwnerAccount()
        {
            return this._resourceOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource identified in the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the finding was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}
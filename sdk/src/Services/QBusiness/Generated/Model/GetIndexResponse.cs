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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetIndex operation.
    /// </summary>
    public partial class GetIndexResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private IndexCapacityConfiguration _capacityConfiguration;
        private DateTime? _createdAt;
        private string _description;
        private string _displayName;
        private List<DocumentAttributeConfiguration> _documentAttributeConfigurations = AWSConfigs.InitializeCollections ? new List<DocumentAttributeConfiguration>() : null;
        private ErrorDetail _error;
        private string _indexArn;
        private string _indexId;
        private IndexStatistics _indexStatistics;
        private IndexStatus _status;
        private IndexType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application associated with the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityConfiguration. 
        /// <para>
        /// The storage capacity units chosen for your Amazon Q Business index.
        /// </para>
        /// </summary>
        public IndexCapacityConfiguration CapacityConfiguration
        {
            get { return this._capacityConfiguration; }
            set { this._capacityConfiguration = value; }
        }

        // Check to see if CapacityConfiguration property is set
        internal bool IsSetCapacityConfiguration()
        {
            return this._capacityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business index was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributeConfigurations. 
        /// <para>
        /// Configuration information for document attributes or metadata. Document metadata are
        /// fields associated with your documents. For example, the company department name associated
        /// with each document. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/doc-attributes-types.html#doc-attributes">Understanding
        /// document attributes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<DocumentAttributeConfiguration> DocumentAttributeConfigurations
        {
            get { return this._documentAttributeConfigurations; }
            set { this._documentAttributeConfigurations = value; }
        }

        // Check to see if DocumentAttributeConfigurations property is set
        internal bool IsSetDocumentAttributeConfigurations()
        {
            return this._documentAttributeConfigurations != null && (this._documentAttributeConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a message that explains why.
        /// </para>
        /// </summary>
        public ErrorDetail Error
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
        /// Gets and sets the property IndexArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon Q Business index. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string IndexArn
        {
            get { return this._indexArn; }
            set { this._indexArn = value; }
        }

        // Check to see if IndexArn property is set
        internal bool IsSetIndexArn()
        {
            return this._indexArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the Amazon Q Business index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexStatistics. 
        /// <para>
        /// Provides information about the number of documents indexed.
        /// </para>
        /// </summary>
        public IndexStatistics IndexStatistics
        {
            get { return this._indexStatistics; }
            set { this._indexStatistics = value; }
        }

        // Check to see if IndexStatistics property is set
        internal bool IsSetIndexStatistics()
        {
            return this._indexStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the index. When the value is <c>ACTIVE</c>, the index is ready
        /// for use. If the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c>
        /// field contains a message that explains why.
        /// </para>
        /// </summary>
        public IndexStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of index attached to your Amazon Q Business application.
        /// </para>
        /// </summary>
        public IndexType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business index was last updated.
        /// </para>
        /// </summary>
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
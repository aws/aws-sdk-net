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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the GetApplication operation.
    /// </summary>
    public partial class GetApplicationResponse : AmazonWebServiceResponse
    {
        private List<AppConfig> _appConfigs = AWSConfigs.InitializeCollections ? new List<AppConfig>() : null;
        private string _arn;
        private DateTime? _createdAt;
        private List<DataSource> _dataSources = AWSConfigs.InitializeCollections ? new List<DataSource>() : null;
        private string _endpoint;
        private IamIdentityCenterOptions _iamIdentityCenterOptions;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private ApplicationStatus _status;

        /// <summary>
        /// Gets and sets the property AppConfigs. 
        /// <para>
        /// The configuration settings of the OpenSearch application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<AppConfig> AppConfigs
        {
            get { return this._appConfigs; }
            set { this._appConfigs = value; }
        }

        // Check to see if AppConfigs property is set
        internal bool IsSetAppConfigs()
        {
            return this._appConfigs != null && (this._appConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn.
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the OpenSearch application was created.
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
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The data sources associated with the OpenSearch application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSource> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && (this._dataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint URL of the OpenSearch application.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property IamIdentityCenterOptions. 
        /// <para>
        /// The IAM Identity Center settings configured for the OpenSearch application.
        /// </para>
        /// </summary>
        public IamIdentityCenterOptions IamIdentityCenterOptions
        {
            get { return this._iamIdentityCenterOptions; }
            set { this._iamIdentityCenterOptions = value; }
        }

        // Check to see if IamIdentityCenterOptions property is set
        internal bool IsSetIamIdentityCenterOptions()
        {
            return this._iamIdentityCenterOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the OpenSearch application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of the last update to the OpenSearch application.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the OpenSearch application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=30)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the OpenSearch application. Possible values: <c>CREATING</c>,
        /// <c>UPDATING</c>, <c>DELETING</c>, <c>FAILED</c>, <c>ACTIVE</c>, and <c>DELETED</c>.
        /// </para>
        /// </summary>
        public ApplicationStatus Status
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
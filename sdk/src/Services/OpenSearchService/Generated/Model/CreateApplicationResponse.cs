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
    /// This is the response object from the CreateApplication operation.
    /// </summary>
    public partial class CreateApplicationResponse : AmazonWebServiceResponse
    {
        private List<AppConfig> _appConfigs = AWSConfigs.InitializeCollections ? new List<AppConfig>() : null;
        private string _arn;
        private DateTime? _createdAt;
        private List<DataSource> _dataSources = AWSConfigs.InitializeCollections ? new List<DataSource>() : null;
        private IamIdentityCenterOptions _iamIdentityCenterOptions;
        private string _id;
        private string _name;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AppConfigs. 
        /// <para>
        /// Configurations of the OpenSearch Application, inlcuding admin configuration.
        /// </para>
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
        /// Timestamp when the OpenSearch Application was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// Data sources associated with the created OpenSearch Application.
        /// </para>
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
        /// Gets and sets the property IamIdentityCenterOptions. 
        /// <para>
        /// Settings of IAM Identity Center for the created OpenSearch Application.
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
        /// Unique identifier for the created OpenSearch Application.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the created OpenSearch Application.
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
        /// Gets and sets the property TagList.
        /// </summary>
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an OpenSearch UI application. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/application.html">Using
    /// the OpenSearch user interface in Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonOpenSearchServiceRequest
    {
        private List<AppConfig> _appConfigs = AWSConfigs.InitializeCollections ? new List<AppConfig>() : null;
        private string _clientToken;
        private List<DataSource> _dataSources = AWSConfigs.InitializeCollections ? new List<DataSource>() : null;
        private IamIdentityCenterOptionsInput _iamIdentityCenterOptions;
        private string _name;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AppConfigs. 
        /// <para>
        /// Configuration settings for the OpenSearch application, including administrative options.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// The data sources to link to the OpenSearch application.
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
        /// Gets and sets the property IamIdentityCenterOptions. 
        /// <para>
        /// Configuration settings for integrating Amazon Web Services IAM Identity Center with
        /// the OpenSearch application.
        /// </para>
        /// </summary>
        public IamIdentityCenterOptionsInput IamIdentityCenterOptions
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the OpenSearch application. Names must be unique within an Amazon
        /// Web Services Region for each account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=30)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
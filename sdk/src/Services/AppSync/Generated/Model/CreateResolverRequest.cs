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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResolver operation.
    /// Creates a <code>Resolver</code> object.
    /// 
    ///  
    /// <para>
    /// A resolver converts incoming requests into a format that a data source can understand
    /// and converts the data source's responses into GraphQL.
    /// </para>
    /// </summary>
    public partial class CreateResolverRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private CachingConfig _cachingConfig;
        private string _dataSourceName;
        private string _fieldName;
        private ResolverKind _kind;
        private PipelineConfig _pipelineConfig;
        private string _requestMappingTemplate;
        private string _responseMappingTemplate;
        private SyncConfig _syncConfig;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The ID for the GraphQL API for which the resolver is being created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property CachingConfig. 
        /// <para>
        /// The caching configuration for the resolver.
        /// </para>
        /// </summary>
        public CachingConfig CachingConfig
        {
            get { return this._cachingConfig; }
            set { this._cachingConfig = value; }
        }

        // Check to see if CachingConfig property is set
        internal bool IsSetCachingConfig()
        {
            return this._cachingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The name of the data source for which the resolver is being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string DataSourceName
        {
            get { return this._dataSourceName; }
            set { this._dataSourceName = value; }
        }

        // Check to see if DataSourceName property is set
        internal bool IsSetDataSourceName()
        {
            return this._dataSourceName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the field to attach the resolver to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The resolver type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>UNIT</b>: A UNIT resolver type. A UNIT resolver is the default resolver type.
        /// A UNIT resolver enables you to execute a GraphQL query against a single data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PIPELINE</b>: A PIPELINE resolver type. A PIPELINE resolver enables you to execute
        /// a series of <code>Function</code> in a serial manner. You can use a pipeline resolver
        /// to execute a GraphQL query against multiple data sources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverKind Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineConfig. 
        /// <para>
        /// The <code>PipelineConfig</code>.
        /// </para>
        /// </summary>
        public PipelineConfig PipelineConfig
        {
            get { return this._pipelineConfig; }
            set { this._pipelineConfig = value; }
        }

        // Check to see if PipelineConfig property is set
        internal bool IsSetPipelineConfig()
        {
            return this._pipelineConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RequestMappingTemplate. 
        /// <para>
        /// The mapping template to be used for requests.
        /// </para>
        ///  
        /// <para>
        /// A resolver uses a request mapping template to convert a GraphQL expression into a
        /// format that a data source can understand. Mapping templates are written in Apache
        /// Velocity Template Language (VTL).
        /// </para>
        ///  
        /// <para>
        /// VTL request mapping templates are optional when using a Lambda data source. For all
        /// other data sources, VTL request and response mapping templates are required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string RequestMappingTemplate
        {
            get { return this._requestMappingTemplate; }
            set { this._requestMappingTemplate = value; }
        }

        // Check to see if RequestMappingTemplate property is set
        internal bool IsSetRequestMappingTemplate()
        {
            return this._requestMappingTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseMappingTemplate. 
        /// <para>
        /// The mapping template to be used for responses from the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
        public string ResponseMappingTemplate
        {
            get { return this._responseMappingTemplate; }
            set { this._responseMappingTemplate = value; }
        }

        // Check to see if ResponseMappingTemplate property is set
        internal bool IsSetResponseMappingTemplate()
        {
            return this._responseMappingTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property SyncConfig. 
        /// <para>
        /// The <code>SyncConfig</code> for a resolver attached to a versioned datasource.
        /// </para>
        /// </summary>
        public SyncConfig SyncConfig
        {
            get { return this._syncConfig; }
            set { this._syncConfig = value; }
        }

        // Check to see if SyncConfig property is set
        internal bool IsSetSyncConfig()
        {
            return this._syncConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the <code>Type</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65536)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}
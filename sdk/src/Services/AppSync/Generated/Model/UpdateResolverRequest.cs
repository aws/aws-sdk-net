/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolver operation.
    /// Updates a <code>Resolver</code> object.
    /// </summary>
    public partial class UpdateResolverRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private string _dataSourceName;
        private string _fieldName;
        private ResolverKind _kind;
        private PipelineConfig _pipelineConfig;
        private string _requestMappingTemplate;
        private string _responseMappingTemplate;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The new data source name.
        /// </para>
        /// </summary>
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
        /// The new field name.
        /// </para>
        /// </summary>
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
        /// The new request mapping template.
        /// </para>
        /// </summary>
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
        /// The new response mapping template.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The new type name.
        /// </para>
        /// </summary>
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
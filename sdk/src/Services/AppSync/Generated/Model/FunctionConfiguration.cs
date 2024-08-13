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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// A function is a reusable entity. You can use multiple functions to compose the resolver
    /// logic.
    /// </summary>
    public partial class FunctionConfiguration
    {
        private string _code;
        private string _dataSourceName;
        private string _description;
        private string _functionArn;
        private string _functionId;
        private string _functionVersion;
        private int? _maxBatchSize;
        private string _name;
        private string _requestMappingTemplate;
        private string _responseMappingTemplate;
        private AppSyncRuntime _runtime;
        private SyncConfig _syncConfig;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The <c>function</c> code that contains the request and response functions. When code
        /// is used, the <c>runtime</c> is required. The <c>runtime</c> value must be <c>APPSYNC_JS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The name of the <c>DataSource</c>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The <c>Function</c> description.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>Function</c> object.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// A unique ID representing the <c>Function</c> object.
        /// </para>
        /// </summary>
        public string FunctionId
        {
            get { return this._functionId; }
            set { this._functionId = value; }
        }

        // Check to see if FunctionId property is set
        internal bool IsSetFunctionId()
        {
            return this._functionId != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// The version of the request mapping template. Currently, only the 2018-05-29 version
        /// of the template is supported.
        /// </para>
        /// </summary>
        public string FunctionVersion
        {
            get { return this._functionVersion; }
            set { this._functionVersion = value; }
        }

        // Check to see if FunctionVersion property is set
        internal bool IsSetFunctionVersion()
        {
            return this._functionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum batching size for a resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public int? MaxBatchSize
        {
            get { return this._maxBatchSize; }
            set { this._maxBatchSize = value; }
        }

        // Check to see if MaxBatchSize property is set
        internal bool IsSetMaxBatchSize()
        {
            return this._maxBatchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>Function</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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
        /// Gets and sets the property RequestMappingTemplate. 
        /// <para>
        /// The <c>Function</c> request mapping template. Functions support only the 2018-05-29
        /// version of the request mapping template.
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
        /// The <c>Function</c> response mapping template.
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
        /// Gets and sets the property Runtime.
        /// </summary>
        public AppSyncRuntime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property SyncConfig.
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

    }
}
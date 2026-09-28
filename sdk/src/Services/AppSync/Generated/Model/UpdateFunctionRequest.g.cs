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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFunction operation. Updates a <c>Function</c>
    /// object.
    /// </summary>
    public partial class UpdateFunctionRequest : AmazonAppSyncRequest
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The GraphQL API ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The <c>function</c> code that contains the request and response functions. When code
        /// is used, the <c>runtime</c> is required. The <c>runtime</c> value must be <c>APPSYNC_JS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// The <c>Function</c> <c>DataSource</c> name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceName property is set.
        /// </summary>
        internal bool IsSetDataSourceName() => this.DataSourceName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The <c>Function</c> description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The function ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string FunctionId { get; set; }

        /// <summary>
        /// Checks to see if the FunctionId property is set.
        /// </summary>
        internal bool IsSetFunctionId() => this.FunctionId != null;

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// The <c>version</c> of the request mapping template. Currently, the supported value
        /// is 2018-05-29. Note that when using VTL and mapping templates, the <c>functionVersion</c>
        /// is required.
        /// </para>
        /// </summary>
        public string FunctionVersion { get; set; }

        /// <summary>
        /// Checks to see if the FunctionVersion property is set.
        /// </summary>
        internal bool IsSetFunctionVersion() => this.FunctionVersion != null;

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum batching size for a resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSize property is set.
        /// </summary>
        internal bool IsSetMaxBatchSize() => this.MaxBatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <c>Function</c> name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RequestMappingTemplate. 
        /// <para>
        /// The <c>Function</c> request mapping template. Functions support only the 2018-05-29
        /// version of the request mapping template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string RequestMappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the RequestMappingTemplate property is set.
        /// </summary>
        internal bool IsSetRequestMappingTemplate() => this.RequestMappingTemplate != null;

        /// <summary>
        /// Gets and sets the property ResponseMappingTemplate. 
        /// <para>
        /// The <c>Function</c> request mapping template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string ResponseMappingTemplate { get; set; }

        /// <summary>
        /// Checks to see if the ResponseMappingTemplate property is set.
        /// </summary>
        internal bool IsSetResponseMappingTemplate() => this.ResponseMappingTemplate != null;

        /// <summary>
        /// Gets and sets the property Runtime.
        /// </summary>
        public AppSyncRuntime Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property SyncConfig.
        /// </summary>
        public SyncConfig SyncConfig { get; set; }

        /// <summary>
        /// Checks to see if the SyncConfig property is set.
        /// </summary>
        internal bool IsSetSyncConfig() => this.SyncConfig != null;
    }
}

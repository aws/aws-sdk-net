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
    /// This is the response object from the GetDataSourceIntrospection operation.
    /// </summary>
    public partial class GetDataSourceIntrospectionResponse : AmazonWebServiceResponse
    {
        private string _introspectionId;
        private DataSourceIntrospectionResult _introspectionResult;
        private DataSourceIntrospectionStatus _introspectionStatus;
        private string _introspectionStatusDetail;

        /// <summary>
        /// Gets and sets the property IntrospectionId. 
        /// <para>
        /// The introspection ID. Each introspection contains a unique ID that can be used to
        /// reference the instrospection record.
        /// </para>
        /// </summary>
        public string IntrospectionId
        {
            get { return this._introspectionId; }
            set { this._introspectionId = value; }
        }

        // Check to see if IntrospectionId property is set
        internal bool IsSetIntrospectionId()
        {
            return this._introspectionId != null;
        }

        /// <summary>
        /// Gets and sets the property IntrospectionResult. 
        /// <para>
        /// The <c>DataSourceIntrospectionResult</c> object data.
        /// </para>
        /// </summary>
        public DataSourceIntrospectionResult IntrospectionResult
        {
            get { return this._introspectionResult; }
            set { this._introspectionResult = value; }
        }

        // Check to see if IntrospectionResult property is set
        internal bool IsSetIntrospectionResult()
        {
            return this._introspectionResult != null;
        }

        /// <summary>
        /// Gets and sets the property IntrospectionStatus. 
        /// <para>
        /// The status of the introspection during retrieval. By default, when a new instrospection
        /// is being retrieved, the status will be set to <c>PROCESSING</c>. Once the operation
        /// has been completed, the status will change to <c>SUCCESS</c> or <c>FAILED</c> depending
        /// on how the data was parsed. A <c>FAILED</c> operation will return an error and its
        /// details as an <c>introspectionStatusDetail</c>.
        /// </para>
        /// </summary>
        public DataSourceIntrospectionStatus IntrospectionStatus
        {
            get { return this._introspectionStatus; }
            set { this._introspectionStatus = value; }
        }

        // Check to see if IntrospectionStatus property is set
        internal bool IsSetIntrospectionStatus()
        {
            return this._introspectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IntrospectionStatusDetail. 
        /// <para>
        /// The error detail field. When a <c>FAILED</c> <c>introspectionStatus</c> is returned,
        /// the <c>introspectionStatusDetail</c> will also return the exact error that was generated
        /// during the operation.
        /// </para>
        /// </summary>
        public string IntrospectionStatusDetail
        {
            get { return this._introspectionStatusDetail; }
            set { this._introspectionStatusDetail = value; }
        }

        // Check to see if IntrospectionStatusDetail property is set
        internal bool IsSetIntrospectionStatusDetail()
        {
            return this._introspectionStatusDetail != null;
        }

    }
}
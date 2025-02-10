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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information that identifies the document.
    /// </summary>
    public partial class DocumentIdentifier
    {
        private CustomDocumentIdentifier _custom;
        private ContentDataSourceType _dataSourceType;
        private S3Location _s3;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// Contains information that identifies the document in a custom data source.
        /// </para>
        /// </summary>
        public CustomDocumentIdentifier Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of data source connected to the knowledge base that contains the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContentDataSourceType DataSourceType
        {
            get { return this._dataSourceType; }
            set { this._dataSourceType = value; }
        }

        // Check to see if DataSourceType property is set
        internal bool IsSetDataSourceType()
        {
            return this._dataSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Contains information that identifies the document in an S3 data source.
        /// </para>
        /// </summary>
        public S3Location S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}
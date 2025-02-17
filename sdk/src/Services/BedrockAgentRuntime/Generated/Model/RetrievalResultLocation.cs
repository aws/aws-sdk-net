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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about the data source location.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_ResponseSyntax">Retrieve
    /// response</a> – in the <c>location</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_ResponseSyntax">RetrieveAndGenerate
    /// response</a> – in the <c>location</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> – in the <c>location</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RetrievalResultLocation
    {
        private RetrievalResultConfluenceLocation _confluenceLocation;
        private RetrievalResultCustomDocumentLocation _customDocumentLocation;
        private RetrievalResultKendraDocumentLocation _kendraDocumentLocation;
        private RetrievalResultS3Location _s3Location;
        private RetrievalResultSalesforceLocation _salesforceLocation;
        private RetrievalResultSharePointLocation _sharePointLocation;
        private RetrievalResultSqlLocation _sqlLocation;
        private RetrievalResultLocationType _type;
        private RetrievalResultWebLocation _webLocation;

        /// <summary>
        /// Gets and sets the property ConfluenceLocation. 
        /// <para>
        /// The Confluence data source location.
        /// </para>
        /// </summary>
        public RetrievalResultConfluenceLocation ConfluenceLocation
        {
            get { return this._confluenceLocation; }
            set { this._confluenceLocation = value; }
        }

        // Check to see if ConfluenceLocation property is set
        internal bool IsSetConfluenceLocation()
        {
            return this._confluenceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDocumentLocation. 
        /// <para>
        /// Specifies the location of a document in a custom data source.
        /// </para>
        /// </summary>
        public RetrievalResultCustomDocumentLocation CustomDocumentLocation
        {
            get { return this._customDocumentLocation; }
            set { this._customDocumentLocation = value; }
        }

        // Check to see if CustomDocumentLocation property is set
        internal bool IsSetCustomDocumentLocation()
        {
            return this._customDocumentLocation != null;
        }

        /// <summary>
        /// Gets and sets the property KendraDocumentLocation. 
        /// <para>
        /// The location of a document in Amazon Kendra.
        /// </para>
        /// </summary>
        public RetrievalResultKendraDocumentLocation KendraDocumentLocation
        {
            get { return this._kendraDocumentLocation; }
            set { this._kendraDocumentLocation = value; }
        }

        // Check to see if KendraDocumentLocation property is set
        internal bool IsSetKendraDocumentLocation()
        {
            return this._kendraDocumentLocation != null;
        }

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The S3 data source location.
        /// </para>
        /// </summary>
        public RetrievalResultS3Location S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

        /// <summary>
        /// Gets and sets the property SalesforceLocation. 
        /// <para>
        /// The Salesforce data source location.
        /// </para>
        /// </summary>
        public RetrievalResultSalesforceLocation SalesforceLocation
        {
            get { return this._salesforceLocation; }
            set { this._salesforceLocation = value; }
        }

        // Check to see if SalesforceLocation property is set
        internal bool IsSetSalesforceLocation()
        {
            return this._salesforceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SharePointLocation. 
        /// <para>
        /// The SharePoint data source location.
        /// </para>
        /// </summary>
        public RetrievalResultSharePointLocation SharePointLocation
        {
            get { return this._sharePointLocation; }
            set { this._sharePointLocation = value; }
        }

        // Check to see if SharePointLocation property is set
        internal bool IsSetSharePointLocation()
        {
            return this._sharePointLocation != null;
        }

        /// <summary>
        /// Gets and sets the property SqlLocation. 
        /// <para>
        /// Specifies information about the SQL query used to retrieve the result.
        /// </para>
        /// </summary>
        public RetrievalResultSqlLocation SqlLocation
        {
            get { return this._sqlLocation; }
            set { this._sqlLocation = value; }
        }

        // Check to see if SqlLocation property is set
        internal bool IsSetSqlLocation()
        {
            return this._sqlLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetrievalResultLocationType Type
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
        /// Gets and sets the property WebLocation. 
        /// <para>
        /// The web URL/URLs data source location.
        /// </para>
        /// </summary>
        public RetrievalResultWebLocation WebLocation
        {
            get { return this._webLocation; }
            set { this._webLocation = value; }
        }

        // Check to see if WebLocation property is set
        internal bool IsSetWebLocation()
        {
            return this._webLocation != null;
        }

    }
}
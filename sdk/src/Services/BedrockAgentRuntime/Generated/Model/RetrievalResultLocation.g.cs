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
        /// <summary>
        /// Gets and sets the property ConfluenceLocation. 
        /// <para>
        /// The Confluence data source location.
        /// </para>
        /// </summary>
        public RetrievalResultConfluenceLocation ConfluenceLocation { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceLocation property is set.
        /// </summary>
        internal bool IsSetConfluenceLocation() => this.ConfluenceLocation != null;

        /// <summary>
        /// Gets and sets the property CustomDocumentLocation. 
        /// <para>
        /// Specifies the location of a document in a custom data source.
        /// </para>
        /// </summary>
        public RetrievalResultCustomDocumentLocation CustomDocumentLocation { get; set; }

        /// <summary>
        /// Checks to see if the CustomDocumentLocation property is set.
        /// </summary>
        internal bool IsSetCustomDocumentLocation() => this.CustomDocumentLocation != null;

        /// <summary>
        /// Gets and sets the property GoogleDriveLocation. 
        /// <para>
        /// The Google Drive data source location.
        /// </para>
        /// </summary>
        public RetrievalResultGoogleDriveLocation GoogleDriveLocation { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDriveLocation property is set.
        /// </summary>
        internal bool IsSetGoogleDriveLocation() => this.GoogleDriveLocation != null;

        /// <summary>
        /// Gets and sets the property KendraDocumentLocation. 
        /// <para>
        /// The location of a document in Amazon Kendra.
        /// </para>
        /// </summary>
        public RetrievalResultKendraDocumentLocation KendraDocumentLocation { get; set; }

        /// <summary>
        /// Checks to see if the KendraDocumentLocation property is set.
        /// </summary>
        internal bool IsSetKendraDocumentLocation() => this.KendraDocumentLocation != null;

        /// <summary>
        /// Gets and sets the property OneDriveLocation. 
        /// <para>
        /// The Microsoft OneDrive data source location.
        /// </para>
        /// </summary>
        public RetrievalResultOneDriveLocation OneDriveLocation { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveLocation property is set.
        /// </summary>
        internal bool IsSetOneDriveLocation() => this.OneDriveLocation != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The S3 data source location.
        /// </para>
        /// </summary>
        public RetrievalResultS3Location S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property SalesforceLocation. 
        /// <para>
        /// The Salesforce data source location.
        /// </para>
        /// </summary>
        public RetrievalResultSalesforceLocation SalesforceLocation { get; set; }

        /// <summary>
        /// Checks to see if the SalesforceLocation property is set.
        /// </summary>
        internal bool IsSetSalesforceLocation() => this.SalesforceLocation != null;

        /// <summary>
        /// Gets and sets the property SharePointLocation. 
        /// <para>
        /// The SharePoint data source location.
        /// </para>
        /// </summary>
        public RetrievalResultSharePointLocation SharePointLocation { get; set; }

        /// <summary>
        /// Checks to see if the SharePointLocation property is set.
        /// </summary>
        internal bool IsSetSharePointLocation() => this.SharePointLocation != null;

        /// <summary>
        /// Gets and sets the property SqlLocation. 
        /// <para>
        /// Specifies information about the SQL query used to retrieve the result.
        /// </para>
        /// </summary>
        public RetrievalResultSqlLocation SqlLocation { get; set; }

        /// <summary>
        /// Checks to see if the SqlLocation property is set.
        /// </summary>
        internal bool IsSetSqlLocation() => this.SqlLocation != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data source location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalResultLocationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WebLocation. 
        /// <para>
        /// The web URL/URLs data source location.
        /// </para>
        /// </summary>
        public RetrievalResultWebLocation WebLocation { get; set; }

        /// <summary>
        /// Checks to see if the WebLocation property is set.
        /// </summary>
        internal bool IsSetWebLocation() => this.WebLocation != null;
    }
}

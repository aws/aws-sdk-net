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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSource operation. Creates a data source
    /// connector that you want to use with an Amazon Kendra index. <para> You specify a name,
    /// data source connector type and description for your data source. You also specify
    /// configuration information for the data source connector. </para> <para> <c>CreateDataSource</c>
    /// is a synchronous operation. The operation returns 200 if the data source was successfully
    /// created. Otherwise, an exception is raised. </para> <para> For an example of creating
    /// an index and data source using the Python SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-python.html">Getting
    /// started with Python SDK</a>. For an example of creating an index and data source using
    /// the Java SDK, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/gs-java.html">Getting
    /// started with Java SDK</a>. </para>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonKendraRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create a data source connector.
        /// Multiple calls to the <c>CreateDataSource</c> API with the same client token will
        /// create only one data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration information to connect to your data source repository.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <c>Configuration</c> parameter when the <c>Type</c> parameter
        /// is set to <c>CUSTOM</c>. If you do, you receive a <c>ValidationException</c> exception.
        /// </para>
        ///  
        /// <para>
        /// The <c>Configuration</c> parameter is required for all other data sources.
        /// </para>
        /// </summary>
        public DataSourceConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CustomDocumentEnrichmentConfiguration. 
        /// <para>
        /// Configuration information for altering document metadata and content during the document
        /// ingestion process.
        /// </para>
        ///  
        /// <para>
        /// For more information on how to create, modify and delete document metadata, or make
        /// other content alterations when you ingest documents into Amazon Kendra, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/custom-document-enrichment.html">Customizing
        /// document metadata during the ingestion process</a>.
        /// </para>
        /// </summary>
        public CustomDocumentEnrichmentConfiguration CustomDocumentEnrichmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomDocumentEnrichmentConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomDocumentEnrichmentConfiguration() => this.CustomDocumentEnrichmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index you want to use with the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The code for a language. This allows you to support a language for all documents when
        /// creating the data source connector. English is supported by default. For more information
        /// on supported languages, including their codes, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-adding-languages.html">Adding
        /// documents in languages other than English</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access the data source
        /// and required resources. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/iam-roles.html">IAM
        /// access roles for Amazon Kendra.</a>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <c>RoleArn</c> parameter when the <c>Type</c> parameter is set
        /// to <c>CUSTOM</c>. If you do, you receive a <c>ValidationException</c> exception.
        /// </para>
        ///  
        /// <para>
        /// The <c>RoleArn</c> parameter is required for all other data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// Sets the frequency for Amazon Kendra to check the documents in your data source repository
        /// and update the index. If you don't set a schedule Amazon Kendra will not periodically
        /// update the index. You can call the <c>StartDataSourceSyncJob</c> API to update the
        /// index.
        /// </para>
        ///  
        /// <para>
        /// Specify a <c>cron-</c> format schedule string or an empty string to indicate that
        /// the index is updated on demand.
        /// </para>
        ///  
        /// <para>
        /// You can't specify the <c>Schedule</c> parameter when the <c>Type</c> parameter is
        /// set to <c>CUSTOM</c>. If you do, you receive a <c>ValidationException</c> exception.
        /// </para>
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the data source connector. You
        /// can also use tags to help control access to the data source connector. Tag keys and
        /// values can consist of Unicode letters, digits, white space, and any of the following
        /// symbols: _ . : / = + - @.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of data source repository. For example, <c>SHAREPOINT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon Virtual Private Cloud to connect to your data
        /// source. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/vpc-configuration.html">Configuring
        /// a VPC</a>.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}

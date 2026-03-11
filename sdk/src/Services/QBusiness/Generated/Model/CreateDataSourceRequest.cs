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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSource operation.
    /// Creates a data source connector for an Amazon Q Business application.
    /// 
    ///  
    /// <para>
    ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
    /// the data source was successfully created. Otherwise, an exception is raised.
    /// </para>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _clientToken;
        private Amazon.Runtime.Documents.Document _configuration;
        private string _description;
        private string _displayName;
        private DocumentEnrichmentConfiguration _documentEnrichmentConfiguration;
        private string _indexId;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;
        private string _roleArn;
        private string _syncSchedule;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        ///  The identifier of the Amazon Q Business application the data source will be attached
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token you provide to identify a request to create a data source connector. Multiple
        /// calls to the <c>CreateDataSource</c> API with the same client token will create only
        /// one data source connector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration information to connect your data source repository to Amazon Q Business.
        /// Use this parameter to provide a JSON schema with configuration information specific
        /// to your data source connector.
        /// </para>
        ///  
        /// <para>
        /// Each data source has a JSON schema provided by Amazon Q Business that you must use.
        /// For example, the Amazon S3 and Web Crawler connectors require the following JSON schemas:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/s3-api.html">Amazon
        /// S3 JSON schema</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/web-crawler-api.html">Web
        /// Crawler JSON schema</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can find configuration templates for your specific data source using the following
        /// steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Navigate to the <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/connectors-list.html">Supported
        /// connectors</a> page in the Amazon Q Business User Guide, and select the data source
        /// of your choice.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Then, from your specific data source connector page, select <b>Using the API</b>.
        /// You will find the JSON schema for your data source, including parameter descriptions,
        /// in this section.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return !this._configuration.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A name for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentEnrichmentConfiguration.
        /// </summary>
        public DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration
        {
            get { return this._documentEnrichmentConfiguration; }
            set { this._documentEnrichmentConfiguration = value; }
        }

        // Check to see if DocumentEnrichmentConfiguration property is set
        internal bool IsSetDocumentEnrichmentConfiguration()
        {
            return this._documentEnrichmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index that you want to use with the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting information from media in documents during ingestion.
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration
        {
            get { return this._mediaExtractionConfiguration; }
            set { this._mediaExtractionConfiguration = value; }
        }

        // Check to see if MediaExtractionConfiguration property is set
        internal bool IsSetMediaExtractionConfiguration()
        {
            return this._mediaExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access the data source
        /// and required resources. This field is required for all connector types except custom
        /// connectors, where it is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SyncSchedule. 
        /// <para>
        /// Sets the frequency for Amazon Q Business to check the documents in your data source
        /// repository and update your index. If you don't set a schedule, Amazon Q Business won't
        /// periodically update the index.
        /// </para>
        ///  
        /// <para>
        /// Specify a <c>cron-</c> format schedule string or an empty string to indicate that
        /// the index is updated on demand. You can't specify the <c>Schedule</c> parameter when
        /// the <c>Type</c> parameter is set to <c>CUSTOM</c>. If you do, you receive a <c>ValidationException</c>
        /// exception. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=998)]
        public string SyncSchedule
        {
            get { return this._syncSchedule; }
            set { this._syncSchedule = value; }
        }

        // Check to see if SyncSchedule property is set
        internal bool IsSetSyncSchedule()
        {
            return this._syncSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the data source connector. You
        /// can also use tags to help control access to the data source connector. Tag keys and
        /// values can consist of Unicode letters, digits, white space, and any of the following
        /// symbols: _ . : / = + - @.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon VPC (Virtual Private Cloud) to connect to
        /// your data source. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/connector-vpc.html">Using
        /// Amazon VPC with Amazon Q Business connectors</a>.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}
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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataSource operation. Updates an existing
    /// Amazon Q Business data source connector.
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        ///  The identifier of the Amazon Q Business application the data source is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Configuration.
        /// </summary>
        public Amazon.Runtime.Documents.Document Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => !this.Configuration.IsNull();

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A name of the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DocumentEnrichmentConfiguration.
        /// </summary>
        public DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DocumentEnrichmentConfiguration property is set.
        /// </summary>
        internal bool IsSetDocumentEnrichmentConfiguration() => this.DocumentEnrichmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index attached to the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting information from media in documents for your data
        /// source.
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MediaExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetMediaExtractionConfiguration() => this.MediaExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role with permission to access the data source
        /// and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SyncSchedule. 
        /// <para>
        /// The chosen update frequency for your data source.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 998)]
        public string SyncSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SyncSchedule property is set.
        /// </summary>
        internal bool IsSetSyncSchedule() => this.SyncSchedule != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}

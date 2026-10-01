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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains configurations for Amazon Redshift data storage. Specify the data storage
    /// service to use in the <c>type</c> field and include the corresponding field. For more
    /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-build-structured.html">Build
    /// a knowledge base by connecting to a structured data source</a> in the Amazon Bedrock
    /// User Guide.
    /// </summary>
    public partial class RedshiftQueryEngineStorageConfiguration
    {
        /// <summary>
        /// Gets and sets the property AwsDataCatalogConfiguration. 
        /// <para>
        /// Specifies configurations for storage in Glue Data Catalog.
        /// </para>
        /// </summary>
        public RedshiftQueryEngineAwsDataCatalogStorageConfiguration AwsDataCatalogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AwsDataCatalogConfiguration property is set.
        /// </summary>
        internal bool IsSetAwsDataCatalogConfiguration() => this.AwsDataCatalogConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedshiftConfiguration. 
        /// <para>
        /// Specifies configurations for storage in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftQueryEngineRedshiftStorageConfiguration RedshiftConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftConfiguration property is set.
        /// </summary>
        internal bool IsSetRedshiftConfiguration() => this.RedshiftConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data storage service to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RedshiftQueryEngineStorageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

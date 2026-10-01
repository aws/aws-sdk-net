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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateKnowledgeBase operation. Updates the properties
    /// of an existing knowledge base.
    /// </summary>
    public partial class UpdateKnowledgeBaseRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AccessControlConfiguration. 
        /// <para>
        /// The access control configuration for the knowledge base. If you don't specify this
        /// parameter, the existing setting is retained.
        /// </para>
        /// </summary>
        public AccessControlConfiguration AccessControlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlConfiguration property is set.
        /// </summary>
        internal bool IsSetAccessControlConfiguration() => this.AccessControlConfiguration != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the knowledge base. If you don't specify a description, the existing
        /// description is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsEmailNotificationOptedForIngestionFailures. 
        /// <para>
        /// Specifies whether email notifications are enabled for ingestion failures.
        /// </para>
        /// </summary>
        public bool? IsEmailNotificationOptedForIngestionFailures { get; set; }

        /// <summary>
        /// Checks to see if the IsEmailNotificationOptedForIngestionFailures property is set.
        /// </summary>
        internal bool IsSetIsEmailNotificationOptedForIngestionFailures() => this.IsEmailNotificationOptedForIngestionFailures.HasValue;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseConfiguration() => this.KnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration.
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MediaExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetMediaExtractionConfiguration() => this.MediaExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base. If you don't specify a name, the existing name is
        /// retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}

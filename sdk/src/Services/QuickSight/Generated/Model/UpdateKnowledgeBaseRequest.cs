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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// Container for the parameters to the UpdateKnowledgeBase operation.
    /// Updates the properties of an existing knowledge base.
    /// </summary>
    public partial class UpdateKnowledgeBaseRequest : AmazonQuickSightRequest
    {
        private AccessControlConfiguration _accessControlConfiguration;
        private string _awsAccountId;
        private string _description;
        private bool? _isEmailNotificationOptedForIngestionFailures;
        private KnowledgeBaseConfiguration _knowledgeBaseConfiguration;
        private string _knowledgeBaseId;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;
        private string _name;

        /// <summary>
        /// Gets and sets the property AccessControlConfiguration. 
        /// <para>
        /// The access control configuration for the knowledge base. If you don't specify this
        /// parameter, the existing setting is retained.
        /// </para>
        /// </summary>
        public AccessControlConfiguration AccessControlConfiguration
        {
            get { return this._accessControlConfiguration; }
            set { this._accessControlConfiguration = value; }
        }

        // Check to see if AccessControlConfiguration property is set
        internal bool IsSetAccessControlConfiguration()
        {
            return this._accessControlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the knowledge base. If you don't specify a description, the existing
        /// description is retained.
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
        /// Gets and sets the property IsEmailNotificationOptedForIngestionFailures. 
        /// <para>
        /// Specifies whether email notifications are enabled for ingestion failures.
        /// </para>
        /// </summary>
        public bool? IsEmailNotificationOptedForIngestionFailures
        {
            get { return this._isEmailNotificationOptedForIngestionFailures; }
            set { this._isEmailNotificationOptedForIngestionFailures = value; }
        }

        // Check to see if IsEmailNotificationOptedForIngestionFailures property is set
        internal bool IsSetIsEmailNotificationOptedForIngestionFailures()
        {
            return this._isEmailNotificationOptedForIngestionFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration
        {
            get { return this._knowledgeBaseConfiguration; }
            set { this._knowledgeBaseConfiguration = value; }
        }

        // Check to see if KnowledgeBaseConfiguration property is set
        internal bool IsSetKnowledgeBaseConfiguration()
        {
            return this._knowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base. If you don't specify a name, the existing name is
        /// retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
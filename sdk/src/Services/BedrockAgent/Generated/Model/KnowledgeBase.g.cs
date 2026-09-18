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
    /// Contains information about a knowledge base.
    /// </summary>
    public partial class KnowledgeBase
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time the knowledge base was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// A list of reasons that the API operation on the knowledge base failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string KnowledgeBaseArn { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseArn property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseArn() => this.KnowledgeBaseArn != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration. 
        /// <para>
        /// Contains details about the embeddings configuration of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseConfiguration property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseConfiguration() => this.KnowledgeBaseConfiguration != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role with permissions to invoke API operations
        /// on the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the knowledge base. The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING – The knowledge base is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE – The knowledge base is ready to be queried.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – The knowledge base is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The knowledge base is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED – The knowledge base API operation failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Contains details about the storage configuration of the knowledge base.
        /// </para>
        /// </summary>
        public StorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time the knowledge base was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}

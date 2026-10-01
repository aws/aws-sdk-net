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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Contains information about a source code repository that hosts the workflow definition
    /// files.
    /// </summary>
    public partial class DefinitionRepository
    {
        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection to the source code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property ExcludeFilePatterns. 
        /// <para>
        /// A list of file patterns to exclude when retrieving the workflow definition from the
        /// repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> ExcludeFilePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeFilePatterns property is set.
        /// </summary>
        internal bool IsSetExcludeFilePatterns() => this.ExcludeFilePatterns != null && (this.ExcludeFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FullRepositoryId. 
        /// <para>
        /// The full repository identifier, including the repository owner and name. For example,
        /// 'repository-owner/repository-name'.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FullRepositoryId { get; set; }

        /// <summary>
        /// Checks to see if the FullRepositoryId property is set.
        /// </summary>
        internal bool IsSetFullRepositoryId() => this.FullRepositoryId != null;

        /// <summary>
        /// Gets and sets the property SourceReference. 
        /// <para>
        /// The source reference for the repository, such as a branch name, tag, or commit ID.
        /// </para>
        /// </summary>
        public SourceReference SourceReference { get; set; }

        /// <summary>
        /// Checks to see if the SourceReference property is set.
        /// </summary>
        internal bool IsSetSourceReference() => this.SourceReference != null;
    }
}

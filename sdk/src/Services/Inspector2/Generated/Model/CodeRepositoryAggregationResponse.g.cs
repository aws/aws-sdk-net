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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by code repository.
    /// </summary>
    public partial class CodeRepositoryAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the code repository.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ExploitAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings that have an exploit available for the code repository.
        /// </para>
        /// </summary>
        public long? ExploitAvailableActiveFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the ExploitAvailableActiveFindingsCount property is set.
        /// </summary>
        internal bool IsSetExploitAvailableActiveFindingsCount() => this.ExploitAvailableActiveFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property FixAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings that have a fix available for the code repository.
        /// </para>
        /// </summary>
        public long? FixAvailableActiveFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailableActiveFindingsCount property is set.
        /// </summary>
        internal bool IsSetFixAvailableActiveFindingsCount() => this.FixAvailableActiveFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectNames. 
        /// <para>
        /// The names of the projects associated with the code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectNames { get; set; }

        /// <summary>
        /// Checks to see if the ProjectNames property is set.
        /// </summary>
        internal bool IsSetProjectNames() => this.ProjectNames != null;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of repository provider for the code repository.
        /// </para>
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID of the code repository.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts.
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}

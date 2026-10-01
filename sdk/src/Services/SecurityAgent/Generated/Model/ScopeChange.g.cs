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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A code change in a CI/CD pipeline run that defines what a CI/CD pentest job tests.
    /// Each scope change identifies an integrated repository and the commit range for the
    /// change.
    /// </summary>
    public partial class ScopeChange
    {
        /// <summary>
        /// Gets and sets the property BaseCommitSha. 
        /// <para>
        /// The commit SHA that the change is compared against. When omitted, the change is evaluated
        /// against the head commit alone.
        /// </para>
        /// </summary>
        public string BaseCommitSha { get; set; }

        /// <summary>
        /// Checks to see if the BaseCommitSha property is set.
        /// </summary>
        internal bool IsSetBaseCommitSha() => this.BaseCommitSha != null;

        /// <summary>
        /// Gets and sets the property HeadCommitSha. 
        /// <para>
        /// The commit SHA at the tip of the change to be tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HeadCommitSha { get; set; }

        /// <summary>
        /// Checks to see if the HeadCommitSha property is set.
        /// </summary>
        internal bool IsSetHeadCommitSha() => this.HeadCommitSha != null;

        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The identifier of the integration for the source-code provider that hosts the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property ProviderResourceId. 
        /// <para>
        /// The provider-specific identifier of the repository the change belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProviderResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ProviderResourceId property is set.
        /// </summary>
        internal bool IsSetProviderResourceId() => this.ProviderResourceId != null;

        /// <summary>
        /// Gets and sets the property TriggerRunId. 
        /// <para>
        /// The identifier of the CI/CD pipeline run that triggered this pentest job.
        /// </para>
        /// </summary>
        public string TriggerRunId { get; set; }

        /// <summary>
        /// Checks to see if the TriggerRunId property is set.
        /// </summary>
        internal bool IsSetTriggerRunId() => this.TriggerRunId != null;
    }
}

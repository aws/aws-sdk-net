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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Summary of a context associated with a profile, representing application or environment
    /// information used during recommendation generation.
    /// </summary>
    public partial class ContextSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of application described by this context.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The typed content of the context, containing application-specific fields such as account
        /// IDs, Regions, services, and resource types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContextContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContextType. 
        /// <para>
        /// The type of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContextType ContextType { get; set; }

        /// <summary>
        /// Checks to see if the ContextType property is set.
        /// </summary>
        internal bool IsSetContextType() => this.ContextType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the context was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created this context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The business criticality of the application described by this context.
        /// </para>
        /// </summary>
        public Criticality Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The timestamp when the context was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The identifier of the user or system that last modified this context.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1000)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}

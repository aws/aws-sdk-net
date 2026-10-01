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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// This is the response object from the CreateScope operation.
    /// </summary>
    public partial class CreateScopeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HasPublishedVersion. 
        /// <para>
        /// Specifies whether a published version of the resource exists.
        /// </para>
        /// </summary>
        public bool? HasPublishedVersion { get; set; }

        /// <summary>
        /// Checks to see if the HasPublishedVersion property is set.
        /// </summary>
        internal bool IsSetHasPublishedVersion() => this.HasPublishedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IsSnapshot. 
        /// <para>
        /// Specifies whether the resource is a snapshot of a published version.
        /// </para>
        /// </summary>
        public bool? IsSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the IsSnapshot property is set.
        /// </summary>
        internal bool IsSetIsSnapshot() => this.IsSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property ScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1010)]
        public string ScopeArn { get; set; }

        /// <summary>
        /// Checks to see if the ScopeArn property is set.
        /// </summary>
        internal bool IsSetScopeArn() => this.ScopeArn != null;

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The configuration that defines which accounts and resources are in scope.
        /// </para>
        /// </summary>
        public ScopeConfiguration ScopeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScopeConfiguration property is set.
        /// </summary>
        internal bool IsSetScopeConfiguration() => this.ScopeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScopeDescription. 
        /// <para>
        /// A description of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string ScopeDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScopeDescription property is set.
        /// </summary>
        internal bool IsSetScopeDescription() => this.ScopeDescription != null;

        /// <summary>
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The service-generated id of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Checks to see if the ScopeId property is set.
        /// </summary>
        internal bool IsSetScopeId() => this.ScopeId != null;

        /// <summary>
        /// Gets and sets the property ScopeName. 
        /// <para>
        /// The name of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ScopeName { get; set; }

        /// <summary>
        /// Checks to see if the ScopeName property is set.
        /// </summary>
        internal bool IsSetScopeName() => this.ScopeName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the resource: <c>DRAFT</c> (unpublished, editable) or <c>ACTIVE</c>
        /// (published, in use).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}

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
    /// Container for the parameters to the UpdateScope operation. Updates the specified scope.
    /// To prevent conflicting concurrent updates, provide the current <c>updateToken</c>.
    /// Use <c>isPublished</c> to publish the update or keep the scope as a draft.
    /// </summary>
    public partial class UpdateScopeRequest : AmazonNetworkSecurityManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Checks to see if the IsPublished property is set.
        /// </summary>
        internal bool IsSetIsPublished() => this.IsPublished.HasValue;

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The configuration that defines which accounts and resources are in scope. If you don't
        /// include this member, the scope keeps its existing configuration.
        /// </para>
        ///  
        /// <para>
        /// A new configuration can change which accounts and resources are selected, but it can't
        /// add or remove the account filter itself: a scope created for multi-account use stays
        /// multi-account, and a scope created for single-account use stays single-account.
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
        /// Gets and sets the property ScopeIdentifier. 
        /// <para>
        /// The identifier of the scope. This is the scope's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1010)]
        public string ScopeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ScopeIdentifier property is set.
        /// </summary>
        internal bool IsSetScopeIdentifier() => this.ScopeIdentifier != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}

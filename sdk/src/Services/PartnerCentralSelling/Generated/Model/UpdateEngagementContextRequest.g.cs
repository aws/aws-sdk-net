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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEngagementContext operation. Updates the
    /// context information for an existing engagement with new or modified data.
    /// </summary>
    public partial class UpdateEngagementContextRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the engagement context update request. This
        /// field takes a string value from a predefined list: <c>AWS</c> or <c>Sandbox</c>. The
        /// catalog determines which environment the engagement context is updated in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ContextIdentifier. 
        /// <para>
        /// The unique identifier of the specific engagement context to be updated. This ensures
        /// that the correct context within the engagement is modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContextIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ContextIdentifier property is set.
        /// </summary>
        internal bool IsSetContextIdentifier() => this.ContextIdentifier != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        /// The unique identifier of the <c>Engagement</c> containing the context to be updated.
        /// This parameter ensures the context update is applied to the correct engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property EngagementLastModifiedAt. 
        /// <para>
        /// The timestamp when the engagement was last modified, used for optimistic concurrency
        /// control. This helps prevent conflicts when multiple users attempt to update the same
        /// engagement simultaneously.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EngagementLastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the EngagementLastModifiedAt property is set.
        /// </summary>
        internal bool IsSetEngagementLastModifiedAt() => this.EngagementLastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// Contains the updated contextual information for the engagement. The structure of this
        /// payload varies based on the context type specified in the Type field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UpdateEngagementContextPayload Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of context being updated within the engagement. This field determines
        /// the structure and content of the context payload being modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EngagementContextType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

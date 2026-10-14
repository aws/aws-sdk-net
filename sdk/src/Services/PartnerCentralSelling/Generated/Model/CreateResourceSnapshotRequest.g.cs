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
    /// Container for the parameters to the CreateResourceSnapshot operation. This action
    /// allows you to create an immutable snapshot of a specific resource, such as an opportunity,
    /// within the context of an engagement. The snapshot captures a subset of the resource's
    /// data based on the schema defined by the provided template.
    /// </summary>
    public partial class CreateResourceSnapshotRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        ///  Specifies the catalog where the snapshot is created. Valid values are <c>AWS</c>
        /// and <c>Sandbox</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Specifies a unique, client-generated UUID to ensure that the request is handled exactly
        /// once. This token helps prevent duplicate snapshot creations. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EngagementIdentifier. 
        /// <para>
        ///  The unique identifier of the engagement associated with this snapshot. This field
        /// links the snapshot to a specific engagement context. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EngagementIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EngagementIdentifier property is set.
        /// </summary>
        internal bool IsSetEngagementIdentifier() => this.EngagementIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        ///  The unique identifier of the specific resource to be snapshotted. The format and
        /// constraints of this identifier depend on the <c>ResourceType</c> specified. For example:
        /// For <c>Opportunity</c> type, it will be an opportunity ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceSnapshotTemplateIdentifier. 
        /// <para>
        ///  The name of the template that defines the schema for the snapshot. This template
        /// determines which subset of the resource data will be included in the snapshot. Must
        /// correspond to an existing and valid template for the specified <c>ResourceType</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceSnapshotTemplateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSnapshotTemplateIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceSnapshotTemplateIdentifier() => this.ResourceSnapshotTemplateIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        ///  Specifies the type of resource for which the snapshot is being created. This field
        /// determines the structure and content of the snapshot. Must be one of the supported
        /// resource types, such as: <c>Opportunity</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}

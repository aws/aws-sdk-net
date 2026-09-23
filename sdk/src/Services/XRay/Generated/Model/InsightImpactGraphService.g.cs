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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about an application that processed requests, users that made requests,
    /// or downstream services, resources, and applications that an application used.
    /// </summary>
    public partial class InsightImpactGraphService
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Identifier of the Amazon Web Services account in which the service runs.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// Connections to downstream services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InsightImpactGraphEdge> Edges { get; set; } = AWSConfigs.InitializeCollections ? new List<InsightImpactGraphEdge>() : null;

        /// <summary>
        /// Checks to see if the Edges property is set.
        /// </summary>
        internal bool IsSetEdges() => this.Edges != null && (this.Edges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The canonical name of the service.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of names for the service, including the canonical name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
        /// </para>
        /// </summary>
        public int? ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services Resource - The type of an Amazon Web Services resource. For example,
        /// AWS::EC2::Instance for an application running on Amazon EC2 or AWS::DynamoDB::Table
        /// for an Amazon DynamoDB table that the application used. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Service - The type of an Amazon Web Services service. For example,
        /// AWS::DynamoDB for downstream calls to Amazon DynamoDB that didn't target a specific
        /// table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Service - The type of an Amazon Web Services service. For example,
        /// AWS::DynamoDB for downstream calls to Amazon DynamoDB that didn't target a specific
        /// table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// remote - A downstream service of indeterminate type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A new global secondary index to be added to an existing table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// New provisioned throughput parameters for an existing global secondary index.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An existing global secondary index to be removed from an existing table.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GlobalSecondaryIndexUpdate
    {
        /// <summary>
        /// Gets and sets the property Create. 
        /// <para>
        /// The parameters required for creating a global secondary index on an existing table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IndexName </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeySchema </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AttributeDefinitions </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProvisionedThroughput </c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CreateGlobalSecondaryIndexAction Create { get; set; }

        /// <summary>
        /// Checks to see if the Create property is set.
        /// </summary>
        internal bool IsSetCreate() => this.Create != null;

        /// <summary>
        /// Gets and sets the property Delete. 
        /// <para>
        /// The name of an existing global secondary index to be removed.
        /// </para>
        /// </summary>
        public DeleteGlobalSecondaryIndexAction Delete { get; set; }

        /// <summary>
        /// Checks to see if the Delete property is set.
        /// </summary>
        internal bool IsSetDelete() => this.Delete != null;

        /// <summary>
        /// Gets and sets the property Update. 
        /// <para>
        /// The name of an existing global secondary index, along with new provisioned throughput
        /// settings to be applied to that index.
        /// </para>
        /// </summary>
        public UpdateGlobalSecondaryIndexAction Update { get; set; }

        /// <summary>
        /// Checks to see if the Update property is set.
        /// </summary>
        internal bool IsSetUpdate() => this.Update != null;
    }
}

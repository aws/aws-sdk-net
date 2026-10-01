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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// An object that contains metadata and details about the entity.
    /// </summary>
    public partial class EntityDetail
    {
        /// <summary>
        /// Gets and sets the property DetailsDocument. 
        /// <para>
        /// An object that contains all the details of the entity.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document DetailsDocument { get; set; }

        /// <summary>
        /// Checks to see if the DetailsDocument property is set.
        /// </summary>
        internal bool IsSetDetailsDocument() => !this.DetailsDocument.IsNull();

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The ID of the entity, in the format of <c>EntityId@RevisionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EntityIdentifier property is set.
        /// </summary>
        internal bool IsSetEntityIdentifier() => this.EntityIdentifier != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The entity type of the entity, in the format of <c>EntityType@Version</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time the entity was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;
    }
}

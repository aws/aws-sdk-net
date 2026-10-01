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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <a>CreateObject</a> operation.
    /// </summary>
    public partial class BatchCreateObject
    {
        /// <summary>
        /// Gets and sets the property BatchReferenceName. 
        /// <para>
        /// The batch reference name. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/transaction_support.html">Transaction
        /// Support</a> for more information.
        /// </para>
        /// </summary>
        public string BatchReferenceName { get; set; }

        /// <summary>
        /// Checks to see if the BatchReferenceName property is set.
        /// </summary>
        internal bool IsSetBatchReferenceName() => this.BatchReferenceName != null;

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LinkName { get; set; }

        /// <summary>
        /// Checks to see if the LinkName property is set.
        /// </summary>
        internal bool IsSetLinkName() => this.LinkName != null;

        /// <summary>
        /// Gets and sets the property ObjectAttributeList. 
        /// <para>
        /// An attribute map, which contains an attribute ARN as the key and attribute value as
        /// the map value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AttributeKeyAndValue> ObjectAttributeList { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeKeyAndValue>() : null;

        /// <summary>
        /// Checks to see if the ObjectAttributeList property is set.
        /// </summary>
        internal bool IsSetObjectAttributeList() => this.ObjectAttributeList != null && (this.ObjectAttributeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// If specified, the parent reference to which this object will be attached.
        /// </para>
        /// </summary>
        public ObjectReference ParentReference { get; set; }

        /// <summary>
        /// Checks to see if the ParentReference property is set.
        /// </summary>
        internal bool IsSetParentReference() => this.ParentReference != null;

        /// <summary>
        /// Gets and sets the property SchemaFacet. 
        /// <para>
        /// A list of <c>FacetArns</c> that will be associated with the object. For more information,
        /// see <a>arns</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<SchemaFacet> SchemaFacet { get; set; } = AWSConfigs.InitializeCollections ? new List<SchemaFacet>() : null;

        /// <summary>
        /// Checks to see if the SchemaFacet property is set.
        /// </summary>
        internal bool IsSetSchemaFacet() => this.SchemaFacet != null && (this.SchemaFacet.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

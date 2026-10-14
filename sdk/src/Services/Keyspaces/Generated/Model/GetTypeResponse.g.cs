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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// This is the response object from the GetType operation.
    /// </summary>
    public partial class GetTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DirectParentTypes. 
        /// <para>
        ///  The types that use this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DirectParentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DirectParentTypes property is set.
        /// </summary>
        internal bool IsSetDirectParentTypes() => this.DirectParentTypes != null && (this.DirectParentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DirectReferringTables. 
        /// <para>
        ///  The tables that use this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DirectReferringTables { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DirectReferringTables property is set.
        /// </summary>
        internal bool IsSetDirectReferringTables() => this.DirectReferringTables != null && (this.DirectReferringTables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldDefinitions. 
        /// <para>
        ///  The names and types that define this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<FieldDefinition> FieldDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldDefinition>() : null;

        /// <summary>
        /// Checks to see if the FieldDefinitions property is set.
        /// </summary>
        internal bool IsSetFieldDefinitions() => this.FieldDefinitions != null && (this.FieldDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyspaceArn. 
        /// <para>
        ///  The unique identifier of the keyspace that contains this type in the format of an
        /// Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1000)]
        public string KeyspaceArn { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceArn property is set.
        /// </summary>
        internal bool IsSetKeyspaceArn() => this.KeyspaceArn != null;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace that contains this type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        ///  The timestamp that shows when this type was last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimestamp() => this.LastModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MaxNestingDepth. 
        /// <para>
        ///  The level of nesting implemented for this type. 
        /// </para>
        /// </summary>
        public int? MaxNestingDepth { get; set; }

        /// <summary>
        /// Checks to see if the MaxNestingDepth property is set.
        /// </summary>
        internal bool IsSetMaxNestingDepth() => this.MaxNestingDepth.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of this type. 
        /// </para>
        /// </summary>
        public TypeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        ///  The name of the type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}

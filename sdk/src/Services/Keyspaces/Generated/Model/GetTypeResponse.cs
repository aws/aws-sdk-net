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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
        private List<string> _directParentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _directReferringTables = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<FieldDefinition> _fieldDefinitions = AWSConfigs.InitializeCollections ? new List<FieldDefinition>() : null;
        private string _keyspaceArn;
        private string _keyspaceName;
        private DateTime? _lastModifiedTimestamp;
        private int? _maxNestingDepth;
        private TypeStatus _status;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property DirectParentTypes. 
        /// <para>
        ///  The types that use this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DirectParentTypes
        {
            get { return this._directParentTypes; }
            set { this._directParentTypes = value; }
        }

        // Check to see if DirectParentTypes property is set
        internal bool IsSetDirectParentTypes()
        {
            return this._directParentTypes != null && (this._directParentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectReferringTables. 
        /// <para>
        ///  The tables that use this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DirectReferringTables
        {
            get { return this._directReferringTables; }
            set { this._directReferringTables = value; }
        }

        // Check to see if DirectReferringTables property is set
        internal bool IsSetDirectReferringTables()
        {
            return this._directReferringTables != null && (this._directReferringTables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldDefinitions. 
        /// <para>
        ///  The names and types that define this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<FieldDefinition> FieldDefinitions
        {
            get { return this._fieldDefinitions; }
            set { this._fieldDefinitions = value; }
        }

        // Check to see if FieldDefinitions property is set
        internal bool IsSetFieldDefinitions()
        {
            return this._fieldDefinitions != null && (this._fieldDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyspaceArn. 
        /// <para>
        ///  The unique identifier of the keyspace that contains this type in the format of an
        /// Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1000)]
        public string KeyspaceArn
        {
            get { return this._keyspaceArn; }
            set { this._keyspaceArn = value; }
        }

        // Check to see if KeyspaceArn property is set
        internal bool IsSetKeyspaceArn()
        {
            return this._keyspaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace that contains this type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        ///  The timestamp that shows when this type was last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxNestingDepth. 
        /// <para>
        ///  The level of nesting implemented for this type. 
        /// </para>
        /// </summary>
        public int? MaxNestingDepth
        {
            get { return this._maxNestingDepth; }
            set { this._maxNestingDepth = value; }
        }

        // Check to see if MaxNestingDepth property is set
        internal bool IsSetMaxNestingDepth()
        {
            return this._maxNestingDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of this type. 
        /// </para>
        /// </summary>
        public TypeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        ///  The name of the type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}
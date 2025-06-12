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
    /// Container for the parameters to the CreateType operation.
    /// The <c>CreateType</c> operation creates a new user-defined type in the specified
    /// keyspace. 
    /// 
    ///  
    /// <para>
    /// To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-create">Permissions
    /// to create a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/udts.html">User-defined
    /// types (UDTs)</a> in the <i>Amazon Keyspaces Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateTypeRequest : AmazonKeyspacesRequest
    {
        private List<FieldDefinition> _fieldDefinitions = AWSConfigs.InitializeCollections ? new List<FieldDefinition>() : null;
        private string _keyspaceName;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property FieldDefinitions. 
        /// <para>
        ///  The field definitions, consisting of names and types, that define this type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace. 
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
        /// Gets and sets the property TypeName. 
        /// <para>
        ///  The name of the user-defined type. 
        /// </para>
        ///  
        /// <para>
        /// UDT names must contain 48 characters or less, must begin with an alphabetic character,
        /// and can only contain alpha-numeric characters and underscores. Amazon Keyspaces converts
        /// upper case characters automatically into lower case characters. 
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can declare a UDT name in double quotes. When declaring a UDT name
        /// inside double quotes, Amazon Keyspaces preserves upper casing and allows special characters.
        /// </para>
        ///  
        /// <para>
        /// You can also use double quotes as part of the name when you create the UDT, but you
        /// must escape each double quote character with an additional double quote character.
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
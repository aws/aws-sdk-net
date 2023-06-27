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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The value of an attribute.
    /// 
    ///  
    /// <para>
    /// Contains information about the runtime context for a request for which an authorization
    /// decision is made. 
    /// </para>
    ///  
    /// <para>
    /// This data type is used as a member of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ContextDefinition.html">ContextDefinition</a>
    /// structure which is uses as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class AttributeValue
    {
        private bool? _boolean;
        private EntityIdentifier _entityIdentifier;
        private long? _long;
        private Dictionary<string, AttributeValue> _record = new Dictionary<string, AttributeValue>();
        private List<AttributeValue> _set = new List<AttributeValue>();
        private string _string;

        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/syntax-datatypes.html#boolean">Boolean</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>{"boolean": true}</code> 
        /// </para>
        /// </summary>
        public bool Boolean
        {
            get { return this._boolean.GetValueOrDefault(); }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// An attribute value of type <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntityIdentifier.html">EntityIdentifier</a>.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>"entityIdentifier": { "entityId": "&lt;id&gt;", "entityType": "&lt;entity
        /// type&gt;"}</code> 
        /// </para>
        /// </summary>
        public EntityIdentifier EntityIdentifier
        {
            get { return this._entityIdentifier; }
            set { this._entityIdentifier = value; }
        }

        // Check to see if EntityIdentifier property is set
        internal bool IsSetEntityIdentifier()
        {
            return this._entityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Long. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/syntax-datatypes.html#long">Long</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>{"long": 0}</code> 
        /// </para>
        /// </summary>
        public long Long
        {
            get { return this._long.GetValueOrDefault(); }
            set { this._long = value; }
        }

        // Check to see if Long property is set
        internal bool IsSetLong()
        {
            return this._long.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/syntax-datatypes.html#record">Record</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>{"record": { "keyName": {} } }</code> 
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && this._record.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/syntax-datatypes.html#set">Set</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>{"set": [ {} ] }</code> 
        /// </para>
        /// </summary>
        public List<AttributeValue> Set
        {
            get { return this._set; }
            set { this._set = value; }
        }

        // Check to see if Set property is set
        internal bool IsSetSet()
        {
            return this._set != null && this._set.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/syntax-datatypes.html#string">String</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>{"string": "abc"}</code> 
        /// </para>
        /// </summary>
        public string String
        {
            get { return this._string; }
            set { this._string = value; }
        }

        // Check to see if String property is set
        internal bool IsSetString()
        {
            return this._string != null;
        }

    }
}
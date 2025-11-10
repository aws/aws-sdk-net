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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The value of an entity's Cedar tag.
    /// 
    ///  
    /// <para>
    /// This data type is used as a member of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntityItem.html">EntityItem</a>
    /// structure that forms the body of the <c>Entities</c> request parameter for the <a
    /// href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>,
    /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorized.html">BatchIsAuthorized</a>,
    /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>,
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorizedWithToken.html">BatchIsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class CedarTagValue
    {
        private bool? _boolean;
        private string _datetime;
        private string _decimal;
        private string _duration;
        private EntityIdentifier _entityIdentifier;
        private string _ipaddr;
        private long? _long;
        private Dictionary<string, CedarTagValue> _record = AWSConfigs.InitializeCollections ? new Dictionary<string, CedarTagValue>() : null;
        private List<CedarTagValue> _set = AWSConfigs.InitializeCollections ? new List<CedarTagValue>() : null;
        private string _string;

        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-bool">Boolean</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"boolean": false}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Boolean
        {
            get { return this._boolean; }
            set { this._boolean = value; }
        }

        // Check to see if Boolean property is set
        internal bool IsSetBoolean()
        {
            return this._boolean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Datetime. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-datetime">datetime</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"datetime": "2025-11-04T11:35:00.000+0100"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=10, Max=28)]
        public string Datetime
        {
            get { return this._datetime; }
            set { this._datetime = value; }
        }

        // Check to see if Datetime property is set
        internal bool IsSetDatetime()
        {
            return this._datetime != null;
        }

        /// <summary>
        /// Gets and sets the property Decimal. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-decimal">decimal</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"decimal": "-2.0"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=3, Max=23)]
        public string Decimal
        {
            get { return this._decimal; }
            set { this._decimal = value; }
        }

        // Check to see if Decimal property is set
        internal bool IsSetDecimal()
        {
            return this._decimal != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-duration">duration</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"duration": "-1d12h"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=100)]
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// A Cedar tag value of type <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntityIdentifier.html">EntityIdentifier</a>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"entityIdentifier": { "entityId": "alice", "entityType": "User"} }</c>
        /// 
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
        /// Gets and sets the property Ipaddr. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-ipaddr">ipaddr</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"ip": "10.50.0.0/24"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=44)]
        public string Ipaddr
        {
            get { return this._ipaddr; }
            set { this._ipaddr = value; }
        }

        // Check to see if Ipaddr property is set
        internal bool IsSetIpaddr()
        {
            return this._ipaddr != null;
        }

        /// <summary>
        /// Gets and sets the property Long. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-long">Long</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"long": 0}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public long? Long
        {
            get { return this._long; }
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
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-record">Record</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"record": { "keyName": {} } }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, CedarTagValue> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && (this._record.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-set">Set</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"set": [ { "string": "abc" } ] }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CedarTagValue> Set
        {
            get { return this._set; }
            set { this._set = value; }
        }

        // Check to see if Set property is set
        internal bool IsSetSet()
        {
            return this._set != null && (this._set.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// A Cedar tag value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-string">String</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"string": "abc"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
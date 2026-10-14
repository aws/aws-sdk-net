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
    /// structure which is used as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>,
    /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorized.html">BatchIsAuthorized</a>,
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class AttributeValue
    {
        /// <summary>
        /// Gets and sets the property Boolean. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-bool">Boolean</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"boolean": true}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Boolean { get; set; }

        /// <summary>
        /// Checks to see if the Boolean property is set.
        /// </summary>
        internal bool IsSetBoolean() => this.Boolean.HasValue;

        /// <summary>
        /// Gets and sets the property Datetime. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-datetime">datetime</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"datetime": "2024-10-15T11:35:00Z"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 10, Max = 28)]
        public string Datetime { get; set; }

        /// <summary>
        /// Checks to see if the Datetime property is set.
        /// </summary>
        internal bool IsSetDatetime() => this.Datetime != null;

        /// <summary>
        /// Gets and sets the property Decimal. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-decimal">decimal</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"decimal": "1.1"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 3, Max = 23)]
        public string Decimal { get; set; }

        /// <summary>
        /// Checks to see if the Decimal property is set.
        /// </summary>
        internal bool IsSetDecimal() => this.Decimal != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-duration">duration</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"duration": "1h30m"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 100)]
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// An attribute value of type <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_EntityIdentifier.html">EntityIdentifier</a>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"entityIdentifier": { "entityId": "alice", "entityType": "User"} }</c>
        /// 
        /// </para>
        /// </summary>
        public EntityIdentifier EntityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EntityIdentifier property is set.
        /// </summary>
        internal bool IsSetEntityIdentifier() => this.EntityIdentifier != null;

        /// <summary>
        /// Gets and sets the property Ipaddr. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-ipaddr">ipaddr</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"ip": "192.168.1.100"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 44)]
        public string Ipaddr { get; set; }

        /// <summary>
        /// Checks to see if the Ipaddr property is set.
        /// </summary>
        internal bool IsSetIpaddr() => this.Ipaddr != null;

        /// <summary>
        /// Gets and sets the property Long. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-long">Long</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"long": 0}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public long? Long { get; set; }

        /// <summary>
        /// Checks to see if the Long property is set.
        /// </summary>
        internal bool IsSetLong() => this.Long.HasValue;

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-record">Record</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"record": { "keyName": {} } }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Record { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the Record property is set.
        /// </summary>
        internal bool IsSetRecord() => this.Record != null && (this.Record.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Set. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-set">Set</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"set": [ {} ] }</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeValue> Set { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the Set property is set.
        /// </summary>
        internal bool IsSetSet() => this.Set != null && (this.Set.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// An attribute value of <a href="https://docs.cedarpolicy.com/policies/syntax-datatypes.html#datatype-string">String</a>
        /// type.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"string": "abc"}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;
    }
}

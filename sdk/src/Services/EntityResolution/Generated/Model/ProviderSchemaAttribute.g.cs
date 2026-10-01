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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The provider schema attribute.
    /// </summary>
    public partial class ProviderSchemaAttribute
    {
        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property Hashing. 
        /// <para>
        /// The hashing attribute of the provider schema.
        /// </para>
        /// </summary>
        public bool? Hashing { get; set; }

        /// <summary>
        /// Checks to see if the Hashing property is set.
        /// </summary>
        internal bool IsSetHashing() => this.Hashing.HasValue;

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The sub type of the provider schema attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string SubType { get; set; }

        /// <summary>
        /// Checks to see if the SubType property is set.
        /// </summary>
        internal bool IsSetSubType() => this.SubType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the provider schema attribute.
        /// </para>
        ///  
        /// <para>
        /// LiveRamp supports: <c>NAME</c> | <c>NAME_FIRST</c> | <c>NAME_MIDDLE</c> | <c>NAME_LAST</c>
        /// | <c>ADDRESS</c> | <c>ADDRESS_STREET1</c> | <c>ADDRESS_STREET2</c> | <c>ADDRESS_STREET3</c>
        /// | <c>ADDRESS_CITY</c> | <c>ADDRESS_STATE</c> | <c>ADDRESS_COUNTRY</c> | <c>ADDRESS_POSTALCODE</c>
        /// | <c>PHONE</c> | <c>PHONE_NUMBER</c> | <c>EMAIL_ADDRESS</c> | <c>UNIQUE_ID</c> | <c>PROVIDER_ID</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// TransUnion supports: <c>NAME</c> | <c>NAME_FIRST</c> | <c>NAME_LAST</c> | <c>ADDRESS</c>
        /// | <c>ADDRESS_CITY</c> | <c>ADDRESS_STATE</c> | <c>ADDRESS_COUNTRY</c> | <c>ADDRESS_POSTALCODE</c>
        /// | <c>PHONE_NUMBER</c> | <c>EMAIL_ADDRESS</c> | <c>UNIQUE_ID</c> | <c>DATE</c> | <c>IPV4</c>
        /// | <c>IPV6</c> | <c>MAID</c> 
        /// </para>
        ///  
        /// <para>
        /// Unified ID 2.0 supports: <c>PHONE_NUMBER</c> | <c>EMAIL_ADDRESS</c> | <c>UNIQUE_ID</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaAttributeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

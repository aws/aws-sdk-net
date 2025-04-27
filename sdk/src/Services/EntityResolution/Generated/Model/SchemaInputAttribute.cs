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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
    /// A configuration object for defining input data fields in Entity Resolution. The <c>SchemaInputAttribute</c>
    /// specifies how individual fields in your input data should be processed and matched.
    /// </summary>
    public partial class SchemaInputAttribute
    {
        private string _fieldName;
        private string _groupName;
        private bool? _hashed;
        private string _matchKey;
        private string _subType;
        private SchemaAttributeType _type;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// A string containing the field name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// A string that instructs Entity Resolution to combine several columns into a unified
        /// column with the identical attribute type. 
        /// </para>
        ///  
        /// <para>
        /// For example, when working with columns such as <c>NAME_FIRST</c>, <c>NAME_MIDDLE</c>,
        /// and <c>NAME_LAST</c>, assigning them a common <c>groupName</c> will prompt Entity
        /// Resolution to concatenate them into a single value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Hashed. 
        /// <para>
        ///  Indicates if the column values are hashed in the schema input. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>TRUE</c>, the column values are hashed. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>FALSE</c>, the column values are cleartext.
        /// </para>
        /// </summary>
        public bool? Hashed
        {
            get { return this._hashed; }
            set { this._hashed = value; }
        }

        // Check to see if Hashed property is set
        internal bool IsSetHashed()
        {
            return this._hashed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchKey. 
        /// <para>
        /// A key that allows grouping of multiple input attributes into a unified matching group.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, consider a scenario where the source table contains various addresses,
        /// such as <c>business_address</c> and <c>shipping_address</c>. By assigning a <c>matchKey</c>
        /// called <c>address</c> to both attributes, Entity Resolution will match records across
        /// these fields to create a consolidated matching group.
        /// </para>
        ///  
        /// <para>
        /// If no <c>matchKey</c> is specified for a column, it won't be utilized for matching
        /// purposes but will still be included in the output table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string MatchKey
        {
            get { return this._matchKey; }
            set { this._matchKey = value; }
        }

        // Check to see if MatchKey property is set
        internal bool IsSetMatchKey()
        {
            return this._matchKey != null;
        }

        /// <summary>
        /// Gets and sets the property SubType. 
        /// <para>
        /// The subtype of the attribute, selected from a list of values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SubType
        {
            get { return this._subType; }
            set { this._subType = value; }
        }

        // Check to see if SubType property is set
        internal bool IsSetSubType()
        {
            return this._subType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the attribute, selected from a list of values.
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
        /// | <c>PHONE_NUMBER</c> | <c>EMAIL_ADDRESS</c> | <c>UNIQUE_ID</c> | <c>IPV4</c> | <c>IPV6</c>
        /// | <c>MAID</c> 
        /// </para>
        ///  
        /// <para>
        /// Unified ID 2.0 supports: <c>PHONE_NUMBER</c> | <c>EMAIL_ADDRESS</c> | <c>UNIQUE_ID</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Normalization is only supported for <c>NAME</c>, <c>ADDRESS</c>, <c>PHONE</c>, and
        /// <c>EMAIL_ADDRESS</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you want to normalize <c>NAME_FIRST</c>, <c>NAME_MIDDLE</c>, and <c>NAME_LAST</c>,
        /// you must group them by assigning them to the <c>NAME</c> <c>groupName</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you want to normalize <c>ADDRESS_STREET1</c>, <c>ADDRESS_STREET2</c>, <c>ADDRESS_STREET3</c>,
        /// <c>ADDRESS_CITY</c>, <c>ADDRESS_STATE</c>, <c>ADDRESS_COUNTRY</c>, and <c>ADDRESS_POSTALCODE</c>,
        /// you must group them by assigning them to the <c>ADDRESS</c> <c>groupName</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you want to normalize <c>PHONE_NUMBER</c> and <c>PHONE_COUNTRYCODE</c>, you must
        /// group them by assigning them to the <c>PHONE</c> <c>groupName</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaAttributeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
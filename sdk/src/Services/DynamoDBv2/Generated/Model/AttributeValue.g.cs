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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the data for an attribute.
    /// 
    ///  
    /// <para>
    /// Each attribute value is described as a name-value pair. The name is the data type,
    /// and the value is the data itself.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html#HowItWorks.DataTypes">Data
    /// Types</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AttributeValue
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AttributeValue() { }

        /// <summary>
        /// Instantiates AttributeValue with the parameterized properties
        /// </summary>
        /// <param name="s">An attribute of type String. For example:      <c>"S": "Hello"</c>   </param>
        public AttributeValue(string s)
        {
            this.S = s;
        }

        /// <summary>
        /// Instantiates AttributeValue with the parameterized properties
        /// </summary>
        /// <param name="ss">An attribute of type String Set. For example:      <c>"SS": ["Giraffe", "Hippo" ,"Zebra"]</c>   </param>
        public AttributeValue(List<string> ss)
        {
            this.SS = ss;
        }

        /// <summary>
        /// Gets and sets the property B. 
        /// <para>
        /// An attribute of type Binary. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"B": "dGhpcyB0ZXh0IGlzIGJhc2U2NC1lbmNvZGVk"</c> 
        /// </para>
        /// </summary>
        public MemoryStream B { get; set; }

        /// <summary>
        /// Checks to see if the B property is set.
        /// </summary>
        internal bool IsSetB() => this.B != null;

        private bool? _BOOL;

        /// <summary>
        /// Gets and sets the property BOOL. 
        /// <para>
        /// An attribute of type Boolean. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"BOOL": true</c> 
        /// </para>
        /// </summary>
        public bool? BOOL { get => this._BOOL; set => this._BOOL = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="BOOL"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="BOOL"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsBOOLSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._BOOL);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._BOOL);
        }

        /// <summary>
        /// Checks to see if the BOOL property is set.
        /// </summary>
        internal bool IsSetBOOL() => this.IsBOOLSet;

        private List<MemoryStream> _BS = AWSConfigs.InitializeCollections ? new List<MemoryStream>() : null;

        /// <summary>
        /// Gets and sets the property BS. 
        /// <para>
        /// An attribute of type Binary Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"BS": ["U3Vubnk=", "UmFpbnk=", "U25vd3k="]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStream> BS { get => this._BS; set => this._BS = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="BS"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="BS"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsBSSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._BS);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._BS);
        }

        /// <summary>
        /// Checks to see if the BS property is set.
        /// </summary>
        internal bool IsSetBS() => this.IsBSSet;

        private List<AttributeValue> _L = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property L. 
        /// <para>
        /// An attribute of type List. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"L": [ {"S": "Cookies"} , {"S": "Coffee"}, {"N": "3.14159"}]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeValue> L { get => this._L; set => this._L = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="L"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="L"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsLSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._L);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._L);
        }

        /// <summary>
        /// Checks to see if the L property is set.
        /// </summary>
        internal bool IsSetL() => this.IsLSet;

        private Dictionary<string, AttributeValue> _M = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property M. 
        /// <para>
        /// An attribute of type Map. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"M": {"Name": {"S": "Joe"}, "Age": {"N": "35"}}</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> M { get => this._M; set => this._M = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="M"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="M"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsMSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._M);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._M);
        }

        /// <summary>
        /// Checks to see if the M property is set.
        /// </summary>
        internal bool IsSetM() => this.IsMSet;

        /// <summary>
        /// Gets and sets the property N. 
        /// <para>
        /// An attribute of type Number. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"N": "123.45"</c> 
        /// </para>
        ///  
        /// <para>
        /// Numbers are sent across the network to DynamoDB as strings, to maximize compatibility
        /// across languages and libraries. However, DynamoDB treats them as number type attributes
        /// for mathematical operations.
        /// </para>
        /// </summary>
        public string N { get; set; }

        /// <summary>
        /// Checks to see if the N property is set.
        /// </summary>
        internal bool IsSetN() => this.N != null;

        private List<string> _NS = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NS. 
        /// <para>
        /// An attribute of type Number Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"NS": ["42.2", "-19", "7.5", "3.14"]</c> 
        /// </para>
        ///  
        /// <para>
        /// Numbers are sent across the network to DynamoDB as strings, to maximize compatibility
        /// across languages and libraries. However, DynamoDB treats them as number type attributes
        /// for mathematical operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NS { get => this._NS; set => this._NS = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="NS"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="NS"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsNSSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._NS);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._NS);
        }

        /// <summary>
        /// Checks to see if the NS property is set.
        /// </summary>
        internal bool IsSetNS() => this.IsNSSet;

        /// <summary>
        /// Gets and sets the property NULL. 
        /// <para>
        /// An attribute of type Null. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"NULL": true</c> 
        /// </para>
        /// </summary>
        public bool? NULL { get; set; }

        /// <summary>
        /// Checks to see if the NULL property is set.
        /// </summary>
        internal bool IsSetNULL() => this.NULL.HasValue;

        /// <summary>
        /// Gets and sets the property S. 
        /// <para>
        /// An attribute of type String. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"S": "Hello"</c> 
        /// </para>
        /// </summary>
        public string S { get; set; }

        /// <summary>
        /// Checks to see if the S property is set.
        /// </summary>
        internal bool IsSetS() => this.S != null;

        private List<string> _SS = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SS. 
        /// <para>
        /// An attribute of type String Set. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"SS": ["Giraffe", "Hippo" ,"Zebra"]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SS { get => this._SS; set => this._SS = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="SS"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="SS"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsSSSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._SS);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._SS);
        }

        /// <summary>
        /// Checks to see if the SS property is set.
        /// </summary>
        internal bool IsSetSS() => this.IsSSSet;
    }
}

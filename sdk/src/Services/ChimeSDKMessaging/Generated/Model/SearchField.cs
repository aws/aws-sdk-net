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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
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
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// A <c>Field</c> of the channel that you want to search.
    /// 
    ///  <note> 
    /// <para>
    /// This operation isn't supported for <c>AppInstanceUsers</c> with a large number of
    /// memberships.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchField
    {
        private SearchFieldKey _key;
        private SearchFieldOperator _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// An <c>enum</c> value that indicates the key to search the channel on. <c>MEMBERS</c>
        /// allows you to search channels based on memberships. You can use it with the <c>EQUALS</c>
        /// operator to get channels whose memberships are equal to the specified values, and
        /// with the <c>INCLUDES</c> operator to get channels whose memberships include the specified
        /// values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchFieldKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator used to compare field values, currently <c>EQUALS</c> or <c>INCLUDES</c>.
        /// Use the <c>EQUALS</c> operator to find channels whose memberships equal the specified
        /// values. Use the <c>INCLUDES</c> operator to find channels whose memberships include
        /// the specified values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchFieldOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that you want to search for, a list of strings. The values must be <c>AppInstanceUserArns</c>
        /// specified as a list of strings.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation isn't supported for <c>AppInstanceUsers</c> with a large number of
        /// memberships.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
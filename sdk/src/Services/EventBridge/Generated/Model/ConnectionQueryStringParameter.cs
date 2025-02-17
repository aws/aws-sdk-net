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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Any additional query string parameter for the connection. You can include up to 100
    /// additional query string parameters per request. Each additional parameter counts towards
    /// the event payload size, which cannot exceed 64 KB.
    /// </summary>
    public partial class ConnectionQueryStringParameter
    {
        private bool? _isValueSecret;
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property IsValueSecret. 
        /// <para>
        /// Specifies whether the value is secret.
        /// </para>
        /// </summary>
        public bool IsValueSecret
        {
            get { return this._isValueSecret.GetValueOrDefault(); }
            set { this._isValueSecret = value; }
        }

        // Check to see if IsValueSecret property is set
        internal bool IsSetIsValueSecret()
        {
            return this._isValueSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for a query string parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Key
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value associated with the key for the query string parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=512)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}
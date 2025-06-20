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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Information about a secondary address component parsed from the query text.
    /// </summary>
    public partial class ParsedQuerySecondaryAddressComponent
    {
        private string _designator;
        private int? _endIndex;
        private string _number;
        private int? _startIndex;
        private string _value;

        /// <summary>
        /// Gets and sets the property Designator. 
        /// <para>
        /// Secondary address designator provided in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=4)]
        public string Designator
        {
            get { return this._designator; }
            set { this._designator = value; }
        }

        // Check to see if Designator property is set
        internal bool IsSetDesignator()
        {
            return this._designator != null;
        }

        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// End index of the parsed secondary address component in the query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? EndIndex
        {
            get { return this._endIndex; }
            set { this._endIndex = value; }
        }

        // Check to see if EndIndex property is set
        internal bool IsSetEndIndex()
        {
            return this._endIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// Secondary address number provided in the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=10)]
        public string Number
        {
            get { return this._number; }
            set { this._number = value; }
        }

        // Check to see if Number property is set
        internal bool IsSetNumber()
        {
            return this._number != null;
        }

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// Start index of the parsed secondary address component in the query text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? StartIndex
        {
            get { return this._startIndex; }
            set { this._startIndex = value; }
        }

        // Check to see if StartIndex property is set
        internal bool IsSetStartIndex()
        {
            return this._startIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value of the parsed secondary address component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=200)]
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
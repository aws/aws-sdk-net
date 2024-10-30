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
    /// Indicates how well the input matches the returned element. It is equal to 1 if all
    /// input tokens are recognized and matched to the title in the result.
    /// </summary>
    public partial class ComponentMatchScores
    {
        private AddressComponentMatchScores _address;
        private double? _title;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The place's address.
        /// </para>
        /// </summary>
        public AddressComponentMatchScores Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Indicates the starting and ending index of the title in the text query that match
        /// the found title. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double Title
        {
            get { return this._title.GetValueOrDefault(); }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title.HasValue; 
        }

    }
}
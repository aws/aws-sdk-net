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

namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// Components that correspond to secondary identifiers on an address. The only component
    /// type supported currently is Unit.
    /// </summary>
    public partial class SecondaryAddressComponent
    {
        /// <summary>
        /// Gets and sets the property Designator. 
        /// <para>
        /// The designator of the secondary address component.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>Apt</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 20)]
        public string Designator { get; set; }

        /// <summary>
        /// Checks to see if the Designator property is set.
        /// </summary>
        internal bool IsSetDesignator() => this.Designator != null;

        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// Number that uniquely identifies a secondary address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 10)]
        public string Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number != null;
    }
}

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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// The Locale data structure represents a geographical region or location.
    /// </summary>
    public partial class Locale
    {
        private string _country;
        private string _subdivision;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        ///  The country of the locale. Must be a valid ISO 3166 country code. For example, the
        /// code US refers to the United States of America. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Subdivision. 
        /// <para>
        /// The state or subdivision of the locale. A valid ISO 3166-2 subdivision code. For example,
        /// the code WA refers to the state of Washington.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string Subdivision
        {
            get { return this._subdivision; }
            set { this._subdivision = value; }
        }

        // Check to see if Subdivision property is set
        internal bool IsSetSubdivision()
        {
            return this._subdivision != null;
        }

    }
}
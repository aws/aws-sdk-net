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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The time window during which the sender prefers to be contacted about an account plan.
    /// This information is advisory. Both fields are optional.
    /// </summary>
    public partial class PreferredContactWindow
    {
        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The IANA time zone name that the window is expressed in, for example <c>America/Chicago</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property Window. 
        /// <para>
        /// The preferred time-of-day band for contact.
        /// </para>
        /// </summary>
        public ContactWindow Window { get; set; }

        /// <summary>
        /// Checks to see if the Window property is set.
        /// </summary>
        internal bool IsSetWindow() => this.Window != null;
    }
}

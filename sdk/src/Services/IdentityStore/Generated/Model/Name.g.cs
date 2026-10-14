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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// The full name of the user.
    /// </summary>
    public partial class Name
    {
        /// <summary>
        /// Gets and sets the property FamilyName. 
        /// <para>
        /// The family name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string FamilyName { get; set; }

        /// <summary>
        /// Checks to see if the FamilyName property is set.
        /// </summary>
        internal bool IsSetFamilyName() => this.FamilyName != null;

        /// <summary>
        /// Gets and sets the property Formatted. 
        /// <para>
        /// A string containing a formatted version of the name for display.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Formatted { get; set; }

        /// <summary>
        /// Checks to see if the Formatted property is set.
        /// </summary>
        internal bool IsSetFormatted() => this.Formatted != null;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property HonorificPrefix. 
        /// <para>
        /// The honorific prefix of the user. For example, "Dr."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string HonorificPrefix { get; set; }

        /// <summary>
        /// Checks to see if the HonorificPrefix property is set.
        /// </summary>
        internal bool IsSetHonorificPrefix() => this.HonorificPrefix != null;

        /// <summary>
        /// Gets and sets the property HonorificSuffix. 
        /// <para>
        /// The honorific suffix of the user. For example, "M.D."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string HonorificSuffix { get; set; }

        /// <summary>
        /// Checks to see if the HonorificSuffix property is set.
        /// </summary>
        internal bool IsSetHonorificSuffix() => this.HonorificSuffix != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The middle name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;
    }
}

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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the grantee.
    /// </summary>
    public partial class Grantee
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Screen name of the grantee.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// Email address of the grantee.
        /// </para>
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// The canonical user ID of the grantee.
        /// </para>
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Checks to see if the ID property is set.
        /// </summary>
        internal bool IsSetID() => this.ID != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of grantee
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        /// URI of the grantee group.
        /// </para>
        /// </summary>
        public string URI { get; set; }

        /// <summary>
        /// Checks to see if the URI property is set.
        /// </summary>
        internal bool IsSetURI() => this.URI != null;
    }
}

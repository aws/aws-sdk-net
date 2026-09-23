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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The phone number associations, such as Amazon Chime account ID, Amazon Chime user
    /// ID, Amazon Chime Voice Connector ID, or Amazon Chime Voice Connector group ID.
    /// </summary>
    public partial class PhoneNumberAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociatedTimestamp. 
        /// <para>
        /// The timestamp of the phone number association, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? AssociatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedTimestamp property is set.
        /// </summary>
        internal bool IsSetAssociatedTimestamp() => this.AssociatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Defines the association with an Amazon Chime account ID, user ID, Amazon Chime Voice
        /// Connector ID, or Amazon Chime Voice Connector group ID.
        /// </para>
        /// </summary>
        public PhoneNumberAssociationName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Contains the ID for the entity specified in Name.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}

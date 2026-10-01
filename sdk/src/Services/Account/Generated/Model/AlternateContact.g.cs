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

namespace Amazon.Account.Model
{
    /// <summary>
    /// A structure that contains the details of an alternate contact associated with an Amazon
    /// Web Services account
    /// </summary>
    public partial class AlternateContact
    {
        /// <summary>
        /// Gets and sets the property AlternateContactType. 
        /// <para>
        /// The type of alternate contact.
        /// </para>
        /// </summary>
        public AlternateContactType AlternateContactType { get; set; }

        /// <summary>
        /// Checks to see if the AlternateContactType property is set.
        /// </summary>
        internal bool IsSetAlternateContactType() => this.AlternateContactType != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address associated with this alternate contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 254)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name associated with this alternate contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number associated with this alternate contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 25)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title associated with this alternate contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}

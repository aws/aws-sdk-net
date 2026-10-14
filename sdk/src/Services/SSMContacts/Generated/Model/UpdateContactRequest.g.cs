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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateContact operation. Updates the contact or
    /// escalation plan specified.
    /// </summary>
    public partial class UpdateContactRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact or escalation plan you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The full name of the contact or escalation plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Plan. 
        /// <para>
        /// A list of stages. A contact has an engagement plan with stages for specified contact
        /// channels. An escalation plan uses these stages to contact specified contacts.
        /// </para>
        /// </summary>
        public Plan Plan { get; set; }

        /// <summary>
        /// Checks to see if the Plan property is set.
        /// </summary>
        internal bool IsSetPlan() => this.Plan != null;
    }
}

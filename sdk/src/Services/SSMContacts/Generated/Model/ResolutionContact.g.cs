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
    /// Information about the engagement resolution steps. The resolution starts from the
    /// first contact, which can be an escalation plan, then resolves to an on-call rotation,
    /// and finally to a personal contact.
    /// 
    ///  
    /// <para>
    /// The <c>ResolutionContact</c> structure describes the information for each node or
    /// step in that process. It contains information about different contact types, such
    /// as the escalation, rotation, and personal contacts.
    /// </para>
    /// </summary>
    public partial class ResolutionContact
    {
        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a contact in the engagement resolution process.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactArn property is set.
        /// </summary>
        internal bool IsSetContactArn() => this.ContactArn != null;

        /// <summary>
        /// Gets and sets the property StageIndex. 
        /// <para>
        /// The stage in the escalation plan that resolves to this contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? StageIndex { get; set; }

        /// <summary>
        /// Checks to see if the StageIndex property is set.
        /// </summary>
        internal bool IsSetStageIndex() => this.StageIndex.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of contact for a resolution step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContactType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}

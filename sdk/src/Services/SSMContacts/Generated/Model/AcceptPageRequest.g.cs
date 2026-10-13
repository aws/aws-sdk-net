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
    /// Container for the parameters to the AcceptPage operation. Used to acknowledge an engagement
    /// to a contact channel during an incident.
    /// </summary>
    public partial class AcceptPageRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptCode. 
        /// <para>
        /// A 6-digit code used to acknowledge the page.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 10)]
        public string AcceptCode { get; set; }

        /// <summary>
        /// Checks to see if the AcceptCode property is set.
        /// </summary>
        internal bool IsSetAcceptCode() => this.AcceptCode != null;

        /// <summary>
        /// Gets and sets the property AcceptCodeValidation. 
        /// <para>
        /// An optional field that Incident Manager uses to <c>ENFORCE</c> <c>AcceptCode</c> validation
        /// when acknowledging an page. Acknowledgement can occur by replying to a page, or when
        /// entering the AcceptCode in the console. Enforcing AcceptCode validation causes Incident
        /// Manager to verify that the code entered by the user matches the code sent by Incident
        /// Manager with the page.
        /// </para>
        ///  
        /// <para>
        /// Incident Manager can also <c>IGNORE</c> <c>AcceptCode</c> validation. Ignoring <c>AcceptCode</c>
        /// validation causes Incident Manager to accept any value entered for the <c>AcceptCode</c>.
        /// </para>
        /// </summary>
        public AcceptCodeValidation AcceptCodeValidation { get; set; }

        /// <summary>
        /// Checks to see if the AcceptCodeValidation property is set.
        /// </summary>
        internal bool IsSetAcceptCodeValidation() => this.AcceptCodeValidation != null;

        /// <summary>
        /// Gets and sets the property AcceptType. 
        /// <para>
        /// The type indicates if the page was <c>DELIVERED</c> or <c>READ</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AcceptType AcceptType { get; set; }

        /// <summary>
        /// Checks to see if the AcceptType property is set.
        /// </summary>
        internal bool IsSetAcceptType() => this.AcceptType != null;

        /// <summary>
        /// Gets and sets the property ContactChannelId. 
        /// <para>
        /// The ARN of the contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ContactChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ContactChannelId property is set.
        /// </summary>
        internal bool IsSetContactChannelId() => this.ContactChannelId != null;

        /// <summary>
        /// Gets and sets the property Note. 
        /// <para>
        /// Information provided by the user when the user acknowledges the page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Note { get; set; }

        /// <summary>
        /// Checks to see if the Note property is set.
        /// </summary>
        internal bool IsSetNote() => this.Note != null;

        /// <summary>
        /// Gets and sets the property PageId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the engagement to a contact channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PageId { get; set; }

        /// <summary>
        /// Checks to see if the PageId property is set.
        /// </summary>
        internal bool IsSetPageId() => this.PageId != null;
    }
}

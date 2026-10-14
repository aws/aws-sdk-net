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
    /// This is the response object from the GetContact operation.
    /// </summary>
    public partial class GetContactResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias of the contact or escalation plan. The alias is unique and identifiable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact or escalation plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ContactArn { get; set; }

        /// <summary>
        /// Checks to see if the ContactArn property is set.
        /// </summary>
        internal bool IsSetContactArn() => this.ContactArn != null;

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
        /// Details about the specific timing or stages and targets of the escalation plan or
        /// engagement plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Plan Plan { get; set; }

        /// <summary>
        /// Checks to see if the Plan property is set.
        /// </summary>
        internal bool IsSetPlan() => this.Plan != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of contact.
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

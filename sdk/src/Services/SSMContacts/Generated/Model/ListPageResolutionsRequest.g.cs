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
    /// Container for the parameters to the ListPageResolutions operation. Returns the resolution
    /// path of an engagement. For example, the escalation plan engaged in an incident might
    /// target an on-call schedule that includes several contacts in a rotation, but just
    /// one contact on-call when the incident starts. The resolution path indicates the hierarchy
    /// of <i>escalation plan > on-call schedule > contact</i>.
    /// </summary>
    public partial class ListPageResolutionsRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact engaged for the incident.
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

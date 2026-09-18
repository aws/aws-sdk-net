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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTemplateShare operation. Delete a review
    /// template share. <para> After the review template share is deleted, Amazon Web Services
    /// accounts, users, organizations, and organizational units (OUs) that you shared the
    /// review template with will no longer be able to apply it to new workloads. </para>
    /// </summary>
    public partial class DeleteTemplateShareRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ShareId.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ShareId { get; set; }

        /// <summary>
        /// Checks to see if the ShareId property is set.
        /// </summary>
        internal bool IsSetShareId() => this.ShareId != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The review template ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 50, Max = 250)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;
    }
}

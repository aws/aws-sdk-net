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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// This is the response object from the CancelChangeSet operation.
    /// </summary>
    public partial class CancelChangeSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChangeSetArn. 
        /// <para>
        /// The ARN associated with the change set referenced in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ChangeSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetArn property is set.
        /// </summary>
        internal bool IsSetChangeSetArn() => this.ChangeSetArn != null;

        /// <summary>
        /// Gets and sets the property ChangeSetId. 
        /// <para>
        /// The unique identifier for the change set referenced in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetId property is set.
        /// </summary>
        internal bool IsSetChangeSetId() => this.ChangeSetId != null;
    }
}

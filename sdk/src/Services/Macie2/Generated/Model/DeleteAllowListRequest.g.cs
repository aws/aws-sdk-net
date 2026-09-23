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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAllowList operation. Deletes an allow list.
    /// </summary>
    public partial class DeleteAllowListRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the Amazon Macie resource that the request applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IgnoreJobChecks. 
        /// <para>
        /// Specifies whether to force deletion of the allow list, even if active classification
        /// jobs are configured to use the list.
        /// </para>
        ///  
        /// <para>
        /// When you try to delete an allow list, Amazon Macie checks for classification jobs
        /// that use the list and have a status other than COMPLETE or CANCELLED. By default,
        /// Macie rejects your request if any jobs meet these criteria. To skip these checks and
        /// delete the list, set this value to true. To delete the list only if no active jobs
        /// are configured to use it, set this value to false.
        /// </para>
        /// </summary>
        public string IgnoreJobChecks { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreJobChecks property is set.
        /// </summary>
        internal bool IsSetIgnoreJobChecks() => this.IgnoreJobChecks != null;
    }
}

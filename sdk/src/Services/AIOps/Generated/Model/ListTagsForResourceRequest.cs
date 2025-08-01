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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
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
namespace Amazon.AIOps.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Displays the tags associated with a CloudWatch investigations resource. Currently,
    /// investigation groups support tagging.
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonAIOpsRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the CloudWatch investigations resource that you want to view tags for.
        /// You can use the <c>ListInvestigationGroups</c> operation to find the ARNs of investigation
        /// groups.
        /// </para>
        ///  
        /// <para>
        /// The ARN format for an investigation group is <c>arn:aws:aiops:<i>Region</i>:<i>account-id</i>:investigation-group:<i>investigation-group-id</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}
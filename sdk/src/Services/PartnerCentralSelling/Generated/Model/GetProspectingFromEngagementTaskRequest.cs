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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the GetProspectingFromEngagementTask operation.
    /// Retrieves the details and current status of a prospecting task previously started
    /// with <c>StartProspectingFromEngagementTask</c> to enable polling for completion and
    /// access to per-engagement processing results.
    /// </summary>
    public partial class GetProspectingFromEngagementTaskRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _taskIdentifier;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog associated with the task. Specify <c>AWS</c> for production
        /// environments and <c>Sandbox</c> for testing and development purposes. The value must
        /// match the catalog used when the task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property TaskIdentifier. 
        /// <para>
        /// The unique identifier of the prospecting task to retrieve. This value is returned
        /// in the <c>TaskId</c> field of the <c>StartProspectingFromEngagementTask</c> response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskIdentifier
        {
            get { return this._taskIdentifier; }
            set { this._taskIdentifier = value; }
        }

        // Check to see if TaskIdentifier property is set
        internal bool IsSetTaskIdentifier()
        {
            return this._taskIdentifier != null;
        }

    }
}
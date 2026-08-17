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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateResponsibilityTransfer operation.
    /// Ends a transfer. A <i>transfer</i> is an arrangement between two management accounts
    /// where one account designates the other with specified responsibilities for their organization.
    /// 
    ///  
    /// <para>
    /// When a transfer ends, Organizations publishes a <c>ResponsibilityTransferTerminated</c>
    /// service event to CloudTrail. Each affected account receives this event, including
    /// upstream participants such as distributors in a chained transfer. For an example log
    /// entry, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_cloudtrail-integration.html#Log-entries-terminate-responsibility-transfer">Example
    /// log entries: TerminateResponsibilityTransfer</a> in the <i>Organizations User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TerminateResponsibilityTransferRequest : AmazonOrganizationsRequest
    {
        private DateTime? _endTimestamp;
        private string _id;

        /// <summary>
        /// Gets and sets the property EndTimestamp. 
        /// <para>
        /// Timestamp when the responsibility transfer is to end.
        /// </para>
        /// </summary>
        public DateTime? EndTimestamp
        {
            get { return this._endTimestamp; }
            set { this._endTimestamp = value; }
        }

        // Check to see if EndTimestamp property is set
        internal bool IsSetEndTimestamp()
        {
            return this._endTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the transfer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}
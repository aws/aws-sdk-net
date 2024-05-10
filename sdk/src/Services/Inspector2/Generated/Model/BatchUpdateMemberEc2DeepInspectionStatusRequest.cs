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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateMemberEc2DeepInspectionStatus operation.
    /// Activates or deactivates Amazon Inspector deep inspection for the provided member
    /// accounts in your organization. You must be the delegated administrator of an organization
    /// in Amazon Inspector to use this API.
    /// </summary>
    public partial class BatchUpdateMemberEc2DeepInspectionStatusRequest : AmazonInspector2Request
    {
        private List<MemberAccountEc2DeepInspectionStatus> _accountIds = AWSConfigs.InitializeCollections ? new List<MemberAccountEc2DeepInspectionStatus>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The unique identifiers for the Amazon Web Services accounts to change Amazon Inspector
        /// deep inspection status for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<MemberAccountEc2DeepInspectionStatus> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
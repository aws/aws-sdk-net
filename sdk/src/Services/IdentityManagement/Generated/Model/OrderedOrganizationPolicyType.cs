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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Represents one level of an Organizations hierarchy—the organization root, an organizational
    /// unit (OU), or an account—together with the service control policies (SCPs) that apply
    /// at that level. Each element in the list represents one level of the hierarchy, ordered
    /// from the organization root down to the account.
    /// 
    ///  
    /// <para>
    /// For more information about SCPs, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_scps.html">Service
    /// control policies (SCPs)</a> in the <i>Organizations User Guide</i>.
    /// </para>
    /// </summary>
    public partial class OrderedOrganizationPolicyType
    {
        private List<string> _serviceControlPolicyInputList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ServiceControlPolicyInputList. 
        /// <para>
        /// A list of SCP documents that apply at this level of the Organizations hierarchy. Each
        /// document is specified as a string containing the complete, valid JSON text of an SCP.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceControlPolicyInputList
        {
            get { return this._serviceControlPolicyInputList; }
            set { this._serviceControlPolicyInputList = value; }
        }

        // Check to see if ServiceControlPolicyInputList property is set
        internal bool IsSetServiceControlPolicyInputList()
        {
            return this._serviceControlPolicyInputList != null && (this._serviceControlPolicyInputList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
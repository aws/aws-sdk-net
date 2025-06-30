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
    /// The reason that the service-linked role deletion failed.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLinkedRoleDeletionStatus.html">GetServiceLinkedRoleDeletionStatus</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DeletionTaskFailureReasonType
    {
        private string _reason;
        private List<RoleUsageType> _roleUsageList = AWSConfigs.InitializeCollections ? new List<RoleUsageType>() : null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short description of the reason that the service-linked role deletion failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RoleUsageList. 
        /// <para>
        /// A list of objects that contains details about the service-linked role deletion failure,
        /// if that information is returned by the service. If the service-linked role has active
        /// sessions or if any resources that were used by the role have not been deleted from
        /// the linked service, the role can't be deleted. This parameter includes a list of the
        /// resources that are associated with the role and the Region in which the resources
        /// are being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoleUsageType> RoleUsageList
        {
            get { return this._roleUsageList; }
            set { this._roleUsageList = value; }
        }

        // Check to see if RoleUsageList property is set
        internal bool IsSetRoleUsageList()
        {
            return this._roleUsageList != null && (this._roleUsageList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
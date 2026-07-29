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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Filter criteria for listing security requirement packs.
    /// </summary>
    public partial class ListSecurityRequirementPackFilter
    {
        private ManagementType _managementType;
        private SecurityRequirementPackStatus _status;

        /// <summary>
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// Filter packs by management type. Valid values are AWS_MANAGED and CUSTOMER_MANAGED.
        /// </para>
        /// </summary>
        public ManagementType ManagementType
        {
            get { return this._managementType; }
            set { this._managementType = value; }
        }

        // Check to see if ManagementType property is set
        internal bool IsSetManagementType()
        {
            return this._managementType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter packs by status. Valid values are ENABLED and DISABLED.
        /// </para>
        /// </summary>
        public SecurityRequirementPackStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about Amazon Web Services Fargate details associated with an
    /// Amazon ECS cluster.
    /// </summary>
    public partial class FargateDetails
    {
        private List<string> _issues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManagementType _managementType;

        /// <summary>
        /// Gets and sets the property Issues. 
        /// <para>
        /// Runtime coverage issues identified for the resource running on Amazon Web Services
        /// Fargate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Issues
        {
            get { return this._issues; }
            set { this._issues = value; }
        }

        // Check to see if Issues property is set
        internal bool IsSetIssues()
        {
            return this._issues != null && (this._issues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// Indicates how the GuardDuty security agent is managed for this resource.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO_MANAGED</c> indicates that GuardDuty deploys and manages updates for this
        /// resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> indicates that the deployment of the GuardDuty security agent is
        /// disabled for this resource.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>MANUAL</c> status doesn't apply to the Amazon Web Services Fargate (Amazon
        /// ECS only) woprkloads.
        /// </para>
        ///  </note>
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

    }
}
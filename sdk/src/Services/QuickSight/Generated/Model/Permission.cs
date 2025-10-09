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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains the permission information for one principal against one
    /// flow.
    /// </summary>
    public partial class Permission
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _principal;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions that the principal can perform against the flow.
        /// </para>
        ///  
        /// <para>
        /// The following are the list of values to set a principal as a flow owner:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// quicksight:PublishFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:GetFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:UpdateFlowPermissions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:GetFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:StartFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:StopFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:UpdateFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:UnpublishFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:GetFlowStages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:DeleteFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:DescribeFlowPermissions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:UpdateFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:CreatePresignedUrl
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the list of values to set a principal as a flow viewer:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// quicksight:GetFlow
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:UpdateFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:StartFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:StopFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:GetFlowSession
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:CreatePresignedUrl
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// quicksight:GetFlowStages
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the principal. This can be an Amazon QuickSight
        /// user, group or namespace associated with the flow. Namespace principal can only be
        /// set as a viewer and will grant everyone in the same namespace viewer permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

    }
}
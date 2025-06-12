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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a <c>DeleteDeploymentGroup</c> operation.
    /// </summary>
    public partial class DeleteDeploymentGroupResponse : AmazonWebServiceResponse
    {
        private List<AutoScalingGroup> _hooksNotCleanedUp = AWSConfigs.InitializeCollections ? new List<AutoScalingGroup>() : null;

        /// <summary>
        /// Gets and sets the property HooksNotCleanedUp. 
        /// <para>
        /// If the output contains no data, and the corresponding deployment group contained at
        /// least one Auto Scaling group, CodeDeploy successfully removed all corresponding Auto
        /// Scaling lifecycle event hooks from the Amazon EC2 instances in the Auto Scaling group.
        /// If the output contains data, CodeDeploy could not remove some Auto Scaling lifecycle
        /// event hooks from the Amazon EC2 instances in the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingGroup> HooksNotCleanedUp
        {
            get { return this._hooksNotCleanedUp; }
            set { this._hooksNotCleanedUp = value; }
        }

        // Check to see if HooksNotCleanedUp property is set
        internal bool IsSetHooksNotCleanedUp()
        {
            return this._hooksNotCleanedUp != null && (this._hooksNotCleanedUp.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
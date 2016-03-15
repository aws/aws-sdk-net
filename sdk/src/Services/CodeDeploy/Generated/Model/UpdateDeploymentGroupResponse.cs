/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of an update deployment group operation.
    /// </summary>
    public partial class UpdateDeploymentGroupResponse : AmazonWebServiceResponse
    {
        private List<AutoScalingGroup> _hooksNotCleanedUp = new List<AutoScalingGroup>();

        /// <summary>
        /// Gets and sets the property HooksNotCleanedUp. 
        /// <para>
        /// If the output contains no data, and the corresponding deployment group contained at
        /// least one Auto Scaling group, AWS CodeDeploy successfully removed all corresponding
        /// Auto Scaling lifecycle event hooks from the AWS account. If the output contains data,
        /// AWS CodeDeploy could not remove some Auto Scaling lifecycle event hooks from the AWS
        /// account.
        /// </para>
        /// </summary>
        public List<AutoScalingGroup> HooksNotCleanedUp
        {
            get { return this._hooksNotCleanedUp; }
            set { this._hooksNotCleanedUp = value; }
        }

        // Check to see if HooksNotCleanedUp property is set
        internal bool IsSetHooksNotCleanedUp()
        {
            return this._hooksNotCleanedUp != null && this._hooksNotCleanedUp.Count > 0; 
        }

    }
}
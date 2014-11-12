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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Configuration for accessing Amazon StopDeployment service
    /// </summary>
    public partial class StopDeploymentResponse : StopDeploymentResult
    {
        /// <summary>
        /// Gets and sets the StopDeploymentResult property.
        /// Represents the output of a StopDeployment operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the StopDeploymentResult class are now available on the StopDeploymentResponse class. You should use the properties on StopDeploymentResponse instead of accessing them through StopDeploymentResult.")]
        public StopDeploymentResult StopDeploymentResult
        {
            get
            {
                return this;
            }
        }
    }
}
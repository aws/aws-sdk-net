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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBlueGreenDeployment operation. Deletes a
    /// blue/green deployment. <para> For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
    /// User Guide</i>. </para>
    /// </summary>
    public partial class DeleteBlueGreenDeploymentRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentIdentifier. 
        /// <para>
        /// The unique identifier of the blue/green deployment to delete. This parameter isn't
        /// case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match an existing blue/green deployment identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BlueGreenDeploymentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the BlueGreenDeploymentIdentifier property is set.
        /// </summary>
        internal bool IsSetBlueGreenDeploymentIdentifier() => this.BlueGreenDeploymentIdentifier != null;

        /// <summary>
        /// Gets and sets the property DeleteTarget. 
        /// <para>
        /// Specifies whether to delete the resources in the green environment. You can't specify
        /// this option if the blue/green deployment <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_BlueGreenDeployment.html">status</a>
        /// is <c>SWITCHOVER_COMPLETED</c>.
        /// </para>
        /// </summary>
        public bool? DeleteTarget { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTarget property is set.
        /// </summary>
        internal bool IsSetDeleteTarget() => this.DeleteTarget.HasValue;
    }
}

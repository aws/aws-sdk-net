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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVpcConnector operation.
    /// Delete an App Runner VPC connector resource. You can't delete a connector that's used
    /// by one or more App Runner services.
    /// </summary>
    public partial class DeleteVpcConnectorRequest : AmazonAppRunnerRequest
    {
        private string _vpcConnectorArn;

        /// <summary>
        /// Gets and sets the property VpcConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner VPC connector that you want to delete.
        /// </para>
        ///  
        /// <para>
        /// The ARN must be a full VPC connector ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string VpcConnectorArn
        {
            get { return this._vpcConnectorArn; }
            set { this._vpcConnectorArn = value; }
        }

        // Check to see if VpcConnectorArn property is set
        internal bool IsSetVpcConnectorArn()
        {
            return this._vpcConnectorArn != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes an CloudHSM resource policy. Deleting a resource policy will result in the
    /// resource being unshared and removed from any RAM resource shares. Deleting the resource
    /// policy attached to a backup will not impact any clusters created from that backup.
    /// 
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
    /// in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonCloudHSMV2Request
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource from which the policy will be removed.
        /// 
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}
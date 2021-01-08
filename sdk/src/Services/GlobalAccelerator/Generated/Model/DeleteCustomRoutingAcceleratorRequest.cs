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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCustomRoutingAccelerator operation.
    /// Delete a custom routing accelerator. Before you can delete an accelerator, you must
    /// disable it and remove all dependent resources (listeners and endpoint groups). To
    /// disable the accelerator, update the accelerator to set <code>Enabled</code> to false.
    /// 
    ///  <important> 
    /// <para>
    /// When you create a custom routing accelerator, by default, Global Accelerator provides
    /// you with a set of two static IP addresses. 
    /// </para>
    ///  
    /// <para>
    /// The IP addresses are assigned to your accelerator for as long as it exists, even if
    /// you disable the accelerator and it no longer accepts or routes traffic. However, when
    /// you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
    /// to the accelerator, so you can no longer route traffic by using them. As a best practice,
    /// ensure that you have permissions in place to avoid inadvertently deleting accelerators.
    /// You can use IAM policies with Global Accelerator to limit the users who have permissions
    /// to delete an accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/auth-and-access-control.html">Authentication
    /// and Access Control</a> in the <i>AWS Global Accelerator Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteCustomRoutingAcceleratorRequest : AmazonGlobalAcceleratorRequest
    {
        private string _acceleratorArn;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom routing accelerator to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteActivation operation.
    /// Deletes an activation. You aren't required to delete an activation. If you delete
    /// an activation, you can no longer use it to register additional managed nodes. Deleting
    /// an activation doesn't de-register managed nodes. You must manually de-register managed
    /// nodes.
    /// </summary>
    public partial class DeleteActivationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _activationId;

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// The ID of the activation that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActivationId
        {
            get { return this._activationId; }
            set { this._activationId = value; }
        }

        // Check to see if ActivationId property is set
        internal bool IsSetActivationId()
        {
            return this._activationId != null;
        }

    }
}
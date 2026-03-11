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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the DeleteCapability operation.
    /// </summary>
    public partial class DeleteCapabilityResponse : AmazonWebServiceResponse
    {
        private Capability _capability;

        /// <summary>
        /// Gets and sets the property Capability. 
        /// <para>
        /// An object containing information about the deleted capability, including its final
        /// status and configuration.
        /// </para>
        /// </summary>
        public Capability Capability
        {
            get { return this._capability; }
            set { this._capability = value; }
        }

        // Check to see if Capability property is set
        internal bool IsSetCapability()
        {
            return this._capability != null;
        }

    }
}
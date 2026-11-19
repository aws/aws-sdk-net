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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetImageBlockPublicAccessState operation.
    /// </summary>
    public partial class GetImageBlockPublicAccessStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageBlockPublicAccessState. 
        /// <para>
        /// The current state of block public access for AMIs at the account level in the specified
        /// Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>block-new-sharing</c> - Any attempt to publicly share your AMIs in the specified
        /// Region is blocked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unblocked</c> - Your AMIs in the specified Region can be publicly shared.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ImageBlockPublicAccessState { get; set; }

        /// <summary>
        /// Checks to see if the ImageBlockPublicAccessState property is set.
        /// </summary>
        internal bool IsSetImageBlockPublicAccessState() => this.ImageBlockPublicAccessState != null;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the state for block public access for AMIs. Possible values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The state is managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The state is managed by a declarative policy and can't
        /// be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;
    }
}

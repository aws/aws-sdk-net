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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetImageBlockPublicAccessState operation.
    /// </summary>
    public partial class GetImageBlockPublicAccessStateResponse : AmazonWebServiceResponse
    {
        private string _imageBlockPublicAccessState;

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
        ///  <code>block-new-sharing</code> - Any attempt to publicly share your AMIs in the specified
        /// Region is blocked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unblocked</code> - Your AMIs in the specified Region can be publicly shared.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ImageBlockPublicAccessState
        {
            get { return this._imageBlockPublicAccessState; }
            set { this._imageBlockPublicAccessState = value; }
        }

        // Check to see if ImageBlockPublicAccessState property is set
        internal bool IsSetImageBlockPublicAccessState()
        {
            return this._imageBlockPublicAccessState != null;
        }

    }
}
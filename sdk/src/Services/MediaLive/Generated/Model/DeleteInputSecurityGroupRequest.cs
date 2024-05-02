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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInputSecurityGroup operation.
    /// Deletes an Input Security Group
    /// </summary>
    public partial class DeleteInputSecurityGroupRequest : AmazonMediaLiveRequest
    {
        private string _inputSecurityGroupId;

        /// <summary>
        /// Gets and sets the property InputSecurityGroupId. The Input Security Group to delete
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputSecurityGroupId
        {
            get { return this._inputSecurityGroupId; }
            set { this._inputSecurityGroupId = value; }
        }

        // Check to see if InputSecurityGroupId property is set
        internal bool IsSetInputSecurityGroupId()
        {
            return this._inputSecurityGroupId != null;
        }

    }
}
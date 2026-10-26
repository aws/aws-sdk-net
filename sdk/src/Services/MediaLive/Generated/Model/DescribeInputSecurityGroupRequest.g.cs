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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInputSecurityGroup operation. Produces
    /// a summary of an Input Security Group
    /// </summary>
    public partial class DescribeInputSecurityGroupRequest : AmazonMediaLiveRequest
    {
        /// <summary>
        /// Gets and sets the property InputSecurityGroupId. The id of the Input Security Group
        /// to describe
        /// </summary>
        [AWSProperty(Required = true)]
        public string InputSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InputSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetInputSecurityGroupId() => this.InputSecurityGroupId != null;
    }
}

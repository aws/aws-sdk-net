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

namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Information about the Amazon Q Developer in chat applications topics or Amazon Q Developer
    /// in chat applications clients associated with a notification rule.
    /// </summary>
    public partial class Target
    {
        /// <summary>
        /// Gets and sets the property TargetAddress. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Developer in chat applications topic
        /// or Amazon Q Developer in chat applications client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 320)]
        public string TargetAddress { get; set; }

        /// <summary>
        /// Checks to see if the TargetAddress property is set.
        /// </summary>
        internal bool IsSetTargetAddress() => this.TargetAddress != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type. Can be an Amazon Q Developer in chat applications topic or Amazon
        /// Q Developer in chat applications client.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Q Developer in chat applications topics are specified as <c>SNS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Q Developer in chat applications clients are specified as <c>AWSChatbotSlack</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}

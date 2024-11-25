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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePublisher operation.
    /// Returns information about a CloudFormation extension publisher.
    /// 
    ///  
    /// <para>
    /// If you don't supply a <c>PublisherId</c>, and you have registered as an extension
    /// publisher, <c>DescribePublisher</c> returns information about your own publisher account.
    /// </para>
    ///  
    /// <para>
    /// For more information about registering as a publisher, see:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterPublisher.html">RegisterPublisher</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/publish-extension.html">Publishing
    /// extensions to make them available for public use</a> in the <i>CloudFormation Command
    /// Line Interface (CLI) User Guide</i> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribePublisherRequest : AmazonCloudFormationRequest
    {
        private string _publisherId;

        /// <summary>
        /// Gets and sets the property PublisherId. 
        /// <para>
        /// The ID of the extension publisher.
        /// </para>
        ///  
        /// <para>
        /// If you don't supply a <c>PublisherId</c>, and you have registered as an extension
        /// publisher, <c>DescribePublisher</c> returns information about your own publisher account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string PublisherId
        {
            get { return this._publisherId; }
            set { this._publisherId = value; }
        }

        // Check to see if PublisherId property is set
        internal bool IsSetPublisherId()
        {
            return this._publisherId != null;
        }

    }
}
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

namespace Amazon.MPA.Model
{
    /// <summary>
    /// IAM Identity Center credentials. For more information see, <a href="http://aws.amazon.com/identity-center/">IAM
    /// Identity Center</a> .
    /// </summary>
    public partial class IamIdentityCenter
    {
        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Amazon Web Services Region where the IAM Identity Center instance is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}

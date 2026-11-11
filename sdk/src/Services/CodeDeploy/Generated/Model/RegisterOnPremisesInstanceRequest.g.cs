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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterOnPremisesInstance operation. Registers
    /// an on-premises instance. <note> <para> Only one IAM ARN (an IAM session ARN or IAM
    /// user ARN) is supported in the request. You cannot use both. </para> </note>
    /// </summary>
    public partial class RegisterOnPremisesInstanceRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property IamSessionArn. 
        /// <para>
        /// The ARN of the IAM session to associate with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the IamSessionArn property is set.
        /// </summary>
        internal bool IsSetIamSessionArn() => this.IamSessionArn != null;

        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The ARN of the user to associate with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamUserArn { get; set; }

        /// <summary>
        /// Checks to see if the IamUserArn property is set.
        /// </summary>
        internal bool IsSetIamUserArn() => this.IamUserArn != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the on-premises instance to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;
    }
}

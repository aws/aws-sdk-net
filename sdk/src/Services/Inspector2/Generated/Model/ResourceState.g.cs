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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details the state of Amazon Inspector for each resource type Amazon Inspector scans.
    /// </summary>
    public partial class ResourceState
    {
        /// <summary>
        /// Gets and sets the property Ami.
        /// </summary>
        public State Ami { get; set; }

        /// <summary>
        /// Checks to see if the Ami property is set.
        /// </summary>
        internal bool IsSetAmi() => this.Ami != null;

        /// <summary>
        /// Gets and sets the property CodeRepository.
        /// </summary>
        public State CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository != null;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// An object detailing the state of Amazon Inspector scanning for Amazon EC2 resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public State Ec2 { get; set; }

        /// <summary>
        /// Checks to see if the Ec2 property is set.
        /// </summary>
        internal bool IsSetEc2() => this.Ec2 != null;

        /// <summary>
        /// Gets and sets the property Ecr. 
        /// <para>
        /// An object detailing the state of Amazon Inspector scanning for Amazon ECR resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public State Ecr { get; set; }

        /// <summary>
        /// Checks to see if the Ecr property is set.
        /// </summary>
        internal bool IsSetEcr() => this.Ecr != null;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// An object that described the state of Amazon Inspector scans for an account.
        /// </para>
        /// </summary>
        public State Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda != null;

        /// <summary>
        /// Gets and sets the property LambdaCode. 
        /// <para>
        /// An object that described the state of Amazon Inspector scans for an account.
        /// </para>
        /// </summary>
        public State LambdaCode { get; set; }

        /// <summary>
        /// Checks to see if the LambdaCode property is set.
        /// </summary>
        internal bool IsSetLambdaCode() => this.LambdaCode != null;
    }
}

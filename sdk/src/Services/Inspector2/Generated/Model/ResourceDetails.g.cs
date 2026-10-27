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
    /// Contains details about the resource involved in the finding.
    /// </summary>
    public partial class ResourceDetails
    {
        /// <summary>
        /// Gets and sets the property AwsEc2Instance. 
        /// <para>
        /// An object that contains details about the Amazon EC2 instance involved in the finding.
        /// </para>
        /// </summary>
        public AwsEc2InstanceDetails AwsEc2Instance { get; set; }

        /// <summary>
        /// Checks to see if the AwsEc2Instance property is set.
        /// </summary>
        internal bool IsSetAwsEc2Instance() => this.AwsEc2Instance != null;

        /// <summary>
        /// Gets and sets the property AwsEcrContainerImage. 
        /// <para>
        /// An object that contains details about the Amazon ECR container image involved in the
        /// finding.
        /// </para>
        /// </summary>
        public AwsEcrContainerImageDetails AwsEcrContainerImage { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcrContainerImage property is set.
        /// </summary>
        internal bool IsSetAwsEcrContainerImage() => this.AwsEcrContainerImage != null;

        /// <summary>
        /// Gets and sets the property AwsLambdaFunction. 
        /// <para>
        /// A summary of the information about an Amazon Web Services Lambda function affected
        /// by a finding.
        /// </para>
        /// </summary>
        public AwsLambdaFunctionDetails AwsLambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the AwsLambdaFunction property is set.
        /// </summary>
        internal bool IsSetAwsLambdaFunction() => this.AwsLambdaFunction != null;

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// Contains details about a code repository resource associated with a finding.
        /// </para>
        /// </summary>
        public CodeRepositoryDetails CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// An object that contains details about a container image involved in the finding.
        /// </para>
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ServerlessFunction. 
        /// <para>
        /// An object that contains details about a serverless function involved in the finding.
        /// </para>
        /// </summary>
        public ServerlessFunction ServerlessFunction { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessFunction property is set.
        /// </summary>
        internal bool IsSetServerlessFunction() => this.ServerlessFunction != null;

        /// <summary>
        /// Gets and sets the property Vm. 
        /// <para>
        /// An object that contains details about a VM instance involved in the finding.
        /// </para>
        /// </summary>
        public Vm Vm { get; set; }

        /// <summary>
        /// Checks to see if the Vm property is set.
        /// </summary>
        internal bool IsSetVm() => this.Vm != null;
    }
}

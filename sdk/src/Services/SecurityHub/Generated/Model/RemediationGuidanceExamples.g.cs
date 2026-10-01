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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provided remediation guidance examples in different formats that can be run for remediating
    /// the target.
    /// </summary>
    public partial class RemediationGuidanceExamples
    {
        /// <summary>
        /// Gets and sets the property AwsCli. 
        /// <para>
        /// An AWS CLI snippet version of the example.
        /// </para>
        /// </summary>
        public string AwsCli { get; set; }

        /// <summary>
        /// Checks to see if the AwsCli property is set.
        /// </summary>
        internal bool IsSetAwsCli() => this.AwsCli != null;

        /// <summary>
        /// Gets and sets the property Cdk. 
        /// <para>
        /// A CDK snippet version of the example.
        /// </para>
        /// </summary>
        public string Cdk { get; set; }

        /// <summary>
        /// Checks to see if the Cdk property is set.
        /// </summary>
        internal bool IsSetCdk() => this.Cdk != null;

        /// <summary>
        /// Gets and sets the property Cli. 
        /// <para>
        /// A CLI snippet version of the example.
        /// </para>
        /// </summary>
        public string Cli { get; set; }

        /// <summary>
        /// Checks to see if the Cli property is set.
        /// </summary>
        internal bool IsSetCli() => this.Cli != null;

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        /// A CloudFormation snippet version of the example.
        /// </para>
        /// </summary>
        public string CloudFormation { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormation property is set.
        /// </summary>
        internal bool IsSetCloudFormation() => this.CloudFormation != null;

        /// <summary>
        /// Gets and sets the property IaC. 
        /// <para>
        /// An IaC snippet version of the example.
        /// </para>
        /// </summary>
        public string IaC { get; set; }

        /// <summary>
        /// Checks to see if the IaC property is set.
        /// </summary>
        internal bool IsSetIaC() => this.IaC != null;

        /// <summary>
        /// Gets and sets the property Python. 
        /// <para>
        /// A Python snippet version of the example.
        /// </para>
        /// </summary>
        public string Python { get; set; }

        /// <summary>
        /// Checks to see if the Python property is set.
        /// </summary>
        internal bool IsSetPython() => this.Python != null;

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// A Template snippet version of the example.
        /// </para>
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Checks to see if the Template property is set.
        /// </summary>
        internal bool IsSetTemplate() => this.Template != null;

        /// <summary>
        /// Gets and sets the property Terraform. 
        /// <para>
        /// A Terraform snippet version of the example.
        /// </para>
        /// </summary>
        public string Terraform { get; set; }

        /// <summary>
        /// Checks to see if the Terraform property is set.
        /// </summary>
        internal bool IsSetTerraform() => this.Terraform != null;
    }
}

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
    /// This is the response object from the GetConfiguration operation.
    /// </summary>
    public partial class GetConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AmiConfiguration. 
        /// <para>
        /// The current state of the Amazon Machine Image (AMI) scan configuration for the account.
        /// </para>
        /// </summary>
        public AmiConfigurationState AmiConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmiConfiguration property is set.
        /// </summary>
        internal bool IsSetAmiConfiguration() => this.AmiConfiguration != null;

        /// <summary>
        /// Gets and sets the property Ec2Configuration. 
        /// <para>
        /// Specifies how the Amazon EC2 automated scan mode is currently configured for your
        /// environment.
        /// </para>
        /// </summary>
        public Ec2ConfigurationState Ec2Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Ec2Configuration property is set.
        /// </summary>
        internal bool IsSetEc2Configuration() => this.Ec2Configuration != null;

        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Specifies how the ECR automated re-scan duration is currently configured for your
        /// environment.
        /// </para>
        /// </summary>
        public EcrConfigurationState EcrConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EcrConfiguration property is set.
        /// </summary>
        internal bool IsSetEcrConfiguration() => this.EcrConfiguration != null;
    }
}

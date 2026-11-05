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
    /// Represents which scan types are automatically enabled for new members of your Amazon
    /// Inspector organization.
    /// </summary>
    public partial class AutoEnable
    {
        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// Represents whether Amazon Machine Image (AMI) scans are automatically enabled for
        /// new members of your Amazon Inspector organization.
        /// </para>
        /// </summary>
        public bool? Ami { get; set; }

        /// <summary>
        /// Checks to see if the Ami property is set.
        /// </summary>
        internal bool IsSetAmi() => this.Ami.HasValue;

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// Represents whether code repository scans are automatically enabled for new members
        /// of your Amazon Inspector organization.
        /// </para>
        /// </summary>
        public bool? CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository.HasValue;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// Represents whether Amazon EC2 scans are automatically enabled for new members of your
        /// Amazon Inspector organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Ec2 { get; set; }

        /// <summary>
        /// Checks to see if the Ec2 property is set.
        /// </summary>
        internal bool IsSetEc2() => this.Ec2.HasValue;

        /// <summary>
        /// Gets and sets the property Ecr. 
        /// <para>
        /// Represents whether Amazon ECR scans are automatically enabled for new members of your
        /// Amazon Inspector organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Ecr { get; set; }

        /// <summary>
        /// Checks to see if the Ecr property is set.
        /// </summary>
        internal bool IsSetEcr() => this.Ecr.HasValue;

        /// <summary>
        /// Gets and sets the property Lambda. 
        /// <para>
        /// Represents whether Amazon Web Services Lambda standard scans are automatically enabled
        /// for new members of your Amazon Inspector organization. 
        /// </para>
        /// </summary>
        public bool? Lambda { get; set; }

        /// <summary>
        /// Checks to see if the Lambda property is set.
        /// </summary>
        internal bool IsSetLambda() => this.Lambda.HasValue;

        /// <summary>
        /// Gets and sets the property LambdaCode. 
        /// <para>
        /// Represents whether Lambda code scans are automatically enabled for new members of
        /// your Amazon Inspector organization. 
        /// </para>
        /// </summary>
        public bool? LambdaCode { get; set; }

        /// <summary>
        /// Checks to see if the LambdaCode property is set.
        /// </summary>
        internal bool IsSetLambdaCode() => this.LambdaCode.HasValue;
    }
}

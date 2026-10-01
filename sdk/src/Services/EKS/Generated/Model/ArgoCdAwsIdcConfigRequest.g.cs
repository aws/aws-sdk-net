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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Configuration for integrating Argo CD with IAM Identity CenterIAM; Identity Center.
    /// This allows you to use your organization's identity provider for authentication to
    /// Argo CD.
    /// </summary>
    public partial class ArgoCdAwsIdcConfigRequest
    {
        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity CenterIAM; Identity Center instance
        /// to use for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdcRegion. 
        /// <para>
        /// The Region where your IAM Identity CenterIAM; Identity Center instance is located.
        /// </para>
        /// </summary>
        public string IdcRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdcRegion property is set.
        /// </summary>
        internal bool IsSetIdcRegion() => this.IdcRegion != null;
    }
}

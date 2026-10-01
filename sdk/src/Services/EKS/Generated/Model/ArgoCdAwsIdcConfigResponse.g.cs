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
    /// The response object containing IAM Identity CenterIAM; Identity Center configuration
    /// details for an Argo CD capability.
    /// </summary>
    public partial class ArgoCdAwsIdcConfigResponse
    {
        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity CenterIAM; Identity Center instance
        /// used for authentication.
        /// </para>
        /// </summary>
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdcManagedApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the managed application created in IAM Identity
        /// CenterIAM; Identity Center for this Argo CD capability. This application is automatically
        /// created and managed by Amazon EKS.
        /// </para>
        /// </summary>
        public string IdcManagedApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcManagedApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdcManagedApplicationArn() => this.IdcManagedApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IdcRegion. 
        /// <para>
        /// The Region where the IAM Identity CenterIAM; Identity Center instance is located.
        /// </para>
        /// </summary>
        public string IdcRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdcRegion property is set.
        /// </summary>
        internal bool IsSetIdcRegion() => this.IdcRegion != null;
    }
}

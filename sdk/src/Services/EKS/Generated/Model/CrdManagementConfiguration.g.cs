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
    /// Indicates the current configuration of Gateway API custom resource definition (CRD)
    /// management on your EKS Auto Mode cluster. For example, if CRD management is enabled
    /// or disabled. For more information, see EKS Auto Mode load balancing capability in
    /// the <i>Amazon EKS User Guide</i>.
    /// </summary>
    public partial class CrdManagementConfiguration
    {
        /// <summary>
        /// Gets and sets the property Managed. 
        /// <para>
        /// Indicates if Gateway API CRD management is enabled on your EKS Auto Mode cluster.
        /// If CRD management is enabled, EKS Auto Mode will create and update the Gateway API
        /// CRDs in your EKS Auto Mode cluster.
        /// </para>
        /// </summary>
        public bool? Managed { get; set; }

        /// <summary>
        /// Checks to see if the Managed property is set.
        /// </summary>
        internal bool IsSetManaged() => this.Managed.HasValue;
    }
}

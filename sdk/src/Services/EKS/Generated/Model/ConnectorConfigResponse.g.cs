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
    /// The full description of your connected cluster.
    /// </summary>
    public partial class ConnectorConfigResponse
    {
        /// <summary>
        /// Gets and sets the property ActivationCode. 
        /// <para>
        /// A unique code associated with the cluster for registration purposes.
        /// </para>
        /// </summary>
        public string ActivationCode { get; set; }

        /// <summary>
        /// Checks to see if the ActivationCode property is set.
        /// </summary>
        internal bool IsSetActivationCode() => this.ActivationCode != null;

        /// <summary>
        /// Gets and sets the property ActivationExpiry. 
        /// <para>
        /// The expiration time of the connected cluster. The cluster's YAML file must be applied
        /// through the native provider.
        /// </para>
        /// </summary>
        public DateTime? ActivationExpiry { get; set; }

        /// <summary>
        /// Checks to see if the ActivationExpiry property is set.
        /// </summary>
        internal bool IsSetActivationExpiry() => this.ActivationExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property ActivationId. 
        /// <para>
        /// A unique ID associated with the cluster for registration purposes.
        /// </para>
        /// </summary>
        public string ActivationId { get; set; }

        /// <summary>
        /// Checks to see if the ActivationId property is set.
        /// </summary>
        internal bool IsSetActivationId() => this.ActivationId != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The cluster's cloud service provider.
        /// </para>
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to communicate with services from the connected
        /// Kubernetes cluster.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}

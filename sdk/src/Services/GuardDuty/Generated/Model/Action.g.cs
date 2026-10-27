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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about actions.
    /// </summary>
    public partial class Action
    {
        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The GuardDuty finding activity type.
        /// </para>
        /// </summary>
        public string ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property AwsApiCallAction. 
        /// <para>
        /// Information about the AWS_API_CALL action described in this finding.
        /// </para>
        /// </summary>
        public AwsApiCallAction AwsApiCallAction { get; set; }

        /// <summary>
        /// Checks to see if the AwsApiCallAction property is set.
        /// </summary>
        internal bool IsSetAwsApiCallAction() => this.AwsApiCallAction != null;

        /// <summary>
        /// Gets and sets the property DnsRequestAction. 
        /// <para>
        /// Information about the DNS_REQUEST action described in this finding.
        /// </para>
        /// </summary>
        public DnsRequestAction DnsRequestAction { get; set; }

        /// <summary>
        /// Checks to see if the DnsRequestAction property is set.
        /// </summary>
        internal bool IsSetDnsRequestAction() => this.DnsRequestAction != null;

        /// <summary>
        /// Gets and sets the property KubernetesApiCallAction. 
        /// <para>
        /// Information about the Kubernetes API call action described in this finding.
        /// </para>
        /// </summary>
        public KubernetesApiCallAction KubernetesApiCallAction { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesApiCallAction property is set.
        /// </summary>
        internal bool IsSetKubernetesApiCallAction() => this.KubernetesApiCallAction != null;

        /// <summary>
        /// Gets and sets the property KubernetesPermissionCheckedDetails. 
        /// <para>
        /// Information whether the user has the permission to use a specific Kubernetes API.
        /// </para>
        /// </summary>
        public KubernetesPermissionCheckedDetails KubernetesPermissionCheckedDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesPermissionCheckedDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesPermissionCheckedDetails() => this.KubernetesPermissionCheckedDetails != null;

        /// <summary>
        /// Gets and sets the property KubernetesRoleBindingDetails. 
        /// <para>
        /// Information about the role binding that grants the permission defined in a Kubernetes
        /// role.
        /// </para>
        /// </summary>
        public KubernetesRoleBindingDetails KubernetesRoleBindingDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesRoleBindingDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesRoleBindingDetails() => this.KubernetesRoleBindingDetails != null;

        /// <summary>
        /// Gets and sets the property KubernetesRoleDetails. 
        /// <para>
        /// Information about the Kubernetes role name and role type.
        /// </para>
        /// </summary>
        public KubernetesRoleDetails KubernetesRoleDetails { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesRoleDetails property is set.
        /// </summary>
        internal bool IsSetKubernetesRoleDetails() => this.KubernetesRoleDetails != null;

        /// <summary>
        /// Gets and sets the property NetworkConnectionAction. 
        /// <para>
        /// Information about the NETWORK_CONNECTION action described in this finding.
        /// </para>
        /// </summary>
        public NetworkConnectionAction NetworkConnectionAction { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConnectionAction property is set.
        /// </summary>
        internal bool IsSetNetworkConnectionAction() => this.NetworkConnectionAction != null;

        /// <summary>
        /// Gets and sets the property PortProbeAction. 
        /// <para>
        /// Information about the PORT_PROBE action described in this finding.
        /// </para>
        /// </summary>
        public PortProbeAction PortProbeAction { get; set; }

        /// <summary>
        /// Checks to see if the PortProbeAction property is set.
        /// </summary>
        internal bool IsSetPortProbeAction() => this.PortProbeAction != null;

        /// <summary>
        /// Gets and sets the property RdsLoginAttemptAction. 
        /// <para>
        /// Information about <c>RDS_LOGIN_ATTEMPT</c> action described in this finding.
        /// </para>
        /// </summary>
        public RdsLoginAttemptAction RdsLoginAttemptAction { get; set; }

        /// <summary>
        /// Checks to see if the RdsLoginAttemptAction property is set.
        /// </summary>
        internal bool IsSetRdsLoginAttemptAction() => this.RdsLoginAttemptAction != null;
    }
}

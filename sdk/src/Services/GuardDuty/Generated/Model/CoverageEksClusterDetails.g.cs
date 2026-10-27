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
    /// Information about the EKS cluster that has a coverage status.
    /// </summary>
    public partial class CoverageEksClusterDetails
    {
        /// <summary>
        /// Gets and sets the property AddonDetails. 
        /// <para>
        /// Information about the installed EKS add-on.
        /// </para>
        /// </summary>
        public AddonDetails AddonDetails { get; set; }

        /// <summary>
        /// Checks to see if the AddonDetails property is set.
        /// </summary>
        internal bool IsSetAddonDetails() => this.AddonDetails != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Name of the EKS cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CompatibleNodes. 
        /// <para>
        /// Represents all the nodes within the EKS cluster in your account.
        /// </para>
        /// </summary>
        public long? CompatibleNodes { get; set; }

        /// <summary>
        /// Checks to see if the CompatibleNodes property is set.
        /// </summary>
        internal bool IsSetCompatibleNodes() => this.CompatibleNodes.HasValue;

        /// <summary>
        /// Gets and sets the property CoveredNodes. 
        /// <para>
        /// Represents the nodes within the EKS cluster that have a <c>HEALTHY</c> coverage status.
        /// </para>
        /// </summary>
        public long? CoveredNodes { get; set; }

        /// <summary>
        /// Checks to see if the CoveredNodes property is set.
        /// </summary>
        internal bool IsSetCoveredNodes() => this.CoveredNodes.HasValue;

        /// <summary>
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// Indicates how the Amazon EKS add-on GuardDuty agent is managed for this EKS cluster.
        /// </para>
        ///  
        /// <para>
        ///  <c>AUTO_MANAGED</c> indicates GuardDuty deploys and manages updates for this resource.
        /// </para>
        ///  
        /// <para>
        ///  <c>MANUAL</c> indicates that you are responsible to deploy, update, and manage the
        /// Amazon EKS add-on GuardDuty agent for this resource.
        /// </para>
        /// </summary>
        public ManagementType ManagementType { get; set; }

        /// <summary>
        /// Checks to see if the ManagementType property is set.
        /// </summary>
        internal bool IsSetManagementType() => this.ManagementType != null;
    }
}

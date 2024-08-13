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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private AddonDetails _addonDetails;
        private string _clusterName;
        private long? _compatibleNodes;
        private long? _coveredNodes;
        private ManagementType _managementType;

        /// <summary>
        /// Gets and sets the property AddonDetails. 
        /// <para>
        /// Information about the installed EKS add-on.
        /// </para>
        /// </summary>
        public AddonDetails AddonDetails
        {
            get { return this._addonDetails; }
            set { this._addonDetails = value; }
        }

        // Check to see if AddonDetails property is set
        internal bool IsSetAddonDetails()
        {
            return this._addonDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Name of the EKS cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property CompatibleNodes. 
        /// <para>
        /// Represents all the nodes within the EKS cluster in your account.
        /// </para>
        /// </summary>
        public long? CompatibleNodes
        {
            get { return this._compatibleNodes; }
            set { this._compatibleNodes = value; }
        }

        // Check to see if CompatibleNodes property is set
        internal bool IsSetCompatibleNodes()
        {
            return this._compatibleNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoveredNodes. 
        /// <para>
        /// Represents the nodes within the EKS cluster that have a <c>HEALTHY</c> coverage status.
        /// </para>
        /// </summary>
        public long? CoveredNodes
        {
            get { return this._coveredNodes; }
            set { this._coveredNodes = value; }
        }

        // Check to see if CoveredNodes property is set
        internal bool IsSetCoveredNodes()
        {
            return this._coveredNodes.HasValue; 
        }

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
        public ManagementType ManagementType
        {
            get { return this._managementType; }
            set { this._managementType = value; }
        }

        // Check to see if ManagementType property is set
        internal bool IsSetManagementType()
        {
            return this._managementType != null;
        }

    }
}
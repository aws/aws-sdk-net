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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateService operation.
    /// Updates an existing service.
    /// </summary>
    public partial class UpdateServiceRequest : AmazonResiliencehubv2Request
    {
        private List<AssociatedSystem> _associatedSystems = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;
        private DependencyDiscoveryInput _dependencyDiscovery;
        private string _description;
        private PermissionModel _permissionModel;
        private string _policyArn;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ServiceReportConfiguration _reportConfiguration;
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property AssociatedSystems. 
        /// <para>
        /// The updated systems to associate with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<AssociatedSystem> AssociatedSystems
        {
            get { return this._associatedSystems; }
            set { this._associatedSystems = value; }
        }

        // Check to see if AssociatedSystems property is set
        internal bool IsSetAssociatedSystems()
        {
            return this._associatedSystems != null && (this._associatedSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DependencyDiscovery.
        /// </summary>
        public DependencyDiscoveryInput DependencyDiscovery
        {
            get { return this._dependencyDiscovery; }
            set { this._dependencyDiscovery = value; }
        }

        // Check to see if DependencyDiscovery property is set
        internal bool IsSetDependencyDiscovery()
        {
            return this._dependencyDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=615)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The updated permission model for the service.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The updated AWS Regions where the service operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        public ServiceReportConfiguration ReportConfiguration
        {
            get { return this._reportConfiguration; }
            set { this._reportConfiguration = value; }
        }

        // Check to see if ReportConfiguration property is set
        internal bool IsSetReportConfiguration()
        {
            return this._reportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

    }
}
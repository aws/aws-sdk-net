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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the Amazon RDS reservations that Amazon Web Services recommends that
    /// you purchase.
    /// </summary>
    public partial class RDSInstanceDetails
    {
        private bool? _currentGeneration;
        private string _databaseEdition;
        private string _databaseEngine;
        private string _deploymentOption;
        private string _family;
        private string _instanceType;
        private string _licenseModel;
        private string _region;
        private bool? _sizeFlexEligible;

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Determines whether the recommendation is for a current-generation instance. 
        /// </para>
        /// </summary>
        public bool? CurrentGeneration
        {
            get { return this._currentGeneration; }
            set { this._currentGeneration = value; }
        }

        // Check to see if CurrentGeneration property is set
        internal bool IsSetCurrentGeneration()
        {
            return this._currentGeneration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The database edition that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DatabaseEdition
        {
            get { return this._databaseEdition; }
            set { this._databaseEdition = value; }
        }

        // Check to see if DatabaseEdition property is set
        internal bool IsSetDatabaseEdition()
        {
            return this._databaseEdition != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseEngine. 
        /// <para>
        /// The database engine that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DatabaseEngine
        {
            get { return this._databaseEngine; }
            set { this._databaseEngine = value; }
        }

        // Check to see if DatabaseEngine property is set
        internal bool IsSetDatabaseEngine()
        {
            return this._databaseEngine != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// Determines whether the recommendation is for a reservation in a single Availability
        /// Zone or a reservation with a backup in a second Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DeploymentOption
        {
            get { return this._deploymentOption; }
            set { this._deploymentOption = value; }
        }

        // Check to see if DeploymentOption property is set
        internal bool IsSetDeploymentOption()
        {
            return this._deploymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The instance family of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }

        // Check to see if Family property is set
        internal bool IsSetFamily()
        {
            return this._family != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance that Amazon Web Services recommends.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Determines whether the recommended reservation is size flexible.
        /// </para>
        /// </summary>
        public bool? SizeFlexEligible
        {
            get { return this._sizeFlexEligible; }
            set { this._sizeFlexEligible = value; }
        }

        // Check to see if SizeFlexEligible property is set
        internal bool IsSetSizeFlexEligible()
        {
            return this._sizeFlexEligible.HasValue; 
        }

    }
}
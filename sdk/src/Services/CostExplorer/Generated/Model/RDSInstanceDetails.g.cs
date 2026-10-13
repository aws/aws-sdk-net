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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about the Amazon RDS reservations that Amazon Web Services recommends that
    /// you purchase.
    /// </summary>
    public partial class RDSInstanceDetails
    {
        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Determines whether the recommendation is for a current-generation instance. 
        /// </para>
        /// </summary>
        public bool? CurrentGeneration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentGeneration property is set.
        /// </summary>
        internal bool IsSetCurrentGeneration() => this.CurrentGeneration.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseEdition. 
        /// <para>
        /// The database edition that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DatabaseEdition { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseEdition property is set.
        /// </summary>
        internal bool IsSetDatabaseEdition() => this.DatabaseEdition != null;

        /// <summary>
        /// Gets and sets the property DatabaseEngine. 
        /// <para>
        /// The database engine that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DatabaseEngine { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseEngine property is set.
        /// </summary>
        internal bool IsSetDatabaseEngine() => this.DatabaseEngine != null;

        /// <summary>
        /// Gets and sets the property DeploymentModel. 
        /// <para>
        /// Determines whether the recommendation is for a reservation for RDS Custom.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeploymentModel { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentModel property is set.
        /// </summary>
        internal bool IsSetDeploymentModel() => this.DeploymentModel != null;

        /// <summary>
        /// Gets and sets the property DeploymentOption. 
        /// <para>
        /// Determines whether the recommendation is for a reservation in a single Availability
        /// Zone or a reservation with a backup in a second Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DeploymentOption { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentOption property is set.
        /// </summary>
        internal bool IsSetDeploymentOption() => this.DeploymentOption != null;

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The instance family of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance that Amazon Web Services recommends.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The license model that the recommended reservation supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the recommended reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Determines whether the recommended reservation is size flexible.
        /// </para>
        /// </summary>
        public bool? SizeFlexEligible { get; set; }

        /// <summary>
        /// Checks to see if the SizeFlexEligible property is set.
        /// </summary>
        internal bool IsSetSizeFlexEligible() => this.SizeFlexEligible.HasValue;
    }
}

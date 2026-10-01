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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// The SAP component of your application.
    /// </summary>
    public partial class Component
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedHost. 
        /// <para>
        /// The associated host of the component.
        /// </para>
        /// </summary>
        public AssociatedHost AssociatedHost { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedHost property is set.
        /// </summary>
        internal bool IsSetAssociatedHost() => this.AssociatedHost != null;

        /// <summary>
        /// Gets and sets the property ChildComponents. 
        /// <para>
        /// The child components of a highly available environment. For example, in a highly available
        /// SAP on AWS workload, the child component consists of the primary and secondar instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChildComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ChildComponents property is set.
        /// </summary>
        internal bool IsSetChildComponents() => this.ChildComponents != null && (this.ChildComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComponentId { get; set; }

        /// <summary>
        /// Checks to see if the ComponentId property is set.
        /// </summary>
        internal bool IsSetComponentId() => this.ComponentId != null;

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of the component.
        /// </para>
        /// </summary>
        public ComponentType ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

        /// <summary>
        /// Gets and sets the property DatabaseConnection. 
        /// <para>
        /// The connection specifications for the database of the component.
        /// </para>
        /// </summary>
        public DatabaseConnection DatabaseConnection { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseConnection property is set.
        /// </summary>
        internal bool IsSetDatabaseConnection() => this.DatabaseConnection != null;

        /// <summary>
        /// Gets and sets the property Databases. 
        /// <para>
        /// The SAP HANA databases of the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Databases { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Databases property is set.
        /// </summary>
        internal bool IsSetDatabases() => this.Databases != null && (this.Databases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HdbVersion. 
        /// <para>
        /// The SAP HANA version of the component.
        /// </para>
        /// </summary>
        public string HdbVersion { get; set; }

        /// <summary>
        /// Checks to see if the HdbVersion property is set.
        /// </summary>
        internal bool IsSetHdbVersion() => this.HdbVersion != null;

        /// <summary>
        /// Gets and sets the property Hosts. 
        /// <para>
        /// The hosts of the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This shape is no longer used. Please use AssociatedHost.")]
        public List<Host> Hosts { get; set; } = AWSConfigs.InitializeCollections ? new List<Host>() : null;

        /// <summary>
        /// Checks to see if the Hosts property is set.
        /// </summary>
        internal bool IsSetHosts() => this.Hosts != null && (this.Hosts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the component was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property ParentComponent. 
        /// <para>
        /// The parent component of a highly available environment. For example, in a highly available
        /// SAP on AWS workload, the parent component consists of the entire setup, including
        /// the child components.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ParentComponent { get; set; }

        /// <summary>
        /// Checks to see if the ParentComponent property is set.
        /// </summary>
        internal bool IsSetParentComponent() => this.ParentComponent != null;

        /// <summary>
        /// Gets and sets the property PrimaryHost. 
        /// <para>
        /// The primary host of the component.
        /// </para>
        /// </summary>
        [Obsolete("This shape is no longer used. Please use AssociatedHost.")]
        public string PrimaryHost { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryHost property is set.
        /// </summary>
        internal bool IsSetPrimaryHost() => this.PrimaryHost != null;

        /// <summary>
        /// Gets and sets the property Resilience. 
        /// <para>
        /// Details of the SAP HANA system replication for the component.
        /// </para>
        /// </summary>
        public Resilience Resilience { get; set; }

        /// <summary>
        /// Checks to see if the Resilience property is set.
        /// </summary>
        internal bool IsSetResilience() => this.Resilience != null;

        /// <summary>
        /// Gets and sets the property SapFeature. 
        /// <para>
        /// The SAP feature of the component.
        /// </para>
        /// </summary>
        public string SapFeature { get; set; }

        /// <summary>
        /// Checks to see if the SapFeature property is set.
        /// </summary>
        internal bool IsSetSapFeature() => this.SapFeature != null;

        /// <summary>
        /// Gets and sets the property SapHostname. 
        /// <para>
        /// The hostname of the component.
        /// </para>
        /// </summary>
        public string SapHostname { get; set; }

        /// <summary>
        /// Checks to see if the SapHostname property is set.
        /// </summary>
        internal bool IsSetSapHostname() => this.SapHostname != null;

        /// <summary>
        /// Gets and sets the property SapKernelVersion. 
        /// <para>
        /// The kernel version of the component.
        /// </para>
        /// </summary>
        public string SapKernelVersion { get; set; }

        /// <summary>
        /// Checks to see if the SapKernelVersion property is set.
        /// </summary>
        internal bool IsSetSapKernelVersion() => this.SapKernelVersion != null;

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The SAP System Identifier of the application component.
        /// </para>
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// Checks to see if the Sid property is set.
        /// </summary>
        internal bool IsSetSid() => this.Sid != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ACTIVATED - this status has been deprecated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STARTING - the component is in the process of being started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED - the component is not running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPING - the component is in the process of being stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING - the component is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING_WITH_ERROR - one or more child component(s) of the parent component is not
        /// running. Call <a href="https://docs.aws.amazon.com/ssmsap/latest/APIReference/API_GetComponent.html">
        /// <c>GetComponent</c> </a> to review the status of each child component.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNDEFINED - AWS Systems Manager for SAP cannot provide the component status based
        /// on the discovered information. Verify your SAP application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComponentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemNumber. 
        /// <para>
        /// The SAP system number of the application component.
        /// </para>
        /// </summary>
        public string SystemNumber { get; set; }

        /// <summary>
        /// Checks to see if the SystemNumber property is set.
        /// </summary>
        internal bool IsSetSystemNumber() => this.SystemNumber != null;
    }
}

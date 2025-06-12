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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
        private string _applicationId;
        private string _arn;
        private AssociatedHost _associatedHost;
        private List<string> _childComponents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _componentId;
        private ComponentType _componentType;
        private DatabaseConnection _databaseConnection;
        private List<string> _databases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _hdbVersion;
        private List<Host> _hosts = AWSConfigs.InitializeCollections ? new List<Host>() : null;
        private DateTime? _lastUpdated;
        private string _parentComponent;
        private string _primaryHost;
        private Resilience _resilience;
        private string _sapFeature;
        private string _sapHostname;
        private string _sapKernelVersion;
        private string _sid;
        private ComponentStatus _status;
        private string _systemNumber;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedHost. 
        /// <para>
        /// The associated host of the component.
        /// </para>
        /// </summary>
        public AssociatedHost AssociatedHost
        {
            get { return this._associatedHost; }
            set { this._associatedHost = value; }
        }

        // Check to see if AssociatedHost property is set
        internal bool IsSetAssociatedHost()
        {
            return this._associatedHost != null;
        }

        /// <summary>
        /// Gets and sets the property ChildComponents. 
        /// <para>
        /// The child components of a highly available environment. For example, in a highly available
        /// SAP on AWS workload, the child component consists of the primary and secondar instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ChildComponents
        {
            get { return this._childComponents; }
            set { this._childComponents = value; }
        }

        // Check to see if ChildComponents property is set
        internal bool IsSetChildComponents()
        {
            return this._childComponents != null && (this._childComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ComponentId
        {
            get { return this._componentId; }
            set { this._componentId = value; }
        }

        // Check to see if ComponentId property is set
        internal bool IsSetComponentId()
        {
            return this._componentId != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The type of the component.
        /// </para>
        /// </summary>
        public ComponentType ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseConnection. 
        /// <para>
        /// The connection specifications for the database of the component.
        /// </para>
        /// </summary>
        public DatabaseConnection DatabaseConnection
        {
            get { return this._databaseConnection; }
            set { this._databaseConnection = value; }
        }

        // Check to see if DatabaseConnection property is set
        internal bool IsSetDatabaseConnection()
        {
            return this._databaseConnection != null;
        }

        /// <summary>
        /// Gets and sets the property Databases. 
        /// <para>
        /// The SAP HANA databases of the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }

        // Check to see if Databases property is set
        internal bool IsSetDatabases()
        {
            return this._databases != null && (this._databases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HdbVersion. 
        /// <para>
        /// The SAP HANA version of the component.
        /// </para>
        /// </summary>
        public string HdbVersion
        {
            get { return this._hdbVersion; }
            set { this._hdbVersion = value; }
        }

        // Check to see if HdbVersion property is set
        internal bool IsSetHdbVersion()
        {
            return this._hdbVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Hosts. 
        /// <para>
        /// The hosts of the component.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This shape is no longer used. Please use AssociatedHost.")]
        public List<Host> Hosts
        {
            get { return this._hosts; }
            set { this._hosts = value; }
        }

        // Check to see if Hosts property is set
        internal bool IsSetHosts()
        {
            return this._hosts != null && (this._hosts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the component was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentComponent. 
        /// <para>
        /// The parent component of a highly available environment. For example, in a highly available
        /// SAP on AWS workload, the parent component consists of the entire setup, including
        /// the child components.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ParentComponent
        {
            get { return this._parentComponent; }
            set { this._parentComponent = value; }
        }

        // Check to see if ParentComponent property is set
        internal bool IsSetParentComponent()
        {
            return this._parentComponent != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryHost. 
        /// <para>
        /// The primary host of the component.
        /// </para>
        /// </summary>
        [Obsolete("This shape is no longer used. Please use AssociatedHost.")]
        public string PrimaryHost
        {
            get { return this._primaryHost; }
            set { this._primaryHost = value; }
        }

        // Check to see if PrimaryHost property is set
        internal bool IsSetPrimaryHost()
        {
            return this._primaryHost != null;
        }

        /// <summary>
        /// Gets and sets the property Resilience. 
        /// <para>
        /// Details of the SAP HANA system replication for the component.
        /// </para>
        /// </summary>
        public Resilience Resilience
        {
            get { return this._resilience; }
            set { this._resilience = value; }
        }

        // Check to see if Resilience property is set
        internal bool IsSetResilience()
        {
            return this._resilience != null;
        }

        /// <summary>
        /// Gets and sets the property SapFeature. 
        /// <para>
        /// The SAP feature of the component.
        /// </para>
        /// </summary>
        public string SapFeature
        {
            get { return this._sapFeature; }
            set { this._sapFeature = value; }
        }

        // Check to see if SapFeature property is set
        internal bool IsSetSapFeature()
        {
            return this._sapFeature != null;
        }

        /// <summary>
        /// Gets and sets the property SapHostname. 
        /// <para>
        /// The hostname of the component.
        /// </para>
        /// </summary>
        public string SapHostname
        {
            get { return this._sapHostname; }
            set { this._sapHostname = value; }
        }

        // Check to see if SapHostname property is set
        internal bool IsSetSapHostname()
        {
            return this._sapHostname != null;
        }

        /// <summary>
        /// Gets and sets the property SapKernelVersion. 
        /// <para>
        /// The kernel version of the component.
        /// </para>
        /// </summary>
        public string SapKernelVersion
        {
            get { return this._sapKernelVersion; }
            set { this._sapKernelVersion = value; }
        }

        // Check to see if SapKernelVersion property is set
        internal bool IsSetSapKernelVersion()
        {
            return this._sapKernelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// The SAP System Identifier of the application component.
        /// </para>
        /// </summary>
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid != null;
        }

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
        public ComponentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SystemNumber. 
        /// <para>
        /// The SAP system number of the application component.
        /// </para>
        /// </summary>
        public string SystemNumber
        {
            get { return this._systemNumber; }
            set { this._systemNumber = value; }
        }

        // Check to see if SystemNumber property is set
        internal bool IsSetSystemNumber()
        {
            return this._systemNumber != null;
        }

    }
}
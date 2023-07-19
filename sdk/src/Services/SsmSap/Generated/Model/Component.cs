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
        private List<string> _childComponents = new List<string>();
        private string _componentId;
        private ComponentType _componentType;
        private List<string> _databases = new List<string>();
        private string _hdbVersion;
        private List<Host> _hosts = new List<Host>();
        private DateTime? _lastUpdated;
        private string _parentComponent;
        private string _primaryHost;
        private Resilience _resilience;
        private string _sapHostname;
        private string _sapKernelVersion;
        private ComponentStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<string> ChildComponents
        {
            get { return this._childComponents; }
            set { this._childComponents = value; }
        }

        // Check to see if ChildComponents property is set
        internal bool IsSetChildComponents()
        {
            return this._childComponents != null && this._childComponents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComponentId. 
        /// <para>
        /// The ID of the component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Databases. 
        /// <para>
        /// The SAP HANA databases of the component.
        /// </para>
        /// </summary>
        public List<string> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }

        // Check to see if Databases property is set
        internal bool IsSetDatabases()
        {
            return this._databases != null && this._databases.Count > 0; 
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
            return this._hosts != null && this._hosts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the component was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the component.
        /// </para>
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

    }
}
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
        private string _componentId;
        private ComponentType _componentType;
        private List<string> _databases = new List<string>();
        private List<Host> _hosts = new List<Host>();
        private DateTime? _lastUpdated;
        private string _primaryHost;
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
        /// Gets and sets the property Hosts. 
        /// <para>
        /// The hosts of the component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PrimaryHost. 
        /// <para>
        /// The primary host of the component.
        /// </para>
        /// </summary>
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
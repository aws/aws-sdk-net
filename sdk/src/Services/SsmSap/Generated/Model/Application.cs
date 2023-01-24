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
    /// An SAP application registered with AWS Systems Manager for SAP.
    /// </summary>
    public partial class Application
    {
        private string _appRegistryArn;
        private string _arn;
        private List<string> _components = new List<string>();
        private string _id;
        private DateTime? _lastUpdated;
        private ApplicationStatus _status;
        private string _statusMessage;
        private ApplicationType _type;

        /// <summary>
        /// Gets and sets the property AppRegistryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Application Registry.
        /// </para>
        /// </summary>
        public string AppRegistryArn
        {
            get { return this._appRegistryArn; }
            set { this._appRegistryArn = value; }
        }

        // Check to see if AppRegistryArn property is set
        internal bool IsSetAppRegistryArn()
        {
            return this._appRegistryArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application.
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
        /// Gets and sets the property Components. 
        /// <para>
        /// The components of the application.
        /// </para>
        /// </summary>
        public List<string> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && this._components.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time at which the application was last updated.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        public ApplicationStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the application.
        /// </para>
        /// </summary>
        public ApplicationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}
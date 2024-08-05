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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure that contains the information about one service account.
    /// </summary>
    public partial class ServiceAccountSummary
    {
        private Role _grafanaRole;
        private string _id;
        private string _isDisabled;
        private string _name;

        /// <summary>
        /// Gets and sets the property GrafanaRole. 
        /// <para>
        /// The role of the service account, which sets the permission level used when calling
        /// Grafana APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Role GrafanaRole
        {
            get { return this._grafanaRole; }
            set { this._grafanaRole = value; }
        }

        // Check to see if GrafanaRole property is set
        internal bool IsSetGrafanaRole()
        {
            return this._grafanaRole != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IsDisabled. 
        /// <para>
        /// Returns true if the service account is disabled. Service accounts can be disabled
        /// and enabled in the Amazon Managed Grafana console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IsDisabled
        {
            get { return this._isDisabled; }
            set { this._isDisabled = value; }
        }

        // Check to see if IsDisabled property is set
        internal bool IsSetIsDisabled()
        {
            return this._isDisabled != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
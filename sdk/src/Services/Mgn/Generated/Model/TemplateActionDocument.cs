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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TemplateActionDocument
    {
        private string _actionid;
        private string _actionName;
        private bool? _active;
        private string _documentIdentifier;
        private string _documentVersion;
        private bool? _mustSucceedForCutover;
        private string _operatingSystem;
        private int? _order;
        private Dictionary<string, List<SsmParameterStoreParameter>> _parameters = new Dictionary<string, List<SsmParameterStoreParameter>>();
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property ActionID. 
        /// <para>
        /// Template post migration custom action ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ActionID
        {
            get { return this._actionid; }
            set { this._actionid = value; }
        }

        // Check to see if ActionID property is set
        internal bool IsSetActionID()
        {
            return this._actionid != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// Template post migration custom action name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Template post migration custom action active status.
        /// </para>
        /// </summary>
        public bool Active
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentIdentifier. 
        /// <para>
        /// Template post migration custom action document identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DocumentIdentifier
        {
            get { return this._documentIdentifier; }
            set { this._documentIdentifier = value; }
        }

        // Check to see if DocumentIdentifier property is set
        internal bool IsSetDocumentIdentifier()
        {
            return this._documentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// Template post migration custom action document version.
        /// </para>
        /// </summary>
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MustSucceedForCutover. 
        /// <para>
        /// Template post migration custom action must succeed for cutover.
        /// </para>
        /// </summary>
        public bool MustSucceedForCutover
        {
            get { return this._mustSucceedForCutover.GetValueOrDefault(); }
            set { this._mustSucceedForCutover = value; }
        }

        // Check to see if MustSucceedForCutover property is set
        internal bool IsSetMustSucceedForCutover()
        {
            return this._mustSucceedForCutover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Operating system eligible for this template post migration custom action.
        /// </para>
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Template post migration custom action order.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1001, Max=10000)]
        public int Order
        {
            get { return this._order.GetValueOrDefault(); }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Template post migration custom action parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, List<SsmParameterStoreParameter>> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// Template post migration custom action timeout in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int TimeoutSeconds
        {
            get { return this._timeoutSeconds.GetValueOrDefault(); }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}
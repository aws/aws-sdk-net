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
    /// AWS Systems Manager Document.
    /// </summary>
    public partial class SsmDocument
    {
        private string _actionName;
        private Dictionary<string, SsmExternalParameter> _externalParameters = new Dictionary<string, SsmExternalParameter>();
        private bool? _mustSucceedForCutover;
        private Dictionary<string, List<SsmParameterStoreParameter>> _parameters = new Dictionary<string, List<SsmParameterStoreParameter>>();
        private string _ssmDocumentName;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// User-friendly name for the AWS Systems Manager Document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property ExternalParameters. 
        /// <para>
        /// AWS Systems Manager Document external parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, SsmExternalParameter> ExternalParameters
        {
            get { return this._externalParameters; }
            set { this._externalParameters = value; }
        }

        // Check to see if ExternalParameters property is set
        internal bool IsSetExternalParameters()
        {
            return this._externalParameters != null && this._externalParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MustSucceedForCutover. 
        /// <para>
        /// If true, Cutover will not be enabled if the document has failed.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// AWS Systems Manager Document parameters.
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
        /// Gets and sets the property SsmDocumentName. 
        /// <para>
        /// AWS Systems Manager Document name or full ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=172)]
        public string SsmDocumentName
        {
            get { return this._ssmDocumentName; }
            set { this._ssmDocumentName = value; }
        }

        // Check to see if SsmDocumentName property is set
        internal bool IsSetSsmDocumentName()
        {
            return this._ssmDocumentName != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// AWS Systems Manager Document timeout seconds.
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
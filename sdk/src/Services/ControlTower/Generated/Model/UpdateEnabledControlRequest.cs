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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnabledControl operation.
    /// Updates the configuration of an already enabled control.
    /// 
    ///  
    /// <para>
    /// If the enabled control shows an <c>EnablementStatus</c> of SUCCEEDED, supply parameters
    /// that are different from the currently configured parameters. Otherwise, Amazon Web
    /// Services Control Tower will not accept the request.
    /// </para>
    ///  
    /// <para>
    /// If the enabled control shows an <c>EnablementStatus</c> of FAILED, Amazon Web Services
    /// Control Tower updates the control to match any valid parameters that you supply.
    /// </para>
    ///  
    /// <para>
    /// If the <c>DriftSummary</c> status for the control shows as <c>DRIFTED</c>, you cannot
    /// call this API. Instead, you can update the control by calling the <c>ResetEnabledControl</c>
    /// API. Alternatively, you can call <c>DisableControl</c> and then call <c>EnableControl</c>
    /// again. Also, you can run an extending governance operation to repair drift. For usage
    /// examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
    /// <i>Controls Reference Guide</i> </a>. 
    /// </para>
    /// </summary>
    public partial class UpdateEnabledControlRequest : AmazonControlTowerRequest
    {
        private string _enabledControlIdentifier;
        private List<EnabledControlParameter> _parameters = AWSConfigs.InitializeCollections ? new List<EnabledControlParameter>() : null;

        /// <summary>
        /// Gets and sets the property EnabledControlIdentifier. 
        /// <para>
        ///  The ARN of the enabled control that will be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EnabledControlIdentifier
        {
            get { return this._enabledControlIdentifier; }
            set { this._enabledControlIdentifier = value; }
        }

        // Check to see if EnabledControlIdentifier property is set
        internal bool IsSetEnabledControlIdentifier()
        {
            return this._enabledControlIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key/value pair, where <c>Key</c> is of type <c>String</c> and <c>Value</c> is of
        /// type <c>Document</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EnabledControlParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
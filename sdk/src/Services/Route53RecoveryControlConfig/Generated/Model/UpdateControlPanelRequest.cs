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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
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
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateControlPanel operation.
    /// Updates a control panel. The only update you can make to a control panel is to change
    /// the name of the control panel.
    /// </summary>
    public partial class UpdateControlPanelRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private string _controlPanelArn;
        private string _controlPanelName;

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ControlPanelArn
        {
            get { return this._controlPanelArn; }
            set { this._controlPanelArn = value; }
        }

        // Check to see if ControlPanelArn property is set
        internal bool IsSetControlPanelArn()
        {
            return this._controlPanelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ControlPanelName. 
        /// <para>
        /// The name of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ControlPanelName
        {
            get { return this._controlPanelName; }
            set { this._controlPanelName = value; }
        }

        // Check to see if ControlPanelName property is set
        internal bool IsSetControlPanelName()
        {
            return this._controlPanelName != null;
        }

    }
}
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
    /// Container for the parameters to the GetEnabledControl operation.
    /// Retrieves details about an enabled control. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
    /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
    /// </summary>
    public partial class GetEnabledControlRequest : AmazonControlTowerRequest
    {
        private string _enabledControlIdentifier;

        /// <summary>
        /// Gets and sets the property EnabledControlIdentifier. 
        /// <para>
        /// The <c>controlIdentifier</c> of the enabled control.
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

    }
}
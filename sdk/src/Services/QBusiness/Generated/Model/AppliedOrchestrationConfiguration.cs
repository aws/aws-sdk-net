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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The chat orchestration specific admin controls configured for an Amazon Q Business
    /// application. Determines whether Amazon Q Business automatically routes chat requests
    /// across configured plugins and data sources in your Amazon Q Business application.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/guardrails-global-controls.html#guardrails-global-orchestration">Chat
    /// orchestration settings</a>.
    /// </para>
    /// </summary>
    public partial class AppliedOrchestrationConfiguration
    {
        private OrchestrationControl _control;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        ///  Information about whether chat orchestration is enabled or disabled for an Amazon
        /// Q Business application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrchestrationControl Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// An action defines the tasks that the extension performs during the AppConfig workflow.
    /// Each action includes an action point such as <code>ON_CREATE_HOSTED_CONFIGURATION</code>,
    /// <code>PRE_DEPLOYMENT</code>, or <code>ON_DEPLOYMENT</code>. Each action also includes
    /// a name, a URI to an Lambda function, and an Amazon Resource Name (ARN) for an Identity
    /// and Access Management assume role. You specify the name, URI, and ARN for each <i>action
    /// point</i> defined in the extension. You can specify the following actions for an extension:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>PRE_CREATE_HOSTED_CONFIGURATION_VERSION</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PRE_START_DEPLOYMENT</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ON_DEPLOYMENT_START</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ON_DEPLOYMENT_STEP</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ON_DEPLOYMENT_BAKING</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ON_DEPLOYMENT_COMPLETE</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ON_DEPLOYMENT_ROLLED_BACK</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Action
    {
        private string _description;
        private string _name;
        private string _roleArn;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Information about the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The action name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) for an Identity and Access Management assume role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The extension URI associated to the action point in the extension definition. The
        /// URI can be an Amazon Resource Name (ARN) for one of the following: an Lambda function,
        /// an Amazon Simple Queue Service queue, an Amazon Simple Notification Service topic,
        /// or the Amazon EventBridge default event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}
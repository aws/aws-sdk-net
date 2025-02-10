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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// An action defines the tasks that the extension performs during the AppConfig workflow.
    /// Each action includes an action point, as shown in the following list: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>PRE_CREATE_HOSTED_CONFIGURATION_VERSION</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PRE_START_DEPLOYMENT</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AT_DEPLOYMENT_TICK</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ON_DEPLOYMENT_START</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ON_DEPLOYMENT_STEP</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ON_DEPLOYMENT_BAKING</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ON_DEPLOYMENT_COMPLETE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ON_DEPLOYMENT_ROLLED_BACK</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each action also includes a name, a URI to an Lambda function, and an Amazon Resource
    /// Name (ARN) for an Identity and Access Management assume role. You specify the name,
    /// URI, and ARN for each <i>action point</i> defined in the extension.
    /// </para>
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
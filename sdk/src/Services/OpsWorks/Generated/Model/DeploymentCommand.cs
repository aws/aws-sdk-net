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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Used to specify a stack or deployment command.
    /// </summary>
    public partial class DeploymentCommand
    {
        private Dictionary<string, List<string>> _args = new Dictionary<string, List<string>>();
        private DeploymentCommandName _name;

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// The arguments of those commands that take arguments. It should be set to a JSON object
        /// with the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>{"arg_name1" : ["value1", "value2", ...], "arg_name2" : ["value1", "value2",
        /// ...], ...}</code> 
        /// </para>
        ///  
        /// <para>
        /// The <code>update_dependencies</code> command takes two arguments:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>upgrade_os_to</code> - Specifies the desired Amazon Linux version for instances
        /// whose OS you want to upgrade, such as <code>Amazon Linux 2016.09</code>. You must
        /// also set the <code>allow_reboot</code> argument to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>allow_reboot</code> - Specifies whether to allow AWS OpsWorks Stacks to reboot
        /// the instances if necessary, after installing the updates. This argument can be set
        /// to either <code>true</code> or <code>false</code>. The default value is <code>false</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, to upgrade an instance to Amazon Linux 2016.09, set <code>Args</code>
        /// to the following.
        /// </para>
        ///  
        /// <para>
        ///  <code> { "upgrade_os_to":["Amazon Linux 2016.09"], "allow_reboot":["true"] } </code>
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the operation. You can specify only one command.
        /// </para>
        ///  
        /// <para>
        /// For stacks, the following commands are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>execute_recipes</code>: Execute one or more recipes. To specify the recipes,
        /// set an <code>Args</code> parameter named <code>recipes</code> to the list of recipes
        /// to be executed. For example, to execute <code>phpapp::appsetup</code>, set <code>Args</code>
        /// to <code>{"recipes":["phpapp::appsetup"]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>install_dependencies</code>: Install the stack's dependencies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>update_custom_cookbooks</code>: Update the stack's custom cookbooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>update_dependencies</code>: Update the stack's dependencies.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The update_dependencies and install_dependencies commands are supported only for Linux
        /// instances. You can run the commands successfully on Windows instances, but they do
        /// nothing.
        /// </para>
        ///  </note> 
        /// <para>
        /// For apps, the following commands are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deploy</code>: Deploy an app. Ruby on Rails apps have an optional <code>Args</code>
        /// parameter named <code>migrate</code>. Set <code>Args</code> to {"migrate":["true"]}
        /// to migrate the database. The default setting is {"migrate":["false"]}.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rollback</code> Roll the app back to the previous version. When you update
        /// an app, AWS OpsWorks Stacks stores the previous version, up to a maximum of five versions.
        /// You can use this command to roll an app back as many as four versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start</code>: Start the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stop</code>: Stop the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restart</code>: Restart the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>undeploy</code>: Undeploy the app.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentCommandName Name
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
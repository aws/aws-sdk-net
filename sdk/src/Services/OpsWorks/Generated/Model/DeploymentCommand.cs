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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Used to specify a stack or deployment command.
    /// </summary>
    public partial class DeploymentCommand
    {
        private Dictionary<string, List<string>> _args = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private DeploymentCommandName _name;

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// The arguments of those commands that take arguments. It should be set to a JSON object
        /// with the following format:
        /// </para>
        ///  
        /// <para>
        ///  <c>{"arg_name1" : ["value1", "value2", ...], "arg_name2" : ["value1", "value2", ...],
        /// ...}</c> 
        /// </para>
        ///  
        /// <para>
        /// The <c>update_dependencies</c> command takes two arguments:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>upgrade_os_to</c> - Specifies the Amazon Linux version that you want instances
        /// to run, such as <c>Amazon Linux 2</c>. You must also set the <c>allow_reboot</c> argument
        /// to true.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>allow_reboot</c> - Specifies whether to allow OpsWorks Stacks to reboot the instances
        /// if necessary, after installing the updates. This argument can be set to either <c>true</c>
        /// or <c>false</c>. The default value is <c>false</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, to upgrade an instance to Amazon Linux 2018.03, set <c>Args</c> to the
        /// following.
        /// </para>
        ///  
        /// <para>
        ///  <c> { "upgrade_os_to":["Amazon Linux 2018.03"], "allow_reboot":["true"] } </c> 
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
            return this._args != null && (this._args.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <c>execute_recipes</c>: Execute one or more recipes. To specify the recipes, set
        /// an <c>Args</c> parameter named <c>recipes</c> to the list of recipes to be executed.
        /// For example, to execute <c>phpapp::appsetup</c>, set <c>Args</c> to <c>{"recipes":["phpapp::appsetup"]}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>install_dependencies</c>: Install the stack's dependencies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>update_custom_cookbooks</c>: Update the stack's custom cookbooks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>update_dependencies</c>: Update the stack's dependencies.
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
        ///  <c>deploy</c>: Deploy an app. Ruby on Rails apps have an optional <c>Args</c> parameter
        /// named <c>migrate</c>. Set <c>Args</c> to {"migrate":["true"]} to migrate the database.
        /// The default setting is {"migrate":["false"]}.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rollback</c> Roll the app back to the previous version. When you update an app,
        /// OpsWorks Stacks stores the previous version, up to a maximum of five versions. You
        /// can use this command to roll an app back as many as four versions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start</c>: Start the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stop</c>: Stop the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>restart</c>: Restart the app's web or application server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>undeploy</c>: Undeploy the app.
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
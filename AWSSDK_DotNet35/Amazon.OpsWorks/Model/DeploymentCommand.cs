/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Used to specify a deployment operation.</para>
    /// </summary>
    public partial class DeploymentCommand
    {
        
        private DeploymentCommandName name;
        private Dictionary<string,List<string>> args = new Dictionary<string,List<string>>();


        /// <summary>
        /// Specifies the operation. You can specify only one command. For stacks, the following commands are available: <ul>
        /// <li><c>execute_recipes</c>: Execute one or more recipes. To specify the recipes, set an <c>Args</c> parameter named <c>recipes</c> to the
        /// list of recipes to be executed. For example, to execute <c>phpapp::appsetup</c>, set <c>Args</c> to
        /// <c>{"recipes":["phpapp::appsetup"]}</c>.</li> <li><c>install_dependencies</c>: Install the stack's dependencies.</li>
        /// <li><c>update_custom_cookbooks</c>: Update the stack's custom cookbooks.</li> <li><c>update_dependencies</c>: Update the stack's
        /// dependencies.</li> </ul> For apps, the following commands are available: <ul> <li><c>deploy</c>: Deploy an app. Rails apps have an optional
        /// <c>Args</c> parameter named <c>migrate</c>. Set <c>Args</c> to {"migrate":["true"]} to migrate the database. The default setting is
        /// {"migrate":["false"]}.</li> <li><c>rollback</c> Roll the app back to the previous version. When you update an app, AWS OpsWorks stores the
        /// previous version, up to a maximum of five versions. You can use this command to roll an app back as many as four versions.</li>
        /// <li><c>start</c>: Start the app's web or application server.</li> <li><c>stop</c>: Stop the app's web or application server.</li>
        /// <li><c>restart</c>: Restart the app's web or application server.</li> <li><c>undeploy</c>: Undeploy the app.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>install_dependencies, update_dependencies, update_custom_cookbooks, execute_recipes, deploy, rollback, start, stop, restart, undeploy</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DeploymentCommandName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The arguments of those commands that take arguments. It should be set to a JSON object with the following format: <c>{"arg_name":["value1",
        /// "value2", ...]}</c>
        ///  
        /// </summary>
        public Dictionary<string,List<string>> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args != null;
        }
    }
}

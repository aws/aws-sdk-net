/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class DeploymentCommand
    {
        
        private string name;
        private Dictionary<string,List<string>> args = new Dictionary<string,List<string>>();

        /// <summary>
        /// Specifies the deployment operation. You can specify only one command. For stacks, the available commands are: <ul>
        /// <li><c></c>execute_recipes: Execute the recipes that are specified by the <c>Args</c> parameter.</li> <li><c></c>install_dependencies:
        /// Installs the stack's dependencies.</li> <li><c></c>update_custom_cookbooks: Update the stack's custom cookbooks.</li>
        /// <li><c></c>update_dependencies: Update the stack's dependencies.</li> </ul> For apps, the available commands are: <ul> <li><c>deploy</c>:
        /// Deploy the app.</li> <li><c>rollback</c> Roll the app back to the previous version. When you update an app, OpsWorks stores the previous
        /// version, up to a maximum of five versions. You can use this command to roll an app back as many as four versions.</li> <li><c>start</c>:
        /// Start the app's web or application server.</li> <li><c>stop</c>: Stop the app's web or application server.</li> <li><c>restart</c>: Restart
        /// the app's web or application server.</li> <li><c>undeploy</c>: Undeploy the app.</li> </ul>
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
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public DeploymentCommand WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// An array of command arguments. This parameter is currently used only to specify the list of recipes to be executed by the
        /// <c>ExecuteRecipes</c> command.
        ///  
        /// </summary>
        public Dictionary<string,List<string>> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Args dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Args dictionary.</param>
        /// <returns>this instance</returns>
        public DeploymentCommand WithArgs(params KeyValuePair<string, List<string>>[] pairs)
        {
            foreach (KeyValuePair<string, List<string>> pair in pairs)
            {
                this.Args[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args != null;
        }
    }
}

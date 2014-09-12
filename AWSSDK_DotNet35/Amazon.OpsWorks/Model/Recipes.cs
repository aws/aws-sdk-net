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

/*
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// AWS OpsWorks supports five lifecycle events, <b>setup</b>, <b>configuration</b>, <b>deploy</b>,
    /// <b>undeploy</b>, and <b>shutdown</b>. For each layer, AWS OpsWorks runs a set of standard
    /// recipes for each event. In addition, you can provide custom recipes for any or all
    /// layers and events. AWS OpsWorks runs custom event recipes after the standard recipes.
    /// <code>LayerCustomRecipes</code> specifies the custom recipes for a particular layer
    /// to be run in response to each of the five events. 
    /// 
    ///  
    /// <para>
    /// To specify a recipe, use the cookbook's directory name in the repository followed
    /// by two colons and the recipe name, which is the recipe's file name without the .rb
    /// extension. For example: phpapp2::dbsetup specifies the dbsetup.rb recipe in the repository's
    /// phpapp2 folder. 
    /// </para>
    /// </summary>
    public partial class Recipes
    {
        private List<string> _configure = new List<string>();
        private List<string> _deploy = new List<string>();
        private List<string> _setup = new List<string>();
        private List<string> _shutdown = new List<string>();
        private List<string> _undeploy = new List<string>();

        /// <summary>
        /// Gets and sets the property Configure. 
        /// <para>
        /// An array of custom recipe names to be run following a <code>configure</code> event.
        /// </para>
        /// </summary>
        public List<string> Configure
        {
            get { return this._configure; }
            set { this._configure = value; }
        }

        // Check to see if Configure property is set
        internal bool IsSetConfigure()
        {
            return this._configure != null && this._configure.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Deploy. 
        /// <para>
        /// An array of custom recipe names to be run following a <code>deploy</code> event.
        /// </para>
        /// </summary>
        public List<string> Deploy
        {
            get { return this._deploy; }
            set { this._deploy = value; }
        }

        // Check to see if Deploy property is set
        internal bool IsSetDeploy()
        {
            return this._deploy != null && this._deploy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Setup. 
        /// <para>
        /// An array of custom recipe names to be run following a <code>setup</code> event.
        /// </para>
        /// </summary>
        public List<string> Setup
        {
            get { return this._setup; }
            set { this._setup = value; }
        }

        // Check to see if Setup property is set
        internal bool IsSetSetup()
        {
            return this._setup != null && this._setup.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Shutdown. 
        /// <para>
        /// An array of custom recipe names to be run following a <code>shutdown</code> event.
        /// </para>
        /// </summary>
        public List<string> Shutdown
        {
            get { return this._shutdown; }
            set { this._shutdown = value; }
        }

        // Check to see if Shutdown property is set
        internal bool IsSetShutdown()
        {
            return this._shutdown != null && this._shutdown.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Undeploy. 
        /// <para>
        /// An array of custom recipe names to be run following a <code>undeploy</code> event.
        /// </para>
        /// </summary>
        public List<string> Undeploy
        {
            get { return this._undeploy; }
            set { this._undeploy = value; }
        }

        // Check to see if Undeploy property is set
        internal bool IsSetUndeploy()
        {
            return this._undeploy != null && this._undeploy.Count > 0; 
        }

    }
}
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
    /// <para>AWS OpsWorks supports five lifecycle events, <b>setup</b> ,
    /// <b>configuration</b> ,
    /// <b>deploy</b> ,
    /// <b>undeploy</b> , and <b>shutdown</b> .
    /// For each layer, AWS OpsWorks runs a set of standard recipes for each event. In addition, you can provide custom recipes for any or
    /// all layers and events. AWS OpsWorks runs custom event recipes after the standard recipes. <c>LayerCustomRecipes</c> specifies the custom
    /// recipes for a particular layer to be run in response to each of the five events. </para> <para>To specify a recipe, use the cookbook's
    /// directory name in the repository followed by two colons and the recipe name, which is the recipe's file name without the .rb extension. For
    /// example: phpapp2::dbsetup specifies the dbsetup.rb recipe in the repository's phpapp2 folder. </para>
    /// </summary>
    public class Recipes
    {
        
        private List<string> setup = new List<string>();
        private List<string> configure = new List<string>();
        private List<string> deploy = new List<string>();
        private List<string> undeploy = new List<string>();
        private List<string> shutdown = new List<string>();

        /// <summary>
        /// An array of custom recipe names to be run following a <c>setup</c> event.
        ///  
        /// </summary>
        public List<string> Setup
        {
            get { return this.setup; }
            set { this.setup = value; }
        }
        /// <summary>
        /// Adds elements to the Setup collection
        /// </summary>
        /// <param name="setup">The values to add to the Setup collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithSetup(params string[] setup)
        {
            foreach (string element in setup)
            {
                this.setup.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Setup collection
        /// </summary>
        /// <param name="setup">The values to add to the Setup collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithSetup(IEnumerable<string> setup)
        {
            foreach (string element in setup)
            {
                this.setup.Add(element);
            }

            return this;
        }

        // Check to see if Setup property is set
        internal bool IsSetSetup()
        {
            return this.setup.Count > 0;
        }

        /// <summary>
        /// An array of custom recipe names to be run following a <c>configure</c> event.
        ///  
        /// </summary>
        public List<string> Configure
        {
            get { return this.configure; }
            set { this.configure = value; }
        }
        /// <summary>
        /// Adds elements to the Configure collection
        /// </summary>
        /// <param name="configure">The values to add to the Configure collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithConfigure(params string[] configure)
        {
            foreach (string element in configure)
            {
                this.configure.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Configure collection
        /// </summary>
        /// <param name="configure">The values to add to the Configure collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithConfigure(IEnumerable<string> configure)
        {
            foreach (string element in configure)
            {
                this.configure.Add(element);
            }

            return this;
        }

        // Check to see if Configure property is set
        internal bool IsSetConfigure()
        {
            return this.configure.Count > 0;
        }

        /// <summary>
        /// An array of custom recipe names to be run following a <c>deploy</c> event.
        ///  
        /// </summary>
        public List<string> Deploy
        {
            get { return this.deploy; }
            set { this.deploy = value; }
        }
        /// <summary>
        /// Adds elements to the Deploy collection
        /// </summary>
        /// <param name="deploy">The values to add to the Deploy collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithDeploy(params string[] deploy)
        {
            foreach (string element in deploy)
            {
                this.deploy.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Deploy collection
        /// </summary>
        /// <param name="deploy">The values to add to the Deploy collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithDeploy(IEnumerable<string> deploy)
        {
            foreach (string element in deploy)
            {
                this.deploy.Add(element);
            }

            return this;
        }

        // Check to see if Deploy property is set
        internal bool IsSetDeploy()
        {
            return this.deploy.Count > 0;
        }

        /// <summary>
        /// An array of custom recipe names to be run following a <c>undeploy</c> event.
        ///  
        /// </summary>
        public List<string> Undeploy
        {
            get { return this.undeploy; }
            set { this.undeploy = value; }
        }
        /// <summary>
        /// Adds elements to the Undeploy collection
        /// </summary>
        /// <param name="undeploy">The values to add to the Undeploy collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithUndeploy(params string[] undeploy)
        {
            foreach (string element in undeploy)
            {
                this.undeploy.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Undeploy collection
        /// </summary>
        /// <param name="undeploy">The values to add to the Undeploy collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithUndeploy(IEnumerable<string> undeploy)
        {
            foreach (string element in undeploy)
            {
                this.undeploy.Add(element);
            }

            return this;
        }

        // Check to see if Undeploy property is set
        internal bool IsSetUndeploy()
        {
            return this.undeploy.Count > 0;
        }

        /// <summary>
        /// An array of custom recipe names to be run following a <c>shutdown</c> event.
        ///  
        /// </summary>
        public List<string> Shutdown
        {
            get { return this.shutdown; }
            set { this.shutdown = value; }
        }
        /// <summary>
        /// Adds elements to the Shutdown collection
        /// </summary>
        /// <param name="shutdown">The values to add to the Shutdown collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithShutdown(params string[] shutdown)
        {
            foreach (string element in shutdown)
            {
                this.shutdown.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Shutdown collection
        /// </summary>
        /// <param name="shutdown">The values to add to the Shutdown collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Recipes WithShutdown(IEnumerable<string> shutdown)
        {
            foreach (string element in shutdown)
            {
                this.shutdown.Add(element);
            }

            return this;
        }

        // Check to see if Shutdown property is set
        internal bool IsSetShutdown()
        {
            return this.shutdown.Count > 0;
        }
    }
}

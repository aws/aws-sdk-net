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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the patches to use to update the instances, including target operating
    /// systems and source repository. Applies to Linux instances only.
    /// </summary>
    public partial class PatchSource
    {
        private string _configuration;
        private string _name;
        private List<string> _products = new List<string>();

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The value of the yum repo configuration. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>cachedir=/var/cache/yum/$basesearch</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>$releasever</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>keepcache=0</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>debualevel=2</code> 
        /// </para>
        /// </summary>
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name specified to identify the patch source.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Products. 
        /// <para>
        /// The specific operating system versions a patch repository applies to, such as "Ubuntu16.04",
        /// "AmazonLinux2016.09", "RedhatEnterpriseLinux7.2" or "Suse12.7". For lists of supported
        /// product values, see <a>PatchFilter</a>.
        /// </para>
        /// </summary>
        public List<string> Products
        {
            get { return this._products; }
            set { this._products = value; }
        }

        // Check to see if Products property is set
        internal bool IsSetProducts()
        {
            return this._products != null && this._products.Count > 0; 
        }

    }
}
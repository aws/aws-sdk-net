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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the patches to use to update the managed nodes, including target
    /// operating systems and source repository. Applies to Linux managed nodes only.
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
        ///  <code>[main]</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>name=MyCustomRepository</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>baseurl=https://my-custom-repository</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>enabled=1</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about other options available for your yum repository configuration,
        /// see <a href="https://man7.org/linux/man-pages/man5/dnf.conf.5.html">dnf.conf(5)</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true, Min=1, Max=20)]
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
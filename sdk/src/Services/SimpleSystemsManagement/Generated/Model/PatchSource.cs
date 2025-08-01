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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _products = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The value of the repo configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for yum repositories</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>[main]</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>name=MyCustomRepository</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>baseurl=https://my-custom-repository</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>enabled=1</c> 
        /// </para>
        ///  
        /// <para>
        /// For information about other options available for your yum repository configuration,
        /// see <a href="https://man7.org/linux/man-pages/man5/dnf.conf.5.html">dnf.conf(5)</a>
        /// on the <i>man7.org</i> website.
        /// </para>
        ///  
        /// <para>
        ///  <b>Examples for Ubuntu Server and Debian Server</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>deb http://security.ubuntu.com/ubuntu jammy main</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>deb https://site.example.com/debian distribution component1 component2 component3</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Repo information for Ubuntu Server repositories must be specifed in a single line.
        /// For more examples and information, see <a href="https://manpages.ubuntu.com/manpages/jammy/man5/sources.list.5.html">jammy
        /// (5) sources.list.5.gz</a> on the <i>Ubuntu Server Manuals</i> website and <a href="https://wiki.debian.org/SourcesList#sources.list_format">sources.list
        /// format</a> on the <i>Debian Wiki</i>.
        /// </para>
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._products != null && (this._products.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
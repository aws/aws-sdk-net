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
    /// Defines a patch filter.
    /// 
    ///  
    /// <para>
    /// A patch filter consists of key/value pairs, but not all keys are valid for all operating
    /// system types. For example, the key <code>PRODUCT</code> is valid for all supported
    /// operating system types. The key <code>MSRC_SEVERITY</code>, however, is valid only
    /// for Windows operating systems, and the key <code>SECTION</code> is valid only for
    /// Ubuntu operating systems.
    /// </para>
    ///  
    /// <para>
    /// Refer to the following sections for information about which keys may be used with
    /// each major operating system, and which values are valid for each key.
    /// </para>
    ///  
    /// <para>
    ///  <b>Windows Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for Windows operating systems are <code>PRODUCT</code>, <code>CLASSIFICATION</code>,
    /// and <code>MSRC_SEVERITY</code>. See the following lists for valid values for each
    /// of these keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Windows7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Windows8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Windows8.1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Windows8Embedded</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Windows10</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Windows10LTSB</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WindowsServer2008</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WindowsServer2008R2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WindowsServer2012</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WindowsServer2012R2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WindowsServer2016</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>CLASSIFICATION</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CriticalUpdates</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DefinitionUpdates</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Drivers</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>FeaturePacks</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SecurityUpdates</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ServicePacks</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Tools</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateRollups</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Updates</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Upgrades</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>MSRC_SEVERITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Critical</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Moderate</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Low</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Unspecified</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Ubuntu Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for Ubuntu operating systems are <code>PRODUCT</code>, <code>PRIORITY</code>,
    /// and <code>SECTION</code>. See the following lists for valid values for each of these
    /// keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Ubuntu14.04</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Ubuntu16.04</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>PRIORITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Required</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Standard</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Optional</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Extra</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>SECTION</code> 
    /// </para>
    ///  
    /// <para>
    /// Only the length of the key value is validated. Minimum length is 1. Maximum length
    /// is 64.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon Linux Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for Amazon Linux operating systems are <code>PRODUCT</code>, <code>CLASSIFICATION</code>,
    /// and <code>SEVERITY</code>. See the following lists for valid values for each of these
    /// keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AmazonLinux2012.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2012.09</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2013.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2013.09</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2014.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2014.09</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2015.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2015.09</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2016.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2016.09</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2017.03</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>AmazonLinux2017.09</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>CLASSIFICATION</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Security</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Bugfix</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Enhancement</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Recommended</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Newpackage</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>SEVERITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Critical</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Medium</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Low</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>RedHat Enterprise Linux (RHEL) Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for RedHat Enterprise Linux operating systems are <code>PRODUCT</code>,
    /// <code>CLASSIFICATION</code>, and <code>SEVERITY</code>. See the following lists for
    /// valid values for each of these keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux6.5</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux6.6</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux6.7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux6.8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux6.9</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux7.0</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux7.1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux7.2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux7.3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RedhatEnterpriseLinux7.4</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>CLASSIFICATION</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Security</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Bugfix</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Enhancement</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Recommended</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Newpackage</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>SEVERITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Critical</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Medium</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Low</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>SUSE Linux Enterprise Server (SLES) Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for SLES operating systems are <code>PRODUCT</code>, <code>CLASSIFICATION</code>,
    /// and <code>SEVERITY</code>. See the following lists for valid values for each of these
    /// keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Suse12.0</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.4</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.5</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.6</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Suse12.9</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>CLASSIFICATION</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Security</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Recommended</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Optional</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Feature</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Document</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Yast</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>SEVERITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Critical</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Moderate</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Low</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>CentOS Operating Systems</b> 
    /// </para>
    ///  
    /// <para>
    /// The supported keys for CentOS operating systems are <code>PRODUCT</code>, <code>CLASSIFICATION</code>,
    /// and <code>SEVERITY</code>. See the following lists for valid values for each of these
    /// keys.
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported key:</i> <code>PRODUCT</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CentOS6.5</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS6.6</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS6.7</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS6.8</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS6.9</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS7.0</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS7.1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS7.2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS7.3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CentOS7.4</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>CLASSIFICATION</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Security</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Bugfix</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Enhancement</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Recommended</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Newpackage</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Supported key:</i> <code>SEVERITY</code> 
    /// </para>
    ///  
    /// <para>
    ///  <i>Supported values:</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Critical</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Important</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Medium</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Low</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PatchFilter
    {
        private PatchFilterKey _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the filter.
        /// </para>
        ///  
        /// <para>
        /// See <a>PatchFilter</a> for lists of valid keys for each operating system type.
        /// </para>
        /// </summary>
        public PatchFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter key.
        /// </para>
        ///  
        /// <para>
        /// See <a>PatchFilter</a> for lists of valid values for each key based on operating system
        /// type.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the instance profile.
    /// </summary>
    public partial class InstanceProfile
    {
        private string _arn;
        private string _description;
        private List<string> _excludeAppPackagesFromCleanup = new List<string>();
        private string _name;
        private bool? _packageCleanup;
        private bool? _rebootAfterUse;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance profile.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the instance profile.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeAppPackagesFromCleanup. 
        /// <para>
        /// An array of strings specifying the list of app packages that should not be cleaned
        /// up from the device after a test run is over.
        /// </para>
        ///  
        /// <para>
        /// The list of packages is only considered if you set <code>packageCleanup</code> to
        /// <code>true</code>.
        /// </para>
        /// </summary>
        public List<string> ExcludeAppPackagesFromCleanup
        {
            get { return this._excludeAppPackagesFromCleanup; }
            set { this._excludeAppPackagesFromCleanup = value; }
        }

        // Check to see if ExcludeAppPackagesFromCleanup property is set
        internal bool IsSetExcludeAppPackagesFromCleanup()
        {
            return this._excludeAppPackagesFromCleanup != null && this._excludeAppPackagesFromCleanup.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the instance profile.
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
        /// Gets and sets the property PackageCleanup. 
        /// <para>
        /// When set to <code>true</code>, Device Farm will remove app packages after a test run.
        /// The default value is <code>false</code> for private devices.
        /// </para>
        /// </summary>
        public bool PackageCleanup
        {
            get { return this._packageCleanup.GetValueOrDefault(); }
            set { this._packageCleanup = value; }
        }

        // Check to see if PackageCleanup property is set
        internal bool IsSetPackageCleanup()
        {
            return this._packageCleanup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RebootAfterUse. 
        /// <para>
        /// When set to <code>true</code>, Device Farm will reboot the instance after a test run.
        /// The default value is <code>true</code>.
        /// </para>
        /// </summary>
        public bool RebootAfterUse
        {
            get { return this._rebootAfterUse.GetValueOrDefault(); }
            set { this._rebootAfterUse = value; }
        }

        // Check to see if RebootAfterUse property is set
        internal bool IsSetRebootAfterUse()
        {
            return this._rebootAfterUse.HasValue; 
        }

    }
}
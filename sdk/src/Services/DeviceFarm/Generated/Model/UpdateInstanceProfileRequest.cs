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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInstanceProfile operation.
    /// Updates information about an existing private device instance profile.
    /// </summary>
    public partial class UpdateInstanceProfileRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private string _description;
        private List<string> _excludeAppPackagesFromCleanup = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private bool? _packageCleanup;
        private bool? _rebootAfterUse;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
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
        /// The updated description for your instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
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
        /// An array of strings that specifies the list of app packages that should not be cleaned
        /// up from the device after a test run is over.
        /// </para>
        ///  
        /// <para>
        /// The list of packages is only considered if you set <c>packageCleanup</c> to <c>true</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeAppPackagesFromCleanup
        {
            get { return this._excludeAppPackagesFromCleanup; }
            set { this._excludeAppPackagesFromCleanup = value; }
        }

        // Check to see if ExcludeAppPackagesFromCleanup property is set
        internal bool IsSetExcludeAppPackagesFromCleanup()
        {
            return this._excludeAppPackagesFromCleanup != null && (this._excludeAppPackagesFromCleanup.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for your instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// The updated choice for whether you want to specify package cleanup. The default value
        /// is <c>false</c> for private devices.
        /// </para>
        /// </summary>
        public bool? PackageCleanup
        {
            get { return this._packageCleanup; }
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
        /// The updated choice for whether you want to reboot the device after use. The default
        /// value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? RebootAfterUse
        {
            get { return this._rebootAfterUse; }
            set { this._rebootAfterUse = value; }
        }

        // Check to see if RebootAfterUse property is set
        internal bool IsSetRebootAfterUse()
        {
            return this._rebootAfterUse.HasValue; 
        }

    }
}
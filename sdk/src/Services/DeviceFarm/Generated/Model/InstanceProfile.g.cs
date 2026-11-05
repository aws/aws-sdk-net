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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Represents the instance profile.
    /// </summary>
    public partial class InstanceProfile
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExcludeAppPackagesFromCleanup. 
        /// <para>
        /// An array of strings containing the list of app packages that should not be cleaned
        /// up from the device after a test run completes.
        /// </para>
        ///  
        /// <para>
        /// The list of packages is considered only if you set <c>packageCleanup</c> to <c>true</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludeAppPackagesFromCleanup { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeAppPackagesFromCleanup property is set.
        /// </summary>
        internal bool IsSetExcludeAppPackagesFromCleanup() => this.ExcludeAppPackagesFromCleanup != null && (this.ExcludeAppPackagesFromCleanup.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PackageCleanup. 
        /// <para>
        /// When set to <c>true</c>, Device Farm removes app packages after a test run. The default
        /// value is <c>false</c> for private devices.
        /// </para>
        /// </summary>
        public bool? PackageCleanup { get; set; }

        /// <summary>
        /// Checks to see if the PackageCleanup property is set.
        /// </summary>
        internal bool IsSetPackageCleanup() => this.PackageCleanup.HasValue;

        /// <summary>
        /// Gets and sets the property RebootAfterUse. 
        /// <para>
        /// When set to <c>true</c>, Device Farm reboots the instance after a test run. The default
        /// value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? RebootAfterUse { get; set; }

        /// <summary>
        /// Checks to see if the RebootAfterUse property is set.
        /// </summary>
        internal bool IsSetRebootAfterUse() => this.RebootAfterUse.HasValue;
    }
}

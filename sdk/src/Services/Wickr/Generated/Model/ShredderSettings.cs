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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Configuration for the Wickr shredder feature, which writes random data over free memory
    /// and disk space on client devices. You can configure your Wickr shredder intensity
    /// using the parameters below. 
    /// 
    ///  <note> 
    /// <para>
    /// Secure Shredder will not write over files that are permanently stored on the device
    /// or saved outside of the Wickr client. Wickr Network Administrators are able to disable
    /// file downloads within Security Group Settings.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ShredderSettings
    {
        private bool? _canProcessManually;
        private int? _intensity;

        /// <summary>
        /// Gets and sets the property CanProcessManually. 
        /// <para>
        /// Specifies whether users can manually trigger the shredder to delete content.
        /// </para>
        /// </summary>
        public bool? CanProcessManually
        {
            get { return this._canProcessManually; }
            set { this._canProcessManually = value; }
        }

        // Check to see if CanProcessManually property is set
        internal bool IsSetCanProcessManually()
        {
            return this._canProcessManually.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Intensity. 
        /// <para>
        /// Controls the rate (MB/minute) at which the shredder function runs on clients. Valid
        /// Values: Must be one of [0, 20, 60, 100].
        /// </para>
        ///  <note> 
        /// <para>
        /// A higher intensity setting could lead to higher battery usage on mobile devices.
        /// </para>
        ///  </note>
        /// </summary>
        public int? Intensity
        {
            get { return this._intensity; }
            set { this._intensity = value; }
        }

        // Check to see if Intensity property is set
        internal bool IsSetIntensity()
        {
            return this._intensity.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Configure image tests for your pipeline build. Tests run after building the image,
    /// to verify that the AMI or container image is valid before distributing it.
    /// </summary>
    public partial class ImageTestsConfiguration
    {
        private bool? _imageTestsEnabled;
        private int? _timeoutMinutes;

        /// <summary>
        /// Gets and sets the property ImageTestsEnabled. 
        /// <para>
        /// Determines if tests should run after building the image. Image Builder defaults to
        /// enable tests to run following the image build, before image distribution.
        /// </para>
        /// </summary>
        public bool ImageTestsEnabled
        {
            get { return this._imageTestsEnabled.GetValueOrDefault(); }
            set { this._imageTestsEnabled = value; }
        }

        // Check to see if ImageTestsEnabled property is set
        internal bool IsSetImageTestsEnabled()
        {
            return this._imageTestsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The maximum time in minutes that tests are permitted to run.
        /// </para>
        ///  <note> 
        /// <para>
        /// The timeoutMinutes attribute is not currently active. This value is ignored.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=60, Max=1440)]
        public int TimeoutMinutes
        {
            get { return this._timeoutMinutes.GetValueOrDefault(); }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

    }
}
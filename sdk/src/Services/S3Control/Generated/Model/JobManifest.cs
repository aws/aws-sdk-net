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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration information for a job's manifest.
    /// </summary>
    public partial class JobManifest
    {
        private JobManifestLocation _location;
        private JobManifestSpec _spec;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Contains the information required to locate the specified job's manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobManifestLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// Describes the format of the specified job's manifest. If the manifest is in CSV format,
        /// also describes the columns contained within the manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobManifestSpec Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

    }
}
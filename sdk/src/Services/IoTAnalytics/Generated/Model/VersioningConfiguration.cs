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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Information about the versioning of dataset contents.
    /// </summary>
    public partial class VersioningConfiguration
    {
        private int? _maxVersions;
        private bool? _unlimited;

        /// <summary>
        /// Gets and sets the property MaxVersions. 
        /// <para>
        /// How many versions of dataset contents are kept. The <c>unlimited</c> parameter must
        /// be <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxVersions
        {
            get { return this._maxVersions; }
            set { this._maxVersions = value; }
        }

        // Check to see if MaxVersions property is set
        internal bool IsSetMaxVersions()
        {
            return this._maxVersions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unlimited. 
        /// <para>
        /// If true, unlimited versions of dataset contents are kept.
        /// </para>
        /// </summary>
        public bool? Unlimited
        {
            get { return this._unlimited; }
            set { this._unlimited = value; }
        }

        // Check to see if Unlimited property is set
        internal bool IsSetUnlimited()
        {
            return this._unlimited.HasValue; 
        }

    }
}
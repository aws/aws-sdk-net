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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of default EBS storage settings that apply to spaces created within a
    /// domain or user profile.
    /// </summary>
    public partial class DefaultEbsStorageSettings
    {
        private int? _defaultEbsVolumeSizeInGb;
        private int? _maximumEbsVolumeSizeInGb;

        /// <summary>
        /// Gets and sets the property DefaultEbsVolumeSizeInGb. 
        /// <para>
        /// The default size of the EBS storage volume for a space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=16384)]
        public int? DefaultEbsVolumeSizeInGb
        {
            get { return this._defaultEbsVolumeSizeInGb; }
            set { this._defaultEbsVolumeSizeInGb = value; }
        }

        // Check to see if DefaultEbsVolumeSizeInGb property is set
        internal bool IsSetDefaultEbsVolumeSizeInGb()
        {
            return this._defaultEbsVolumeSizeInGb.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumEbsVolumeSizeInGb. 
        /// <para>
        /// The maximum size of the EBS storage volume for a space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=16384)]
        public int? MaximumEbsVolumeSizeInGb
        {
            get { return this._maximumEbsVolumeSizeInGb; }
            set { this._maximumEbsVolumeSizeInGb = value; }
        }

        // Check to see if MaximumEbsVolumeSizeInGb property is set
        internal bool IsSetMaximumEbsVolumeSizeInGb()
        {
            return this._maximumEbsVolumeSizeInGb.HasValue; 
        }

    }
}
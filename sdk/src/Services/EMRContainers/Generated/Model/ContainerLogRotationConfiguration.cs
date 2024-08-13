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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The settings for container log rotation.
    /// </summary>
    public partial class ContainerLogRotationConfiguration
    {
        private int? _maxFilesToKeep;
        private string _rotationSize;

        /// <summary>
        /// Gets and sets the property MaxFilesToKeep. 
        /// <para>
        /// The number of files to keep in container after rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public int? MaxFilesToKeep
        {
            get { return this._maxFilesToKeep; }
            set { this._maxFilesToKeep = value; }
        }

        // Check to see if MaxFilesToKeep property is set
        internal bool IsSetMaxFilesToKeep()
        {
            return this._maxFilesToKeep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationSize. 
        /// <para>
        /// The file size at which to rotate logs. Minimum of 2KB, Maximum of 2GB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=12)]
        public string RotationSize
        {
            get { return this._rotationSize; }
            set { this._rotationSize = value; }
        }

        // Check to see if RotationSize property is set
        internal bool IsSetRotationSize()
        {
            return this._rotationSize != null;
        }

    }
}
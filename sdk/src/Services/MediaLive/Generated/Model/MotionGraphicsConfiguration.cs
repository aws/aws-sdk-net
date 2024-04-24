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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Motion Graphics Configuration
    /// </summary>
    public partial class MotionGraphicsConfiguration
    {
        private MotionGraphicsInsertion _motionGraphicsInsertion;
        private MotionGraphicsSettings _motionGraphicsSettings;

        /// <summary>
        /// Gets and sets the property MotionGraphicsInsertion.
        /// </summary>
        public MotionGraphicsInsertion MotionGraphicsInsertion
        {
            get { return this._motionGraphicsInsertion; }
            set { this._motionGraphicsInsertion = value; }
        }

        // Check to see if MotionGraphicsInsertion property is set
        internal bool IsSetMotionGraphicsInsertion()
        {
            return this._motionGraphicsInsertion != null;
        }

        /// <summary>
        /// Gets and sets the property MotionGraphicsSettings. Motion Graphics Settings
        /// </summary>
        [AWSProperty(Required=true)]
        public MotionGraphicsSettings MotionGraphicsSettings
        {
            get { return this._motionGraphicsSettings; }
            set { this._motionGraphicsSettings = value; }
        }

        // Check to see if MotionGraphicsSettings property is set
        internal bool IsSetMotionGraphicsSettings()
        {
            return this._motionGraphicsSettings != null;
        }

    }
}
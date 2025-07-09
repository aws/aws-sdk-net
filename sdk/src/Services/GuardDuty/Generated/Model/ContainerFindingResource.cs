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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about container resources involved in a GuardDuty finding. This
    /// structure provides details about containers that were identified as part of suspicious
    /// or malicious activity.
    /// </summary>
    public partial class ContainerFindingResource
    {
        private string _image;
        private string _imageUid;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The container image information, including the image name and tag used to run the
        /// container that was involved in the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ImageUid. 
        /// <para>
        /// The unique ID associated with the container image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ImageUid
        {
            get { return this._imageUid; }
            set { this._imageUid = value; }
        }

        // Check to see if ImageUid property is set
        internal bool IsSetImageUid()
        {
            return this._imageUid != null;
        }

    }
}
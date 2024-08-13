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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about an AMI that is currently in the Recycle Bin.
    /// </summary>
    public partial class ImageRecycleBinInfo
    {
        private string _description;
        private string _imageId;
        private string _name;
        private DateTime? _recycleBinEnterTime;
        private DateTime? _recycleBinExitTime;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AMI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AMI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RecycleBinEnterTime. 
        /// <para>
        /// The date and time when the AMI entered the Recycle Bin.
        /// </para>
        /// </summary>
        public DateTime? RecycleBinEnterTime
        {
            get { return this._recycleBinEnterTime; }
            set { this._recycleBinEnterTime = value; }
        }

        // Check to see if RecycleBinEnterTime property is set
        internal bool IsSetRecycleBinEnterTime()
        {
            return this._recycleBinEnterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecycleBinExitTime. 
        /// <para>
        /// The date and time when the AMI is to be permanently deleted from the Recycle Bin.
        /// </para>
        /// </summary>
        public DateTime? RecycleBinExitTime
        {
            get { return this._recycleBinExitTime; }
            set { this._recycleBinExitTime = value; }
        }

        // Check to see if RecycleBinExitTime property is set
        internal bool IsSetRecycleBinExitTime()
        {
            return this._recycleBinExitTime.HasValue; 
        }

    }
}
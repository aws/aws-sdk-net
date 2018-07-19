/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// A JSON-formatted object that contains the IDs for an Amazon Machine Image (AMI), including
    /// the Amazon EC2 AMI ID and the Snowball Edge AMI ID. Each AMI has these two IDs to
    /// simplify identifying the AMI in both the AWS Cloud and on the device.
    /// </summary>
    public partial class Ec2AmiResource
    {
        private string _amiId;
        private string _snowballAmiId;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the AMI in Amazon EC2.
        /// </para>
        /// </summary>
        public string AmiId
        {
            get { return this._amiId; }
            set { this._amiId = value; }
        }

        // Check to see if AmiId property is set
        internal bool IsSetAmiId()
        {
            return this._amiId != null;
        }

        /// <summary>
        /// Gets and sets the property SnowballAmiId. 
        /// <para>
        /// The ID of the AMI on the Snowball Edge device.
        /// </para>
        /// </summary>
        public string SnowballAmiId
        {
            get { return this._snowballAmiId; }
            set { this._snowballAmiId = value; }
        }

        // Check to see if SnowballAmiId property is set
        internal bool IsSetSnowballAmiId()
        {
            return this._snowballAmiId != null;
        }

    }
}
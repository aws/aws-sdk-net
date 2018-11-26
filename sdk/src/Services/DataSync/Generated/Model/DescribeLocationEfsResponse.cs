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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// DescribeLocationEfsResponse
    /// </summary>
    public partial class DescribeLocationEfsResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private Ec2Config _ec2Config;
        private string _locationArn;
        private string _locationUri;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the EFS location was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2Config.
        /// </summary>
        public Ec2Config Ec2Config
        {
            get { return this._ec2Config; }
            set { this._ec2Config = value; }
        }

        // Check to see if Ec2Config property is set
        internal bool IsSetEc2Config()
        {
            return this._ec2Config != null;
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon resource Name (ARN) of the EFS location that was described.
        /// </para>
        /// </summary>
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the EFS location that was described.
        /// </para>
        /// </summary>
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

    }
}
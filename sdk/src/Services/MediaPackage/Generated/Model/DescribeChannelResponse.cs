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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// This is the response object from the DescribeChannel operation.
    /// </summary>
    public partial class DescribeChannelResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private HlsIngest _hlsIngest;
        private string _id;

        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the Channel.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A short text description of the Channel.
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
        /// Gets and sets the property HlsIngest.
        /// </summary>
        public HlsIngest HlsIngest
        {
            get { return this._hlsIngest; }
            set { this._hlsIngest = value; }
        }

        // Check to see if HlsIngest property is set
        internal bool IsSetHlsIngest()
        {
            return this._hlsIngest != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the Channel.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}
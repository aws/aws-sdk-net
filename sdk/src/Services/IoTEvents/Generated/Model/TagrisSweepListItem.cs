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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TagrisSweepListItem
    {
        private string _tagrisAccountId;
        private string _tagrisAmazonResourceName;
        private string _tagrisInternalId;
        private long? _tagrisVersion;

        /// <summary>
        /// Gets and sets the property TagrisAccountId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string TagrisAccountId
        {
            get { return this._tagrisAccountId; }
            set { this._tagrisAccountId = value; }
        }

        // Check to see if TagrisAccountId property is set
        internal bool IsSetTagrisAccountId()
        {
            return this._tagrisAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TagrisAmazonResourceName.
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string TagrisAmazonResourceName
        {
            get { return this._tagrisAmazonResourceName; }
            set { this._tagrisAmazonResourceName = value; }
        }

        // Check to see if TagrisAmazonResourceName property is set
        internal bool IsSetTagrisAmazonResourceName()
        {
            return this._tagrisAmazonResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property TagrisInternalId.
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string TagrisInternalId
        {
            get { return this._tagrisInternalId; }
            set { this._tagrisInternalId = value; }
        }

        // Check to see if TagrisInternalId property is set
        internal bool IsSetTagrisInternalId()
        {
            return this._tagrisInternalId != null;
        }

        /// <summary>
        /// Gets and sets the property TagrisVersion.
        /// </summary>
        public long TagrisVersion
        {
            get { return this._tagrisVersion.GetValueOrDefault(); }
            set { this._tagrisVersion = value; }
        }

        // Check to see if TagrisVersion property is set
        internal bool IsSetTagrisVersion()
        {
            return this._tagrisVersion.HasValue; 
        }

    }
}
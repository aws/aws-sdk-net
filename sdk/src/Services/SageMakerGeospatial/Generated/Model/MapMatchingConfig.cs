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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MapMatchingConfig
    {
        private string _idAttributeName;
        private string _timestampAttributeName;
        private string _xAttributeName;
        private string _yAttributeName;

        /// <summary>
        /// Gets and sets the property IdAttributeName.
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdAttributeName
        {
            get { return this._idAttributeName; }
            set { this._idAttributeName = value; }
        }

        // Check to see if IdAttributeName property is set
        internal bool IsSetIdAttributeName()
        {
            return this._idAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampAttributeName. 
        /// <para>
        /// The name of the timestamp attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimestampAttributeName
        {
            get { return this._timestampAttributeName; }
            set { this._timestampAttributeName = value; }
        }

        // Check to see if TimestampAttributeName property is set
        internal bool IsSetTimestampAttributeName()
        {
            return this._timestampAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property XAttributeName. 
        /// <para>
        /// The name of the X-attribute
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string XAttributeName
        {
            get { return this._xAttributeName; }
            set { this._xAttributeName = value; }
        }

        // Check to see if XAttributeName property is set
        internal bool IsSetXAttributeName()
        {
            return this._xAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property YAttributeName. 
        /// <para>
        /// The name of the Y-attribute
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string YAttributeName
        {
            get { return this._yAttributeName; }
            set { this._yAttributeName = value; }
        }

        // Check to see if YAttributeName property is set
        internal bool IsSetYAttributeName()
        {
            return this._yAttributeName != null;
        }

    }
}
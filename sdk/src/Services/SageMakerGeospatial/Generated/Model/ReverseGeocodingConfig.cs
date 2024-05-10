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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The input structure for Reverse Geocoding operation type.
    /// </summary>
    public partial class ReverseGeocodingConfig
    {
        private string _xAttributeName;
        private string _yAttributeName;

        /// <summary>
        /// Gets and sets the property XAttributeName. 
        /// <para>
        /// The field name for the data that describes x-axis coordinate, eg. longitude of a point.
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
        /// The field name for the data that describes y-axis coordinate, eg. latitude of a point.
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
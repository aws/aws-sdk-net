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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticInference.Model
{
    /// <summary>
    /// The offering for an Elastic Inference Accelerator type.
    /// </summary>
    public partial class AcceleratorTypeOffering
    {
        private string _acceleratorType;
        private string _location;
        private LocationType _locationType;

        /// <summary>
        /// Gets and sets the property AcceleratorType. 
        /// <para>
        ///  The name of the Elastic Inference Accelerator type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AcceleratorType
        {
            get { return this._acceleratorType; }
            set { this._acceleratorType = value; }
        }

        // Check to see if AcceleratorType property is set
        internal bool IsSetAcceleratorType()
        {
            return this._acceleratorType != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location for the offering. It will return either the region, availability zone
        /// or availability zone id for the offering depending on the locationType value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property LocationType. 
        /// <para>
        ///  The location type for the offering. It can assume the following values: region: defines
        /// that the offering is at the regional level. availability-zone: defines that the offering
        /// is at the availability zone level. availability-zone-id: defines that the offering
        /// is at the availability zone level, defined by the availability zone id. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public LocationType LocationType
        {
            get { return this._locationType; }
            set { this._locationType = value; }
        }

        // Check to see if LocationType property is set
        internal bool IsSetLocationType()
        {
            return this._locationType != null;
        }

    }
}
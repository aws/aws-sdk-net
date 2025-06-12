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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the DetectProfileObjectType operation.
    /// </summary>
    public partial class DetectProfileObjectTypeResponse : AmazonWebServiceResponse
    {
        private List<DetectedProfileObjectType> _detectedProfileObjectTypes = AWSConfigs.InitializeCollections ? new List<DetectedProfileObjectType>() : null;

        /// <summary>
        /// Gets and sets the property DetectedProfileObjectTypes. 
        /// <para>
        /// Detected <c>ProfileObjectType</c> mappings from given objects. A maximum of one mapping
        /// is supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetectedProfileObjectType> DetectedProfileObjectTypes
        {
            get { return this._detectedProfileObjectTypes; }
            set { this._detectedProfileObjectTypes = value; }
        }

        // Check to see if DetectedProfileObjectTypes property is set
        internal bool IsSetDetectedProfileObjectTypes()
        {
            return this._detectedProfileObjectTypes != null && (this._detectedProfileObjectTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
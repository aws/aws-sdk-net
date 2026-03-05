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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Configuration details for input patient data
    /// </summary>
    public partial class InputDataConfig
    {
        private FHIRServer _fhirServer;
        private List<S3Source> _s3Sources = AWSConfigs.InitializeCollections ? new List<S3Source>() : null;

        /// <summary>
        /// Gets and sets the property FhirServer. 
        /// <para>
        /// FHIR server configuration to retrieve patient data.
        /// </para>
        /// </summary>
        public FHIRServer FhirServer
        {
            get { return this._fhirServer; }
            set { this._fhirServer = value; }
        }

        // Check to see if FhirServer property is set
        internal bool IsSetFhirServer()
        {
            return this._fhirServer != null;
        }

        /// <summary>
        /// Gets and sets the property S3Sources. 
        /// <para>
        /// List of S3 sources containing patient data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<S3Source> S3Sources
        {
            get { return this._s3Sources; }
            set { this._s3Sources = value; }
        }

        // Check to see if S3Sources property is set
        internal bool IsSetS3Sources()
        {
            return this._s3Sources != null && (this._s3Sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
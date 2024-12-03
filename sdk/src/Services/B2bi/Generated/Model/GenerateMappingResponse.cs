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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the GenerateMapping operation.
    /// </summary>
    public partial class GenerateMappingResponse : AmazonWebServiceResponse
    {
        private float? _mappingAccuracy;
        private string _mappingTemplate;

        /// <summary>
        /// Gets and sets the property MappingAccuracy. 
        /// <para>
        /// Returns a percentage that estimates the accuracy of the generated mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? MappingAccuracy
        {
            get { return this._mappingAccuracy; }
            set { this._mappingAccuracy = value; }
        }

        // Check to see if MappingAccuracy property is set
        internal bool IsSetMappingAccuracy()
        {
            return this._mappingAccuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MappingTemplate. 
        /// <para>
        /// Returns a mapping template based on your inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MappingTemplate
        {
            get { return this._mappingTemplate; }
            set { this._mappingTemplate = value; }
        }

        // Check to see if MappingTemplate property is set
        internal bool IsSetMappingTemplate()
        {
            return this._mappingTemplate != null;
        }

    }
}
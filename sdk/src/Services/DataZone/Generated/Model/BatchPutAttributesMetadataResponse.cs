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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the BatchPutAttributesMetadata operation.
    /// </summary>
    public partial class BatchPutAttributesMetadataResponse : AmazonWebServiceResponse
    {
        private List<BatchPutAttributeOutput> _attributes = AWSConfigs.InitializeCollections ? new List<BatchPutAttributeOutput>() : null;
        private List<AttributeError> _errors = AWSConfigs.InitializeCollections ? new List<AttributeError>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The results of the BatchPutAttributeMetadata action.
        /// </para>
        /// </summary>
        public List<BatchPutAttributeOutput> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// The errors generated when the BatchPutAttributeMetadata action is invoked.
        /// </para>
        /// </summary>
        public List<AttributeError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the CopyImageSet operation.
    /// </summary>
    public partial class CopyImageSetResponse : AmazonWebServiceResponse
    {
        private string _datastoreId;
        private CopyDestinationImageSetProperties _destinationImageSetProperties;
        private CopySourceImageSetProperties _sourceImageSetProperties;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationImageSetProperties. 
        /// <para>
        /// The properties of the destination image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CopyDestinationImageSetProperties DestinationImageSetProperties
        {
            get { return this._destinationImageSetProperties; }
            set { this._destinationImageSetProperties = value; }
        }

        // Check to see if DestinationImageSetProperties property is set
        internal bool IsSetDestinationImageSetProperties()
        {
            return this._destinationImageSetProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SourceImageSetProperties. 
        /// <para>
        /// The properties of the source image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CopySourceImageSetProperties SourceImageSetProperties
        {
            get { return this._sourceImageSetProperties; }
            set { this._sourceImageSetProperties = value; }
        }

        // Check to see if SourceImageSetProperties property is set
        internal bool IsSetSourceImageSetProperties()
        {
            return this._sourceImageSetProperties != null;
        }

    }
}
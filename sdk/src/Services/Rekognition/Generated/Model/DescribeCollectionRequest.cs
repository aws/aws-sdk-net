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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCollection operation.
    /// Describes the specified collection. You can use <c>DescribeCollection</c> to get information,
    /// such as the number of faces indexed into a collection and the version of the model
    /// used by the collection for face detection.
    /// 
    ///  
    /// <para>
    /// For more information, see Describing a Collection in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    /// </summary>
    public partial class DescribeCollectionRequest : AmazonRekognitionRequest
    {
        private string _collectionId;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of the collection to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CollectionId
        {
            get { return this._collectionId; }
            set { this._collectionId = value; }
        }

        // Check to see if CollectionId property is set
        internal bool IsSetCollectionId()
        {
            return this._collectionId != null;
        }

    }
}
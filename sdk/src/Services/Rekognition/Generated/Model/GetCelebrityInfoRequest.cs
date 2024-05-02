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
    /// Container for the parameters to the GetCelebrityInfo operation.
    /// Gets the name and additional information about a celebrity based on their Amazon Rekognition
    /// ID. The additional information is returned as an array of URLs. If there is no additional
    /// information about the celebrity, this list is empty.
    /// 
    ///  
    /// <para>
    /// For more information, see Getting information about a celebrity in the Amazon Rekognition
    /// Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:GetCelebrityInfo</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class GetCelebrityInfoRequest : AmazonRekognitionRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the celebrity. You get the celebrity ID from a call to the <a>RecognizeCelebrities</a>
        /// operation, which recognizes celebrities in an image. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}
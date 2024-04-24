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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the DescribeEntityRecognizer operation.
    /// </summary>
    public partial class DescribeEntityRecognizerResponse : AmazonWebServiceResponse
    {
        private EntityRecognizerProperties _entityRecognizerProperties;

        /// <summary>
        /// Gets and sets the property EntityRecognizerProperties. 
        /// <para>
        /// Describes information associated with an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerProperties EntityRecognizerProperties
        {
            get { return this._entityRecognizerProperties; }
            set { this._entityRecognizerProperties = value; }
        }

        // Check to see if EntityRecognizerProperties property is set
        internal bool IsSetEntityRecognizerProperties()
        {
            return this._entityRecognizerProperties != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the CreateRelatedItem operation.
    /// </summary>
    public partial class CreateRelatedItemResponse : AmazonWebServiceResponse
    {
        private string _relatedItemArn;
        private string _relatedItemId;

        /// <summary>
        /// Gets and sets the property RelatedItemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string RelatedItemArn
        {
            get { return this._relatedItemArn; }
            set { this._relatedItemArn = value; }
        }

        // Check to see if RelatedItemArn property is set
        internal bool IsSetRelatedItemArn()
        {
            return this._relatedItemArn != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// The unique identifier of the related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string RelatedItemId
        {
            get { return this._relatedItemId; }
            set { this._relatedItemId = value; }
        }

        // Check to see if RelatedItemId property is set
        internal bool IsSetRelatedItemId()
        {
            return this._relatedItemId != null;
        }

    }
}
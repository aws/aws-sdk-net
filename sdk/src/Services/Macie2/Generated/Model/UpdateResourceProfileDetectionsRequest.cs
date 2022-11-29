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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResourceProfileDetections operation.
    /// Updates the sensitivity scoring settings for an S3 bucket.
    /// </summary>
    public partial class UpdateResourceProfileDetectionsRequest : AmazonMacie2Request
    {
        private string _resourceArn;
        private List<SuppressDataIdentifier> _suppressDataIdentifiers = new List<SuppressDataIdentifier>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket that the request applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressDataIdentifiers. 
        /// <para>
        /// An array of objects, one for each custom data identifier or managed data identifier
        /// that detected the type of sensitive data to start excluding or including in the bucket's
        /// score. To start including all sensitive data types in the score, don't specify any
        /// values for this array.
        /// </para>
        /// </summary>
        public List<SuppressDataIdentifier> SuppressDataIdentifiers
        {
            get { return this._suppressDataIdentifiers; }
            set { this._suppressDataIdentifiers = value; }
        }

        // Check to see if SuppressDataIdentifiers property is set
        internal bool IsSetSuppressDataIdentifiers()
        {
            return this._suppressDataIdentifiers != null && this._suppressDataIdentifiers.Count > 0; 
        }

    }
}
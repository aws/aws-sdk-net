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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the current status of an allow list, which indicates whether
    /// Amazon Macie can access and use the list's criteria.
    /// </summary>
    public partial class AllowListStatus
    {
        private AllowListStatusCode _code;
        private string _description;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The current status of the allow list. If the list's criteria specify a regular expression
        /// (regex), this value is typically OK. Amazon Macie can compile the expression.
        /// </para>
        ///  
        /// <para>
        /// If the list's criteria specify an S3 object, possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// OK - Macie can retrieve and parse the contents of the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_OBJECT_ACCESS_DENIED - Macie isn't allowed to access the object or the object is
        /// encrypted with a customer managed KMS key that Macie isn't allowed to use. Check the
        /// bucket policy and other permissions settings for the bucket and the object. If the
        /// object is encrypted, also ensure that it's encrypted with a key that Macie is allowed
        /// to use.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_OBJECT_EMPTY - Macie can retrieve the object but the object doesn't contain any
        /// content. Ensure that the object contains the correct entries. Also ensure that the
        /// list's criteria specify the correct bucket and object names.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_OBJECT_NOT_FOUND - The object doesn't exist in Amazon S3. Ensure that the list's
        /// criteria specify the correct bucket and object names.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_OBJECT_OVERSIZE - Macie can retrieve the object. However, the object contains too
        /// many entries or its storage size exceeds the quota for an allow list. Try breaking
        /// the list into multiple files and ensure that each file doesn't exceed any quotas.
        /// Then configure list settings in Macie for each file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_THROTTLED - Amazon S3 throttled the request to retrieve the object. Wait a few
        /// minutes and then try again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// S3_USER_ACCESS_DENIED - Amazon S3 denied the request to retrieve the object. If the
        /// specified object exists, you're not allowed to access it or it's encrypted with an
        /// KMS key that you're not allowed to use. Work with your Amazon Web Services administrator
        /// to ensure that the list's criteria specify the correct bucket and object names, and
        /// you have read access to the bucket and the object. If the object is encrypted, also
        /// ensure that it's encrypted with a key that you're allowed to use.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN_ERROR - A transient or internal error occurred when Macie attempted to retrieve
        /// or parse the object. Wait a few minutes and then try again. A list can also have this
        /// status if it's encrypted with a key that Amazon S3 and Macie can't access or use.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowListStatusCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the status of the allow list. Amazon Macie uses this value
        /// to provide additional information about an error that occurred when Macie tried to
        /// access and use the list's criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}
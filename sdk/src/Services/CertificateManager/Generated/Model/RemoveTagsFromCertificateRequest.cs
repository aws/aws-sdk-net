/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveTagsFromCertificate operation.
    /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
    /// If you do not specify the value portion of the tag when calling this function, the
    /// tag will be removed regardless of value. If you specify a value, the tag is removed
    /// only if it is associated with the specified value. 
    /// 
    ///  
    /// <para>
    /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
    /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
    /// action. 
    /// </para>
    /// </summary>
    public partial class RemoveTagsFromCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// String that contains the ARN of the ACM Certificate with one or more tags that you
        /// want to remove. This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>. 
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that defines the tag to remove.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the AddTagsToCertificate operation.
    /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
    /// and organize your AWS resources. Each tag consists of a <code>key</code> and an optional
    /// <code>value</code>. You specify the certificate on input by its Amazon Resource Name
    /// (ARN). You specify the tag by using a key-value pair. 
    /// 
    ///  
    /// <para>
    /// You can apply a tag to just one certificate if you want to identify a specific characteristic
    /// of that certificate, or you can apply the same tag to multiple certificates if you
    /// want to filter for a common relationship among those certificates. Similarly, you
    /// can apply the same tag to multiple resources if you want to specify a relationship
    /// among those resources. For example, you can add the same tag to an ACM certificate
    /// and an Elastic Load Balancing load balancer to indicate that they are both used by
    /// the same website. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
    /// ACM certificates</a>. 
    /// </para>
    ///  
    /// <para>
    /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
    /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
    /// action. 
    /// </para>
    /// </summary>
    public partial class AddTagsToCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// String that contains the ARN of the ACM certificate to which the tag is to be applied.
        /// This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// The key-value pair that defines the tag. The tag value is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
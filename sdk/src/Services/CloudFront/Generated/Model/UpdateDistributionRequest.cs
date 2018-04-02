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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDistribution operation.
    /// Updates the configuration for a web distribution. Perform the following steps.
    /// 
    ///  
    /// <para>
    /// For information about updating a distribution using the CloudFront console, see <a
    /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-creating-console.html">Creating
    /// or Updating a Web Distribution Using the CloudFront Console </a> in the <i>Amazon
    /// CloudFront Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>To update a web distribution using the CloudFront API</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>GetDistributionConfig</a> request to get the current configuration and
    /// an <code>Etag</code> header for the distribution.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you update the distribution again, you need to get a new <code>Etag</code> header.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// Update the XML document that was returned in the response to your <code>GetDistributionConfig</code>
    /// request to include the desired changes. You can't change the value of <code>CallerReference</code>.
    /// If you try to change this value, CloudFront returns an <code>IllegalUpdate</code>
    /// error.
    /// </para>
    ///  <important> 
    /// <para>
    /// The new configuration replaces the existing configuration; the values that you specify
    /// in an <code>UpdateDistribution</code> request are not merged into the existing configuration.
    /// When you add, delete, or replace values in an element that allows multiple values
    /// (for example, <code>CNAME</code>), you must specify all of the values that you want
    /// to appear in the updated distribution. In addition, you must update the corresponding
    /// <code>Quantity</code> element.
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    /// Submit an <code>UpdateDistribution</code> request to update the configuration for
    /// your distribution:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In the request body, include the XML document that you updated in Step 2. The request
    /// body must include an XML document with a <code>DistributionConfig</code> element.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Set the value of the HTTP <code>If-Match</code> header to the value of the <code>ETag</code>
    /// header that CloudFront returned when you submitted the <code>GetDistributionConfig</code>
    /// request in Step 1.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Review the response to the <code>UpdateDistribution</code> request to confirm that
    /// the configuration was successfully updated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Optional: Submit a <a>GetDistribution</a> request to confirm that your changes have
    /// propagated. When propagation is complete, the value of <code>Status</code> is <code>Deployed</code>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Beginning with the 2012-05-05 version of the CloudFront API, we made substantial changes
    /// to the format of the XML document that you include in the request body when you create
    /// or update a distribution. With previous versions of the API, we discovered that it
    /// was too easy to accidentally delete one or more values for an element that accepts
    /// multiple values, for example, CNAMEs and trusted signers. Our changes for the 2012-05-05
    /// release are intended to prevent these accidental deletions and to notify you when
    /// there's a mismatch between the number of values you say you're specifying in the <code>Quantity</code>
    /// element and the number of values you're actually specifying.
    /// </para>
    ///  </important> </li> </ol>
    /// </summary>
    public partial class UpdateDistributionRequest : AmazonCloudFrontRequest
    {
        private DistributionConfig _distributionConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateDistributionRequest() { }

        /// <summary>
        /// Instantiates UpdateDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution's id.</param>
        /// <param name="ifMatch">The value of the <code>ETag</code> header that you received when retrieving the distribution's configuration. For example: <code>E2QWRUHAPOMQZL</code>.</param>
        /// <param name="distributionConfig">The distribution's configuration information.</param>
        public UpdateDistributionRequest(string id, string ifMatch, DistributionConfig distributionConfig)
        {
            _id = id;
            _ifMatch = ifMatch;
            _distributionConfig = distributionConfig;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        public DistributionConfig DistributionConfig
        {
            get { return this._distributionConfig; }
            set { this._distributionConfig = value; }
        }

        // Check to see if DistributionConfig property is set
        internal bool IsSetDistributionConfig()
        {
            return this._distributionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution's id.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <code>ETag</code> header that you received when retrieving the distribution's
        /// configuration. For example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}